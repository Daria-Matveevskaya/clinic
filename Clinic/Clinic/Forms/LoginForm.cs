using Clinic.Data;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoginForm(ApplicationDbContext? applicationDbContext, UserManager<ApplicationUser> userManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Users.Include(r => r.Employee).Load();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var user = await _userManager.FindByNameAsync(textBox1.Text);

            if (user != null)
            {
                if (await _userManager.CheckPasswordAsync(user, textBox2.Text) == false)
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
