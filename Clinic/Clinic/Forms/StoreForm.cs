using Clinic.Data;
using Clinic.Data.Entities;
using Clinic.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq;

namespace Clinic.Forms
{
    public partial class StoreForm : Form
    {
        private ApplicationDbContext? applicationDbContext;
        private RecipeEditForm? recipeEditForm;
        private ExpenseEditForm? expenseEditForm;

        public StoreForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            LoadDataContext();
            SetDataGridView();

            recipeEditForm = new RecipeEditForm()
            {
                StartPosition = FormStartPosition.CenterParent,
                units = applicationDbContext!.Units.Local.ToList(),
                products = applicationDbContext!.Products.Local.ToList(),
                providers = applicationDbContext!.Providers.Local.ToList(),
            };

            expenseEditForm = new ExpenseEditForm()
            {
                StartPosition = FormStartPosition.CenterParent,
                units = applicationDbContext!.Units.Local.ToList(),
                employees = applicationDbContext!.Employees.Local.ToList(),
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;

            recipeEditForm!.Dispose();
            expenseEditForm = null;
        }

        private void LoadDataContext()
        {
            applicationDbContext!.Units.Load();
            applicationDbContext!.Products.Load();
            applicationDbContext!.Providers.Load();
            applicationDbContext!.Employees.Load();
            applicationDbContext!.RecipeItems.Load();
            applicationDbContext!.ExpenseItems.Load();

            applicationDbContext!.Recipes.Include(r => r.Provider).Load();
            applicationDbContext!.Expenses.Include(r => r.Employee).Load();

            recipeBindingSource.DataSource = applicationDbContext!.Recipes.Local.ToBindingList();
            expenseBindingSource.DataSource = applicationDbContext!.Expenses.Local.ToBindingList();
        }

        private void SetDataGridView()
        {
            dataGridViewStore.DataSource = GetStoreItems();
            dataGridViewStore.Columns[0].HeaderText = "Наименование";
            dataGridViewStore.Columns[1].HeaderText = "Единицы измерения";
            dataGridViewStore.Columns[2].HeaderText = "Срок годности";
            dataGridViewStore.Columns[3].HeaderText = "Остаток";
            dataGridViewStore.Columns[4].Visible = false;

            dataGridViewStore.ReadOnly = true;
            dataGridViewStore.AllowUserToAddRows = false;
            dataGridViewStore.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewStore.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewRecipes.ReadOnly = true;
            dataGridViewRecipes.MultiSelect = false;
            dataGridViewRecipes.AllowUserToAddRows = false;
            dataGridViewRecipes.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewRecipes.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewRecipeItems.ReadOnly = true;
            dataGridViewRecipeItems.AllowUserToAddRows = false;
            dataGridViewRecipeItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewRecipeItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewRecipeItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipeItems.Columns[0].Visible = false;

            dataGridViewExpenses.ReadOnly = true;
            dataGridViewExpenses.MultiSelect = false;
            dataGridViewExpenses.AllowUserToAddRows = false;
            dataGridViewExpenses.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewExpenses.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewExpenseItems.ReadOnly = true;
            dataGridViewExpenseItems.AllowUserToAddRows = false;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewExpenseItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpenseItems.Columns[0].Visible = false;
        }

        private List<StoreModel> GetStoreItems()
        {
            applicationDbContext!.RecipeItems.Load();
            applicationDbContext!.ExpenseItems.Load();

            var result = applicationDbContext!.RecipeItems
                .GroupBy(rec => new { rec.ProductName, rec.ExpirationDate, rec.UnitName })
                .Select(rec => new StoreModel
                {
                    ProductName = rec.Key.ProductName,
                    ExpirationDate = rec.Key.ExpirationDate,
                    UnitName = rec.Key.UnitName,
                    Balance = rec.Sum(item => item.Quantity) -
                    applicationDbContext!.ExpenseItems
                    .Where(exp => exp.ProductName == rec.Key.ProductName && exp.ExpirationDate == rec.Key.ExpirationDate && exp.UnitName == rec.Key.UnitName)
                    .Sum(exp => exp.Quantity),
                }).ToList();

            return result;
        }

