using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class ProductForm : Form
    {
        public ApplicationDbContext? applicationDbContext;

        public ProductForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.applicationDbContext = new ApplicationDbContext();

            this.applicationDbContext?.Categories.Load();

            this.categoryBindingSource.DataSource = applicationDbContext?.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.applicationDbContext?.Dispose();
            this.applicationDbContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (applicationDbContext != null)
            {
                var category = (Category?)this.dataGridViewCategories.CurrentRow?.DataBoundItem;

                if (category != null)
                {
                    applicationDbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }
    }
}
