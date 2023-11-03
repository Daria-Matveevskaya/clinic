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

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext?.Categories.Load();

            categoryBindingSource.DataSource = applicationDbContext?.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext?.Dispose();
            applicationDbContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (applicationDbContext != null)
            {
                var category = (Category?)dataGridViewCategories.CurrentRow?.DataBoundItem;

                if (category != null)
                {
                    applicationDbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }
    }
}
