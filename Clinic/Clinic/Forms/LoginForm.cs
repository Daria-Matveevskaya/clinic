﻿using Clinic.Data;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationUser? user;

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

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            user = await _userManager.FindByNameAsync(textBox1.Text);

            if (user == null || (user != null && await _userManager.CheckPasswordAsync(user, textBox2.Text) == false))
            {
                if (await _userManager.CheckPasswordAsync(user!, textBox2.Text) == false)
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
