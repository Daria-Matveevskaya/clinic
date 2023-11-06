using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class EmployeeForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private EmployeeEditForm? employeeEditForm;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Employees.Load();

            employeeBindingSource.DataSource = applicationDbContext!.Employees.Local.ToBindingList();

            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewEmployees.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            employeeEditForm = new EmployeeEditForm()
            {
                StartPosition = FormStartPosition.CenterParent,
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;

            employeeEditForm!.Dispose();
            employeeEditForm = null;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            employeeEditForm!.employee = new Employee()
            {
                BirthDate = DateTime.Today,
            };

            if (employeeEditForm.ShowDialog(this) == DialogResult.OK)
            {
                employeeBindingSource.Add(employeeEditForm.employee);
                applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            employeeEditForm!.employee = (Employee)employeeBindingSource.Current;
            if (employeeEditForm.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.SaveChanges();
            }
            else
            {
                employeeBindingSource.CancelEdit();
                applicationDbContext!.Entry((Employee)employeeBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                employeeBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }
    }
}
