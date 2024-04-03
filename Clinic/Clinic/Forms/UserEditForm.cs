using Clinic.Data;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Clinic.Common;

namespace Clinic.Forms
{
    public partial class UserEditForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUser? user;
        public bool isNewUser = false;

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
            comboBox1.DataBindings.Clear();

            textBox2.Clear();
            textBox3.Clear();

            comboBox1.DataBindings.Add("SelectedValue", user, "EmployeeId", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataSource = _applicationDbContext!.Employees.Local.ToList();
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedItem = user!.Employee;
            comboBox1.Enabled = isNewUser;

            textBox1.DataBindings.Add("Text", user, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox1.Enabled = isNewUser;

            listView1.Items.Clear();

            foreach (IdentityErrorEnum enumItem in Enum.GetValues(typeof(IdentityErrorEnum)))
            {
                listView1.Items.Add(enumItem.GetDescription());
                listView1.Items[(int)enumItem].ForeColor = Color.Black;
            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (isNewUser && (user!.UserName == null || user!.UserName == string.Empty || (user!.UserName != null && user!.UserName.Replace(" ", "") == string.Empty)))
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

            IdentityResult? result = null;

            if (isNewUser)
            {
                result = await _userManager.CreateAsync(user!, textBox2.Text);
            }
            else
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user!);

                result = await _userManager.ResetPasswordAsync(user!, token, textBox2.Text);
            }

            if (result!.Succeeded)
            {
                var message = isNewUser ? "Пользователь добавлен" : "Пароль обновлен";

                MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.None);
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
