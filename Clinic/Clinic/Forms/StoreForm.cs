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

        private List<Store> storeItems = new();

        public StoreForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Recipes.Load();
            applicationDbContext!.RecipeItems.Load();
            applicationDbContext!.Expenses.Load();

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
            dataGridViewStore.Columns[3].HeaderText = "Единицы измерения";
            dataGridViewStore.Columns[1].HeaderText = "Срок годности";
            dataGridViewStore.Columns[2].HeaderText = "Количество";
            
            dataGridViewStore.Columns[4].Visible = false;

            dataGridViewStore.ReadOnly = true;
            dataGridViewStore.AllowUserToAddRows = false;
            dataGridViewStore.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewStore.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewStore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewRecipes.ReadOnly = true;
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
            dataGridViewExpenses.AllowUserToAddRows = false;
            dataGridViewExpenses.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewExpenses.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewExpenseItems.ReadOnly = true;
            dataGridViewExpenseItems.AllowUserToAddRows = false;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewExpenseItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;
        }

        private void dataGridViewRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (applicationDbContext != null)
            {
                var recipe = (Recipe)dataGridViewRecipes.CurrentRow.DataBoundItem;

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
                var expense = (Expense)dataGridViewExpenses.CurrentRow.DataBoundItem;

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