        private void toolStripButtonRecipeAdd_Click(object sender, EventArgs e)
        {
            recipeEditForm!.recipe = new Recipe()
            {
                Date = DateTime.Now,
                Provider = recipeEditForm!.providers!.First(),
            };

            if (recipeEditForm!.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.Recipes.Add(recipeEditForm.recipe);

                var recipeItemModelsToAdd = recipeEditForm!.recipeItemModels!.Where(r => r.IsChecked);

                applicationDbContext!.RecipeItems.AddRange(recipeItemModelsToAdd.Select(r => new RecipeItem
                {
                    RecipeId = recipeEditForm.recipe.Id,
                    Recipe = recipeEditForm!.recipe,
                    UnitName = r.UnitName,
                    ProductName = r.ProductName,
                    ExpirationDate = r.ExpirationDate,
                    Quantity = r.Quantity,
                }));

                applicationDbContext!.SaveChanges();

                applicationDbContext!.Entry((Recipe)recipeBindingSource.Current).Reload();
                recipeItemsBindingSource.ResetBindings(false);
            }
        }

        private void toolStripButtonRecipeEdit_Click(object sender, EventArgs e)
        {
            recipeEditForm!.recipe = (Recipe)recipeBindingSource.Current;
            if (recipeEditForm.ShowDialog(this) == DialogResult.OK)
            {
                var recipeId = recipeEditForm!.recipe.Id;
                var recipeItemModels = recipeEditForm!.recipeItemModels!.Where(r => r.IsChecked);
                var recipeItemModelsToAdd = recipeItemModels.Where(r => !r.Id.HasValue);
                var recipeItemModelsToUpdate = recipeItemModels.Where(r => r.Id.HasValue);
                var recipeItemModelsToRemove = recipeEditForm!.recipe.RecipeItems.Where(r => !recipeItemModels.Select(ri => ri.Id).Contains(r.Id)).Select(r => r.Id);

                if (recipeItemModelsToAdd != null)
                {
                    applicationDbContext!.RecipeItems.AddRange(recipeItemModelsToAdd.Select(r => new RecipeItem
                    {
                        RecipeId = recipeId,
                        Recipe = recipeEditForm!.recipe,
                        UnitName = r.UnitName,
                        ProductName = r.ProductName,
                        ExpirationDate = r.ExpirationDate,
                        Quantity = r.Quantity,
                    }));
                }

                if (recipeItemModelsToUpdate != null)
                {
                    foreach (var recipeItemModel in recipeItemModelsToUpdate)
                    {
                        var recipeItemToUpdate = applicationDbContext!.RecipeItems.First(recipeItem => recipeItem!.Id == recipeItemModel.Id);
                        recipeItemToUpdate!.UnitName = recipeItemModel.UnitName;
                        recipeItemToUpdate.ProductName = recipeItemModel.ProductName;
                        recipeItemToUpdate.ExpirationDate = recipeItemModel.ExpirationDate;
                        recipeItemToUpdate.Quantity = recipeItemModel.Quantity;

                        applicationDbContext!.RecipeItems.Update(recipeItemToUpdate);
                    }
                }

                if (recipeItemModelsToRemove != null)
                {
                    applicationDbContext!.RecipeItems.RemoveRange(applicationDbContext!.RecipeItems.Where(r => recipeItemModelsToRemove.Contains(r.Id)));
                }

                applicationDbContext!.SaveChanges();
            }
            else
            {
                recipeBindingSource.CancelEdit();
            }

            applicationDbContext!.Entry((Recipe)recipeBindingSource.Current).Reload();
            recipeItemsBindingSource.ResetBindings(false);
        }

