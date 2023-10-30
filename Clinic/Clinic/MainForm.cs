using Clinic.Data;
using Clinic.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using static Clinic.Forms.DirectoryForm;

namespace Clinic
{
    public partial class MainForm : Form
    {
        public ApplicationDbContext? applicationDbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.applicationDbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.applicationDbContext?.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.applicationDbContext?.Dispose();
            this.applicationDbContext = null;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductForm newMDIChild = new ProductForm();

            newMDIChild.MdiParent = this;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.ControlBox = false;

            newMDIChild.Show();
        }

        private void toolStripMenuItem3_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DirectoryForm newMDIChild = new DirectoryForm();

            newMDIChild.MdiParent = this;
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.ControlBox = false;

            newMDIChild.selectedCategoryType = (DirectoryTypeEnum)((ToolStripMenuItem)sender).DropDownItems.IndexOf(e.ClickedItem);

            newMDIChild.Show();
        }
    }
}