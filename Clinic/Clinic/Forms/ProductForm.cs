using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class ProductForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private ProductEditForm? productEditForm;

        private List<Category>? categories;

        public ProductForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Products.Load();

            productBindingSource.DataSource = applicationDbContext!.Products.Local.ToBindingList();
            categories = applicationDbContext!.Categories.ToList();

            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            productEditForm = new ProductEditForm()
            {
                StartPosition = FormStartPosition.CenterParent,
                categories = this.categories,
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;

            productEditForm!.Dispose();
            productEditForm = null;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            productEditForm!.product = new Product()
            {
                Category = categories!.First(),
                CategoryName = categories!.First().Name
            };

            if (productEditForm.ShowDialog(this) == DialogResult.OK)
            {
                productBindingSource.Add(productEditForm.product);
                applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            productEditForm!.product = (Product)productBindingSource.Current;
            if (productEditForm.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.SaveChanges();
            }
            else
            {
                productBindingSource.CancelEdit();
                applicationDbContext!.Entry((Product)productBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                productBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }
    }
}
