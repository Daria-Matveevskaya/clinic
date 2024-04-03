using Clinic.Data;
using Clinic.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class AdministratorForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UserEditForm? _userEditForm;
        private readonly RoleEditForm? _roleEditForm;

        public AdministratorForm(
            ApplicationDbContext? applicationDbContext,
            UserEditForm? userEditForm,
            RoleEditForm? roleEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _userEditForm = userEditForm;
            _roleEditForm = roleEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Users.Include(r => r.Employee).Load();

            userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);

            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewUsers.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void toolStripButtonUserAdd_Click(object sender, EventArgs e)
        {
            _userEditForm!.user = new ApplicationUser
            {
                Employee = _applicationDbContext!.Employees.First(),
            };

            _userEditForm.isNewUser = true;

            _userEditForm.ShowDialog(this);

            userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);
        }

        private void toolStripButtonUserEdit_Click(object sender, EventArgs e)
        {
            _userEditForm!.user = (ApplicationUser)userBindingSource.Current;
            _userEditForm.isNewUser = false;

            _userEditForm.ShowDialog(this);

            userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);
        }

        private async void toolStripButtonUserRemoveAsync_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить пользователя?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                await _userEditForm!.UserRemove(((ApplicationUser)userBindingSource.Current).Id);

                userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _roleEditForm!.user = (ApplicationUser)userBindingSource.Current;
            _roleEditForm!.ShowDialog(this);
        }
    }
}
