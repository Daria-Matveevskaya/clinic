﻿using Clinic.Data.Entities;
using Clinic.Models;
using System.Data;

namespace Clinic.Forms
{
    public partial class ExpenseEditForm : Form
    {
        public Expense? expense;
        public List<Unit>? units;
        public List<StoreModel>? storeItems;
        public List<Employee>? employees;
        public List<ExpenseItemModel>? expenseItemModels;

        public ExpenseEditForm()
        {
            StartPosition = FormStartPosition.CenterParent;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            unitBindingSource.DataSource = units;

            dateTimePicker1.DataBindings.Clear();
            comboBox1.DataBindings.Clear();

            dateTimePicker1.DataBindings.Add("Text", expense, "ExpDate", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("SelectedValue", expense, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBox1.DataSource = employees;
            comboBox1.DisplayMember = "ShortName";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedItem = expense!.Employee;

            expenseItemModels = storeItems!.Select(p => new ExpenseItemModel
            {
                ProductName = p.ProductName,
                UnitName = p.UnitName,
                ExpirationDate = p.ExpirationDate,
                Balance = p.Balance,
                Quantity = expense.ExpenseItems!.FirstOrDefault(e => e.ProductName == p.ProductName && e.ExpirationDate == p.ExpirationDate && e.UnitName == p.UnitName)?.Quantity ?? 0,
                IsChecked = expense.ExpenseItems!.FirstOrDefault(e => e.ProductName == p.ProductName && e.ExpirationDate == p.ExpirationDate && e.UnitName == p.UnitName)?.Quantity != null,
            }).OrderBy(r => r.ProductName).ThenBy(r => r.ExpirationDate).ToList();

            expenseItemModelBindingSource.DataSource = expenseItemModels;

            dataGridViewExpenseItems.AllowUserToAddRows = false;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewExpenseItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewExpenseItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!expenseItemModels!.Where(r => r.IsChecked)!.Any())
            {
                MessageBox.Show("Не выбрано ни одного товара!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (expenseItemModels!.Where(r => r.IsChecked && r.Quantity <= 0)!.Any())
            {
                MessageBox.Show("Не введено количество!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (expenseItemModels!.Where(r => r.IsChecked && r.Quantity > r.Balance)!.Any())
            {
                MessageBox.Show("Количество превышает остаток!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dataGridViewExpenseItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if ((bool)dataGridViewExpenseItems.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue)
                {
                    dataGridViewExpenseItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
                else
                {
                    dataGridViewExpenseItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dataGridViewExpenseItems_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if ((bool)dataGridViewExpenseItems.Rows[e.RowIndex].Cells[0].Value)
            {
                dataGridViewExpenseItems.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
    }
}
