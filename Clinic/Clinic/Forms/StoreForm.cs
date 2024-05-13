using Clinic.Data;
using Clinic.Data.Entities;
using Clinic.Models;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Clinic.Common;
using Clinic.Identity;

namespace Clinic.Forms
{
    public partial class StoreForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly RecipeEditForm? _recipeEditForm;
        private readonly ExpenseEditForm? _expenseEditForm;

        private readonly BindingSource _storeBindingSource = new();

        public ApplicationUser? currentUser;

        public StoreForm(ApplicationDbContext? applicationDbContext, RecipeEditForm? recipeEditForm, ExpenseEditForm? expenseEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _recipeEditForm = recipeEditForm;
            _expenseEditForm = expenseEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Units.Load();
            _applicationDbContext!.Products.Load();
            _applicationDbContext!.Providers.Load();
            _applicationDbContext!.Employees.Load();
            _applicationDbContext!.RecipeItems.Load();
            _applicationDbContext!.ExpenseItems.Load();

            _applicationDbContext!.Recipes.Include(r => r.Provider).Load();
            _applicationDbContext!.Expenses.Include(r => r.Employee).Load();

            recipeBindingSource.DataSource = _applicationDbContext!.Recipes.Local.ToBindingList();
            expenseBindingSource.DataSource = _applicationDbContext!.Expenses.Local.ToBindingList();

            RecalcStoreItems();
            dataGridViewStore.DataSource = _storeBindingSource;

            dataGridViewStore.Columns[0].HeaderText = "Наименование";
            dataGridViewStore.Columns[1].HeaderText = "Единицы измерения";
            dataGridViewStore.Columns[2].HeaderText = "Срок годности";
            dataGridViewStore.Columns[3].HeaderText = "Остаток";
            dataGridViewStore.Columns[4].Visible = false;

            dataGridViewStore.ReadOnly = true;
            dataGridViewStore.AllowUserToAddRows = false;
            dataGridViewStore.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewStore.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewRecipes.ReadOnly = true;
            dataGridViewRecipes.MultiSelect = false;
            dataGridViewRecipes.AllowUserToAddRows = false;
            dataGridViewRecipes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewRecipes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewRecipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewRecipeItems.ReadOnly = true;
            dataGridViewRecipeItems.AllowUserToAddRows = false;
            dataGridViewRecipeItems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewRecipeItems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewRecipeItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecipeItems.Columns[0].Visible = false;

            dataGridViewExpenses.ReadOnly = true;
            dataGridViewExpenses.MultiSelect = false;
            dataGridViewExpenses.AllowUserToAddRows = false;
            dataGridViewExpenses.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewExpenses.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewExpenseItems.ReadOnly = true;
            dataGridViewExpenseItems.AllowUserToAddRows = false;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewExpenseItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpenseItems.Columns[0].Visible = false;

            _recipeEditForm!.units = _applicationDbContext!.Units.Local.ToList();
            _recipeEditForm!.products = _applicationDbContext!.Products.Local.ToList();
            _recipeEditForm!.providers = _applicationDbContext!.Providers.Local.ToList();

            _expenseEditForm!.units = _applicationDbContext!.Units.Local.ToList();
            _expenseEditForm!.employees = _applicationDbContext!.Employees.Local.ToList();
        }

        private void RecalcStoreItems()
        {
            _storeBindingSource.DataSource = _applicationDbContext!.RecipeItems
                .GroupBy(rec => new { rec.ProductName, rec.ExpirationDate, rec.UnitName })
                .Select(rec => new StoreModel
                {
                    ProductName = rec.Key.ProductName,
                    ExpirationDate = rec.Key.ExpirationDate,
                    UnitName = rec.Key.UnitName,
                    Balance = rec.Sum(item => item.Quantity) -
                    _applicationDbContext!.ExpenseItems
                    .Where(exp => exp.ProductName == rec.Key.ProductName && exp.ExpirationDate == rec.Key.ExpirationDate && exp.UnitName == rec.Key.UnitName)
                    .Sum(exp => exp.Quantity),
                }).OrderBy(r => r.ProductName).ThenBy(r => r.ExpirationDate).ToList();
        }

