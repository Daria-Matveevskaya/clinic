using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly EmployeeEditForm? _employeeEditForm;

        public EmployeeForm(ApplicationDbContext? applicationDbContext, EmployeeEditForm? employeeEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _employeeEditForm = employeeEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Employees.Load();

            employeeBindingSource.DataSource = _applicationDbContext!.Employees.Local.ToBindingList();

            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewEmployees.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            _employeeEditForm!.employee = new Employee()
            {
                BirthDate = DateTime.Today,
            };

            if (_employeeEditForm.ShowDialog(this) == DialogResult.OK)
            {
                employeeBindingSource.Add(_employeeEditForm.employee);
                _applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            _employeeEditForm!.employee = (Employee)employeeBindingSource.Current;

            if (_employeeEditForm.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.SaveChanges();
            }
            else
            {
                employeeBindingSource.CancelEdit();
                _applicationDbContext!.Entry((Employee)employeeBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                employeeBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
            }
        }
    }
}
