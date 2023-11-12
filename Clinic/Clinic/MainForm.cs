using Clinic.Data;
using Clinic.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic
{
    public partial class MainForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private readonly StoreForm storeForm = new StoreForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false,
        };

        private readonly CategoryForm categoryForm = new CategoryForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false,
        };

        private readonly ProductForm productForm = new ProductForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false,
        };

        private readonly UnitForm unitForm = new UnitForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false
        };

        private readonly ProviderForm providerForm = new ProviderForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false
        };

        private readonly EmployeeForm employeeForm = new EmployeeForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false
        };

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext.Database.Migrate();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;
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
            storeForm.MdiParent = this;
            storeForm.Show();
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

            categoryForm.MdiParent = this;
            categoryForm.Show();
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
            productForm.MdiParent = this;
            productForm.Show();
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

            unitForm.MdiParent = this;
            unitForm.Show();
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

            providerForm.MdiParent = this;
            providerForm.Show();
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

            employeeForm.MdiParent = this;
            employeeForm.Show();
        }
    }
}