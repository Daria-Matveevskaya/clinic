using Clinic.Forms;

namespace Clinic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductForm newMDIChild = new ProductForm();

            newMDIChild.MdiParent = this;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.ControlBox = false;
            
            newMDIChild.Show();
        }
    }
}