using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Forms
{
    public partial class LoginForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Users.Load();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = applicationDbContext!.Users!.FirstOrDefault(u => u.Login == textBox1.Text && u.Password == textBox2.Text);

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
