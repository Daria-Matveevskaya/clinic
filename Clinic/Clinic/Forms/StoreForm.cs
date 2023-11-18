using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class StoreForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

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
            recipeItemBindingSource.DataSource = applicationDbContext!.RecipeItems.Local.ToBindingList();
            expenseBindingSource.DataSource = applicationDbContext!.Expenses.Local.ToBindingList();

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
            dataGridViewRecipeItems.Columns[0].Visible = false;

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
            dataGridViewExpenseItems.Columns[0].Visible = false;
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
    }
}
