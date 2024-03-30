using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly ProductEditForm? _productEditForm;

        private List<Category>? categories;

        public ProductForm(ApplicationDbContext? applicationDbContext, ProductEditForm? productEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _productEditForm = productEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Products.Load();

            productBindingSource.DataSource = _applicationDbContext!.Products.Local.ToBindingList();
            categories = _applicationDbContext!.Categories.ToList();

            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            _productEditForm!.categories = this.categories;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            _productEditForm!.product = new Product()
            {
                Category = categories!.First(),
                CategoryName = categories!.First().Name
            };

            if (_productEditForm.ShowDialog(this) == DialogResult.OK)
            {
                productBindingSource.Add(_productEditForm.product);
                _applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            _productEditForm!.product = (Product)productBindingSource.Current;
            if (_productEditForm.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.SaveChanges();
            }
            else
            {
                productBindingSource.CancelEdit();
                _applicationDbContext!.Entry((Product)productBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                productBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
            }
        }
    }
}
