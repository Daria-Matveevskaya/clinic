using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        public User? user = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Users.Include(r => r.Employee).Load();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = applicationDbContext!.Users!.FirstOrDefault(u => u.Login == textBox1.Text && u.Password == textBox2.Text);

            if(user == null)
            {
                MessageBox.Show("Неправильный логин или пароль!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
