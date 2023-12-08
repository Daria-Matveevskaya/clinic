using Clinic.Classes;
using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class StoreForm : Form
    {
        private ApplicationDbContext? applicationDbContext;
        private RecipeEditForm? recipeEditForm;
        private ExpenseEditForm? expenseEditForm;
        private List<Store> storeItems = new();

        public StoreForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Units.Load();
            applicationDbContext!.Products.Load();
            applicationDbContext!.Providers.Load();
            applicationDbContext!.RecipeItems.Load();

            applicationDbContext!.Recipes.Include(r => r.Provider).Load();
            applicationDbContext!.Expenses.Include(r => r.Employee).Load();

            recipeBindingSource.DataSource = applicationDbContext!.Recipes.Local.ToBindingList();
            expenseBindingSource.DataSource = applicationDbContext!.Expenses.Local.ToBindingList();

            storeItems = applicationDbContext!.RecipeItems.Select(item => new Store
            {
                ProductName = item.ProductName,
                ExpirationDate = item.ExpirationDate,
                UnitName = item.UnitName,
                Quantity = item.Quantity,
            }).Union(applicationDbContext!.RecipeItems.Select(item => new Store
            {
                ProductName = item.ProductName,
                ExpirationDate = item.ExpirationDate,
                UnitName = item.UnitName,
                Quantity = -item.Quantity,
            })).GroupBy(item => new { item.ProductName, item.ExpirationDate, item.UnitName })
               .Select(item => new Store
               {
                   ProductName = item.Key.ProductName,
                   ExpirationDate = item.Key.ExpirationDate,
                   UnitName = item.Key.UnitName,
                   Quantity = item.Sum(item => item.Quantity),
               }).ToList();

            var recipeItemGroups = applicationDbContext!.RecipeItems.GroupBy(item => new { item.ProductName, item.ExpirationDate, item.UnitName });
            var expenseItemGroups = applicationDbContext!.ExpenseItems.GroupBy(item => new { item.ProductName, item.ExpirationDate, item.UnitName });

            storeItems = applicationDbContext!.RecipeItems
                .GroupBy(rec => new { rec.ProductName, rec.ExpirationDate, rec.UnitName })
                .Select(rec => new Store
                {
                    ProductName = rec.Key.ProductName,
                    ExpirationDate = rec.Key.ExpirationDate,
                    UnitName = rec.Key.UnitName,
                    Quantity = rec.Sum(item => item.Quantity) - applicationDbContext!.ExpenseItems.Where(exp => exp.ProductName == rec.Key.ProductName).Sum(exp => exp.Quantity),
                }).ToList();

            dataGridViewStore.DataSource = storeItems;
            dataGridViewStore.Columns[0].HeaderText = "Наименование";
            dataGridViewStore.Columns[1].HeaderText = "Единицы измерения";
            dataGridViewStore.Columns[2].HeaderText = "Срок годности";
            dataGridViewStore.Columns[3].HeaderText = "Количество";
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