        private void toolStripButtonRecipeRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                recipeBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonExpenseAdd_Click(object sender, EventArgs e)
        {
            expenseEditForm!.storeItems = GetStoreItems();
            expenseEditForm!.expense = new Expense()
            {
                Date = DateTime.Now,
                Employee = expenseEditForm!.employees!.First(),
            };

            if (expenseEditForm!.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.Expenses.Add(expenseEditForm.expense);

                var expenseItemModelsToAdd = expenseEditForm!.expenseItemModels!.Where(r => r.IsChecked);

                applicationDbContext!.ExpenseItems.AddRange(expenseItemModelsToAdd.Select(r => new ExpenseItem
                {
                    ExpenseId = expenseEditForm.expense.Id,
                    Expense = expenseEditForm!.expense,
                    UnitName = r.UnitName,
                    ProductName = r.ProductName,
                    ExpirationDate = r.ExpirationDate,
                    Quantity = r.Quantity,
                }));

                applicationDbContext!.SaveChanges();

                applicationDbContext!.Entry((Expense)expenseBindingSource.Current).Reload();
                expenseItemsBindingSource.ResetBindings(false);
            }
        }

        private void toolStripButtonExpenseEdit_Click(object sender, EventArgs e)
        {
            expenseEditForm!.storeItems = GetStoreItems();
            expenseEditForm!.expense = (Expense)expenseBindingSource.Current;

            if (expenseEditForm.ShowDialog(this) == DialogResult.OK)
            {
                var expenseId = expenseEditForm!.expense.Id;
                var expenseItemModels = expenseEditForm!.expenseItemModels!.Where(r => r.IsChecked);
                var expenseItemModelsToAdd = expenseItemModels.Where(r => !r.Id.HasValue);
                var expenseItemModelsToUpdate = expenseItemModels.Where(r => r.Id.HasValue);
                var expenseItemModelsToRemove = expenseEditForm!.expense.ExpenseItems.Where(r => !expenseItemModels.Select(ri => ri.Id).Contains(r.Id)).Select(r => r.Id);

                if (expenseItemModelsToAdd != null)
                {
                    applicationDbContext!.ExpenseItems.AddRange(expenseItemModelsToAdd.Select(r => new ExpenseItem
                    {
                        ExpenseId = expenseId,
                        Expense = expenseEditForm!.expense,
                        UnitName = r.UnitName,
                        ProductName = r.ProductName,
                        ExpirationDate = r.ExpirationDate,
                        Quantity = r.Quantity,
                    }));
                }

                if (expenseItemModelsToUpdate != null)
                {
                    foreach (var expenseItemModel in expenseItemModelsToUpdate)
                    {
                        var expenseItemToUpdate = applicationDbContext!.ExpenseItems.First(expenseItem => expenseItem!.Id == expenseItemModel.Id);
                        expenseItemToUpdate!.UnitName = expenseItemModel.UnitName;
                        expenseItemToUpdate.ProductName = expenseItemModel.ProductName;
                        expenseItemToUpdate.ExpirationDate = expenseItemModel.ExpirationDate;
                        expenseItemToUpdate.Quantity = expenseItemModel.Quantity;

                        applicationDbContext!.ExpenseItems.Update(expenseItemToUpdate);
                    }
                }

                if (expenseItemModelsToRemove != null)
                {
                    applicationDbContext!.ExpenseItems.RemoveRange(applicationDbContext!.ExpenseItems.Where(r => expenseItemModelsToRemove.Contains(r.Id)));
                }

                applicationDbContext!.SaveChanges();
            }
            else
            {
                expenseBindingSource.CancelEdit();
            }

            applicationDbContext!.Entry((Expense)expenseBindingSource.Current).Reload();
            expenseItemsBindingSource.ResetBindings(false);
        }

        private void toolStripButtonExpenseRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                expenseBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }

        private void dataGridViewRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (applicationDbContext != null)
            {
                var recipe = (Recipe?)dataGridViewRecipes.CurrentRow?.DataBoundItem;

                if (recipe != null)
                {
                    applicationDbContext.Entry(recipe).Collection(e => e.RecipeItems).Load();
                }
            }
        }

        private void dataGridViewExpenses_SelectionChanged(object sender, EventArgs e)
        {
            if (applicationDbContext != null)
            {
                var expense = (Expense?)dataGridViewExpenses.CurrentRow?.DataBoundItem;

                if (expense != null)
                {
                    applicationDbContext.Entry(expense).Collection(e => e.ExpenseItems).Load();
                }
            }
        }

        private void dataGridViewStore_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)dataGridViewStore.Rows[e.RowIndex].Cells[4].Value)
            {
                dataGridViewStore.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridViewStore.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightPink;
            }
        }
    }
}
