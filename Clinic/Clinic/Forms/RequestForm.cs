using Clinic.Common;
using Clinic.Data;
using Clinic.Data.Entities;
using Clinic.Identity;
using Clinic.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Clinic.Forms
{
    public partial class RequestForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly RequestEditForm? _requestEditForm;

        private readonly BindingSource _storeBindingSource = new();

        public ApplicationUser? currentUser;

        public RequestForm(ApplicationDbContext? applicationDbContext, RequestEditForm? requestEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _requestEditForm = requestEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Units.Load();
            _applicationDbContext!.Products.Load();
            _applicationDbContext!.ExpenseItems.Load();

            _applicationDbContext!.Expenses.Where(_ => _.EmployeeId == currentUser!.EmployeeId).Include(r => r.Employee).Load();

            expenseBindingSource.DataSource = _applicationDbContext!.Expenses.Local.ToBindingList();

            RecalcStoreItems();

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

            _requestEditForm!.units = _applicationDbContext!.Units.Local.ToList();
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

        private void toolStripButtonExpenseAdd_Click(object sender, EventArgs e)
        {
            _requestEditForm!.storeItems = (List<StoreModel>?)_storeBindingSource.DataSource;
            _requestEditForm!.expense = new Expense()
            {
                Date = DateTime.Now,
                Employee = currentUser!.Employee,
            };

            if (_requestEditForm!.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.Expenses.Add(_requestEditForm.expense);

                var expenseItemModelsToAdd = _requestEditForm!.expenseItemModels!.Where(r => r.IsChecked);

                _applicationDbContext!.ExpenseItems.AddRange(expenseItemModelsToAdd.Select(r => new ExpenseItem
                {
                    ExpenseId = _requestEditForm.expense.Id,
                    Expense = _requestEditForm!.expense,
                    UnitName = r.UnitName,
                    ProductName = r.ProductName,
                    ExpirationDate = r.ExpirationDate,
                    Quantity = r.Quantity,
                }));

                _applicationDbContext!.SaveChanges();
                RecalcStoreItems();

                _applicationDbContext!.Entry((Expense)expenseBindingSource.Current)?.Reload();
                expenseItemsBindingSource.ResetBindings(false);
            }
        }

        private void toolStripButtonExpenseEdit_Click(object sender, EventArgs e)
        {
            _requestEditForm!.storeItems = (List<StoreModel>?)_storeBindingSource.DataSource;
            _requestEditForm!.expense = (Expense)expenseBindingSource.Current;

            if (_requestEditForm.ShowDialog(this) == DialogResult.OK)
            {
                var expenseId = _requestEditForm!.expense.Id;
                var expenseItemModels = _requestEditForm!.expenseItemModels!.Where(r => r.IsChecked);
                var expenseItemModelsToAdd = expenseItemModels.Where(r => !r.Id.HasValue);
                var expenseItemModelsToUpdate = expenseItemModels.Where(r => r.Id.HasValue);
                var expenseItemModelsToRemove = _requestEditForm!.expense.ExpenseItems.Where(r => !expenseItemModels.Select(ri => ri.Id).Contains(r.Id)).Select(r => r.Id);

                if (expenseItemModelsToAdd != null)
                {
                    _applicationDbContext!.ExpenseItems.AddRange(expenseItemModelsToAdd.Select(r => new ExpenseItem
                    {
                        ExpenseId = expenseId,
                        Expense = _requestEditForm!.expense,
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Expense expence = (Expense)expenseBindingSource.Current;
            List<string> captions = new()
            {
                $"Заявка №{expence.Id}",
                $"Дата: {expence.Date:dd/MM/yyyy}",
                $"Получатель: {expence.EmployeeFullName}",
            };

            dataGridViewExpenseItems.ExportToExcel("Заявка", captions, currentUser?.EmployeeFullName ?? string.Empty);
        }

        private void dataGridViewExpenses_SelectionChanged(object sender, EventArgs e)
        {
            if (_applicationDbContext != null)
            {
                var expense = (Expense?)dataGridViewExpenses?.CurrentRow?.DataBoundItem;

                if (expense != null)
                {
                    _applicationDbContext.Entry(expense).Collection(e => e.ExpenseItems).Load();
                }
            }
        }
    }
}
