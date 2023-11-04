using Clinic.Data;
using Clinic.Forms;
using System.ComponentModel;

namespace Clinic
{
    public partial class MainForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private readonly ProductForm productForm = new ProductForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false,
        };

        private readonly EmployeeForm employeeForm = new EmployeeForm()
        {
            WindowState = FormWindowState.Maximized,
            ControlBox = false
        };

        private readonly ProviderForm providerForm = new ProviderForm()
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

            //applicationDbContext!.Database.EnsureDeleted();
            applicationDbContext!.Database.EnsureCreated();
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
                if (form.GetType() == typeof(ProductForm))
                {
                    form.Activate();
                    return;
                }
            }
            productForm.MdiParent = this;
            productForm.Show();
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