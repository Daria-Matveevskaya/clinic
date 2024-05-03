using Clinic.Common;
using Clinic.Forms;
using Clinic.Identity;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace Clinic
{
    public partial class MainForm : Form
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly UnitForm _unitForm;
        private readonly AdministratorForm _userForm;
        private readonly StoreForm _storeForm;
        private readonly ProductForm _productForm;
        private readonly CategoryForm _categoryForm;
        private readonly ProviderForm _providerForm;
        private readonly EmployeeForm _employeeForm;

        public ApplicationUser? currentUser;


        public MainForm(
            UserManager<ApplicationUser> userManager,
            UnitForm unitForm,
            AdministratorForm userForm,
            StoreForm storeForm,
            ProductForm productForm,
            CategoryForm categoryForm,
            ProviderForm providerForm,
            EmployeeForm employeeForm)
        {
            _userManager = userManager;
            _unitForm = unitForm;
            _userForm = userForm;
            _storeForm = storeForm;
            _productForm = productForm;
            _categoryForm = categoryForm;
            _providerForm = providerForm;
            _employeeForm = employeeForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            toolStripStatusLabel1.Text = currentUser?.EmployeeFullName ?? string.Empty;

            var userRoles = _userManager.GetRolesAsync(currentUser!).Result;

            toolStripMenuItem10.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString());
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(StoreForm))
                {
                    form.Activate();
                    return;
                }
            }
            _storeForm.currentUser = currentUser;

            _storeForm.WindowState = FormWindowState.Maximized;
            _storeForm.ControlBox = false;
            _storeForm.MdiParent = this;
            _storeForm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CategoryForm))
                {
                    form.Activate();
                    return;
                }
            }

            _categoryForm.WindowState = FormWindowState.Maximized;
            _categoryForm.ControlBox = false;
            _categoryForm.MdiParent = this;
            _categoryForm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductForm))
                {
                    form.Activate();
                    return;
                }
            }

            _productForm.WindowState = FormWindowState.Maximized;
            _productForm.ControlBox = false;
            _productForm.MdiParent = this;
            _productForm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(UnitForm))
                {
                    form.Activate();
                    return;
                }
            }

            _unitForm.WindowState = FormWindowState.Maximized;
            _unitForm.ControlBox = false;
            _unitForm.MdiParent = this;
            _unitForm.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProviderForm))
                {
                    form.Activate();
                    return;
                }
            }

            _providerForm.WindowState = FormWindowState.Maximized;
            _providerForm.ControlBox = false;
            _providerForm.MdiParent = this;
            _providerForm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EmployeeForm))
                {
                    form.Activate();
                    return;
                }
            }

            _employeeForm.WindowState = FormWindowState.Maximized;
            _employeeForm.ControlBox = false;
            _employeeForm.MdiParent = this;
            _employeeForm.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AdministratorForm))
                {
                    form.Activate();
                    return;
                }
            }

            _userForm.WindowState = FormWindowState.Maximized;
            _userForm.ControlBox = false;
            _userForm.MdiParent = this;
            _userForm.Show();
        }
    }
}