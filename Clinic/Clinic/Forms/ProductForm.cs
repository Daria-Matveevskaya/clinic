using Clinic.Data;
using Clinic.Data.Entities;
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
    public partial class ProductForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        public ProductForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.applicationDbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.applicationDbContext.Database.EnsureCreated();
            this.applicationDbContext.Categories.Load();

            this.categoryBindingSource.DataSource = applicationDbContext.Categories.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.applicationDbContext?.Dispose();
            this.applicationDbContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (this.applicationDbContext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this.applicationDbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }
    }
}
