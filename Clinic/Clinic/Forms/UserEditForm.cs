using Clinic.Data;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Text;
using Clinic.Common;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;

namespace Clinic.Forms
{
    public partial class UserEditForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUser? user;

        public UserEditForm(ApplicationDbContext? applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;

            StartPosition = FormStartPosition.CenterParent;

            InitializeComponent();
        }

        public async Task<IdentityResult?> UserRemove(string? userId)
        {
            IdentityResult? result = null;

            if (userId == null)
            {
                return result;
            }

            ApplicationUser? user = await _userManager!.FindByIdAsync(userId!);

            if (user != null)
            {
                result = await _userManager.DeleteAsync(user);
            }

            return result;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            comboBox1.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", user, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("SelectedValue", user, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBox1.DataSource = _applicationDbContext!.Employees.Local.ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedItem = user!.Employee;

            listView1.Items.Clear();

            foreach (IdentityErrorEnum enumItem in Enum.GetValues(typeof(IdentityErrorEnum)))
            {
                listView1.Items.Add(enumItem.GetDescription());
                listView1.Items[(int)enumItem].ForeColor = Color.Black;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (user!.UserName == null || user!.UserName == string.Empty || (user!.UserName != null && user!.UserName.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Введите логин!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text == null || textBox2.Text == string.Empty || (textBox2.Text != null && textBox2.Text.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Введите пароль!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = await _userManager.CreateAsync(user!, textBox2.Text);

            if (result.Succeeded)
            {
                MessageBox.Show("Пользователь успешно создан", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            var errors = result?.Errors?.Select(r => r.Description);

            if (errors!.Any())
            {
                MessageBox.Show("Проверьте введенные данные!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (errors!.Contains(listView1.Items[i].Text))
                    {
                        listView1.Items[i].ForeColor = Color.Red;
                    }
                    else
                    {
                        listView1.Items[i].ForeColor = Color.Green;
                    }
                }

                var otherErrors = errors!.Except(listView1!.Items.Cast<ListViewItem>().Select(item => item.Text).ToList());

                foreach (var error in otherErrors)
                {
                    MessageBox.Show(error, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            e.Item!.Selected = false;
        }
    }
}