        private void toolStripButtonRecipeAdd_Click(object sender, EventArgs e)
        {
            _recipeEditForm!.recipe = new Recipe()
            {
                Date = DateTime.Now,
                Provider = _recipeEditForm!.providers!.First(),
            };

            if (_recipeEditForm!.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.Recipes.Add(_recipeEditForm.recipe);

                var recipeItemModelsToAdd = _recipeEditForm!.recipeItemModels!.Where(r => r.IsChecked);

                _applicationDbContext!.RecipeItems.AddRange(recipeItemModelsToAdd.Select(r => new RecipeItem
                {
                    RecipeId = _recipeEditForm.recipe.Id,
                    Recipe = _recipeEditForm!.recipe,
                    UnitName = r.UnitName,
                    ProductName = r.ProductName,
                    ExpirationDate = r.ExpirationDate,
                    Quantity = r.Quantity,
                }));

                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();

                _applicationDbContext!.Entry((Recipe)recipeBindingSource.Current).Reload();
                recipeItemsBindingSource.ResetBindings(false);
            }
        }

        private void toolStripButtonRecipeEdit_Click(object sender, EventArgs e)
        {
            _recipeEditForm!.recipe = (Recipe)recipeBindingSource.Current;
            if (_recipeEditForm.ShowDialog(this) == DialogResult.OK)
            {
                var recipeId = _recipeEditForm!.recipe.Id;
                var recipeItemModels = _recipeEditForm!.recipeItemModels!.Where(r => r.IsChecked);
                var recipeItemModelsToAdd = recipeItemModels.Where(r => !r.Id.HasValue);
                var recipeItemModelsToUpdate = recipeItemModels.Where(r => r.Id.HasValue);
                var recipeItemModelsToRemove = _recipeEditForm!.recipe.RecipeItems.Where(r => !recipeItemModels.Select(ri => ri.Id).Contains(r.Id)).Select(r => r.Id);

                if (recipeItemModelsToAdd != null)
                {
                    _applicationDbContext!.RecipeItems.AddRange(recipeItemModelsToAdd.Select(r => new RecipeItem
                    {
                        RecipeId = recipeId,
                        Recipe = _recipeEditForm!.recipe,
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
                        var recipeItemToUpdate = _applicationDbContext!.RecipeItems.First(recipeItem => recipeItem!.Id == recipeItemModel.Id);
                        recipeItemToUpdate!.UnitName = recipeItemModel.UnitName;
                        recipeItemToUpdate.ProductName = recipeItemModel.ProductName;
                        recipeItemToUpdate.ExpirationDate = recipeItemModel.ExpirationDate;
                        recipeItemToUpdate.Quantity = recipeItemModel.Quantity;

                        _applicationDbContext!.RecipeItems.Update(recipeItemToUpdate);
                    }
                }

                if (recipeItemModelsToRemove != null)
                {
                    _applicationDbContext!.RecipeItems.RemoveRange(_applicationDbContext!.RecipeItems.Where(r => recipeItemModelsToRemove.Contains(r.Id)));
                }

                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();
            }
            else
            {
                recipeBindingSource.CancelEdit();
            }

            _applicationDbContext!.Entry((Recipe)recipeBindingSource.Current).Reload();
            recipeItemsBindingSource.ResetBindings(false);
        }

        private void toolStripButtonRecipeRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                recipeBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();
            }
        }

        private void toolStripButtonExpenseAdd_Click(object sender, EventArgs e)
        {
            _expenseEditForm!.storeItems = (List<StoreModel>?)_storeBindingSource.DataSource;
            _expenseEditForm!.expense = new Expense()
            {
                Date = DateTime.Now,
                Employee = _expenseEditForm!.employees!.First(),
            };

            if (_expenseEditForm!.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.Expenses.Add(_expenseEditForm.expense);

                var expenseItemModelsToAdd = _expenseEditForm!.expenseItemModels!.Where(r => r.IsChecked);

                _applicationDbContext!.ExpenseItems.AddRange(expenseItemModelsToAdd.Select(r => new ExpenseItem
                {
                    ExpenseId = _expenseEditForm.expense.Id,
                    Expense = _expenseEditForm!.expense,
                    UnitName = r.UnitName,
                    ProductName = r.ProductName,
                    ExpirationDate = r.ExpirationDate,
                    Quantity = r.Quantity,
                }));

                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();

                _applicationDbContext!.Entry((Expense)expenseBindingSource.Current).Reload();
                expenseItemsBindingSource.ResetBindings(false);
            }
        }

