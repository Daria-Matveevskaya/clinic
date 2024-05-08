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
        private readonly RequestForm _requestForm;

        public ApplicationUser? currentUser;
        public IList<string> userRoles = new List<string>();

        public MainForm(
            UserManager<ApplicationUser> userManager,
            UnitForm unitForm,
            AdministratorForm userForm,
            StoreForm storeForm,
            ProductForm productForm,
            CategoryForm categoryForm,
            ProviderForm providerForm,
            EmployeeForm employeeForm,
            RequestForm requestForm)
        {
            _userManager = userManager;
            _unitForm = unitForm;
            _userForm = userForm;
            _storeForm = storeForm;
            _productForm = productForm;
            _categoryForm = categoryForm;
            _providerForm = providerForm;
            _employeeForm = employeeForm;
            _requestForm = requestForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            toolStripStatusLabel1.Text = currentUser?.EmployeeFullName ?? string.Empty;

            userRoles = _userManager.GetRolesAsync(currentUser!).Result;

            // Настройка доступов
            toolStripMenuItem1.Visible = userRoles.Contains(RoleTypeEnum.Store.ToString());
            toolStripMenuItem2.Visible = userRoles.Contains(RoleTypeEnum.User.ToString());
            toolStripMenuItem3.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString());

            if (userRoles.Contains(RoleTypeEnum.Store.ToString()))
            {
                ShowStoreForm();
            }
            else
            {
                if (userRoles.Contains(RoleTypeEnum.User.ToString()))
                {
                    ShowRequestForm();
                }
                else
                {
                    if (userRoles.Contains(RoleTypeEnum.Administrator.ToString()))
                    {
                        ShowAdministratorForm();
                    }
                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowStoreForm();
        }

        private void ShowStoreForm()
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowRequestForm();
        }

        private void ShowRequestForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RequestForm))
                {
                    form.Activate();
                    return;
                }
            }

            _requestForm.currentUser = currentUser;

            _requestForm.WindowState = FormWindowState.Maximized;
            _requestForm.ControlBox = false;
            _requestForm.MdiParent = this;
            _requestForm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowAdministratorForm();
        }

        private void ShowAdministratorForm()
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

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(EmployeeForm))
                {
                    form.Activate();
                    return;
                }
            }

            _employeeForm.toolStrip1.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString());

            _employeeForm.WindowState = FormWindowState.Maximized;
            _employeeForm.ControlBox = false;
            _employeeForm.MdiParent = this;
            _employeeForm.Show();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProviderForm))
                {
                    form.Activate();
                    return;
                }
            }

            _providerForm.toolStrip1.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString()) || userRoles.Contains(RoleTypeEnum.Store.ToString());

            _providerForm.WindowState = FormWindowState.Maximized;
            _providerForm.ControlBox = false;
            _providerForm.MdiParent = this;
            _providerForm.Show();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CategoryForm))
                {
                    form.Activate();
                    return;
                }
            }

            _categoryForm.toolStrip1.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString()) || userRoles.Contains(RoleTypeEnum.Store.ToString());

            _categoryForm.WindowState = FormWindowState.Maximized;
            _categoryForm.ControlBox = false;
            _categoryForm.MdiParent = this;
            _categoryForm.Show();
        }

        private void toolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductForm))
                {
                    form.Activate();
                    return;
                }
            }

            _productForm.toolStrip1.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString()) || userRoles.Contains(RoleTypeEnum.Store.ToString());

            _productForm.WindowState = FormWindowState.Maximized;
            _productForm.ControlBox = false;
            _productForm.MdiParent = this;
            _productForm.Show();
        }

        private void toolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(UnitForm))
                {
                    form.Activate();
                    return;
                }
            }

            _unitForm.toolStrip1.Visible = userRoles.Contains(RoleTypeEnum.Administrator.ToString()) || userRoles.Contains(RoleTypeEnum.Store.ToString());

            _unitForm.WindowState = FormWindowState.Maximized;
            _unitForm.ControlBox = false;
            _unitForm.MdiParent = this;
            _unitForm.Show();
        }
    }
}