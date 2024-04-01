using Clinic.Data;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace Clinic.Forms
{
    public partial class UserForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UserEditForm? _userEditForm;

        public UserForm(ApplicationDbContext? applicationDbContext, UserEditForm? userEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _userEditForm = userEditForm;

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

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            _userEditForm!.user = new ApplicationUser
            {
                Employee = _applicationDbContext!.Employees.First(),
            };

            _userEditForm.ShowDialog(this);

            userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            //_userEditForm!.user = (ApplicationUser)userBindingSource.Current;
            //_userEditForm.ShowDialog(this);

            //userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);
        }

        private async void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                await _userEditForm!.UserRemove(((ApplicationUser)userBindingSource.Current).Id);

                userBindingSource.DataSource = _applicationDbContext!.Users.Local.ToBindingList().OrderBy(u => u.EmployeeFullName);
            }
        }
    }
}