        private void toolStripButtonExpenseEdit_Click(object sender, EventArgs e)
        {
            _expenseEditForm!.storeItems = (List<StoreModel>?)_storeBindingSource.DataSource;
            _expenseEditForm!.expense = (Expense)expenseBindingSource.Current;

            if (_expenseEditForm.ShowDialog(this) == DialogResult.OK)
            {
                var expenseId = _expenseEditForm!.expense.Id;
                var expenseItemModels = _expenseEditForm!.expenseItemModels!.Where(r => r.IsChecked);
                var expenseItemModelsToAdd = expenseItemModels.Where(r => !r.Id.HasValue);
                var expenseItemModelsToUpdate = expenseItemModels.Where(r => r.Id.HasValue);
                var expenseItemModelsToRemove = _expenseEditForm!.expense.ExpenseItems.Where(r => !expenseItemModels.Select(ri => ri.Id).Contains(r.Id)).Select(r => r.Id);

                if (expenseItemModelsToAdd != null)
                {
                    _applicationDbContext!.ExpenseItems.AddRange(expenseItemModelsToAdd.Select(r => new ExpenseItem
                    {
                        ExpenseId = expenseId,
                        Expense = _expenseEditForm!.expense,
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
                        var expenseItemToUpdate = _applicationDbContext!.ExpenseItems.First(expenseItem => expenseItem!.Id == expenseItemModel.Id);
                        expenseItemToUpdate!.UnitName = expenseItemModel.UnitName;
                        expenseItemToUpdate.ProductName = expenseItemModel.ProductName;
                        expenseItemToUpdate.ExpirationDate = expenseItemModel.ExpirationDate;
                        expenseItemToUpdate.Quantity = expenseItemModel.Quantity;

                        _applicationDbContext!.ExpenseItems.Update(expenseItemToUpdate);
                    }
                }

                if (expenseItemModelsToRemove != null)
                {
                    _applicationDbContext!.ExpenseItems.RemoveRange(_applicationDbContext!.ExpenseItems.Where(r => expenseItemModelsToRemove.Contains(r.Id)));
                }

                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();
            }
            else
            {
                expenseBindingSource.CancelEdit();
            }

            _applicationDbContext!.Entry((Expense)expenseBindingSource.Current).Reload();
            expenseItemsBindingSource.ResetBindings(false);
        }

        private void toolStripButtonExpenseRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                expenseBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();
            }
        }

        private void dataGridViewRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (_applicationDbContext != null)
            {
                var recipe = (Recipe?)dataGridViewRecipes.CurrentRow?.DataBoundItem;

                if (recipe != null)
                {
                    _applicationDbContext.Entry(recipe).Collection(e => e.RecipeItems).Load();
                }
            }
        }

        private void dataGridViewExpenses_SelectionChanged(object sender, EventArgs e)
        {
            if (_applicationDbContext != null)
            {
                var expense = (Expense?)dataGridViewExpenses.CurrentRow?.DataBoundItem;

                if (expense != null)
                {
                    _applicationDbContext.Entry(expense).Collection(e => e.ExpenseItems).Load();
                }
            }
        }

        private void dataGridViewStore_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)dataGridViewStore.Rows[e.RowIndex].Cells[4].Value)
            {
                dataGridViewStore.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                dataGridViewStore.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightPink;
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            List<string> captions = new()
            {
                $"Остаток товаров на дату: {DateTime.Now:dd/MM/yyyy}",
            };

            dataGridViewStore.ExportToExcel("Остаток", captions, currentUser?.EmployeeFullName ?? string.Empty);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Recipe recipe = (Recipe)recipeBindingSource.Current;
            List<string> captions = new()
            {
                $"Приход №{recipe.Id}",
                $"Дата: {recipe.Date:dd/MM/yyyy}",
                $"Поставщик: {recipe.ProviderName}",
            };

            dataGridViewRecipeItems.ExportToExcel("Приход", captions, currentUser?.EmployeeFullName ?? string.Empty);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Expense expence = (Expense)expenseBindingSource.Current;
            List<string> captions = new()
            {
                $"Расход №{expence.Id}",
                $"Дата: {expence.Date:dd/MM/yyyy}",
                $"Получатель: {expence.EmployeeFullName}",
            };

            dataGridViewExpenseItems.ExportToExcel("Расход", captions, currentUser?.EmployeeFullName ?? string.Empty);
        }
    }
}
