using Clinic.Data.Entities;
using Clinic.Data;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly CategoryEditForm? _categoryEditForm;

        public CategoryForm(ApplicationDbContext? applicationDbContext, CategoryEditForm? categoryEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _categoryEditForm = categoryEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Categories.Load();

            categoryBindingSource.DataSource = _applicationDbContext!.Categories.Local.ToBindingList();

            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewCategories.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            _categoryEditForm!.category = new Category();

            if (_categoryEditForm.ShowDialog(this) == DialogResult.OK)
            {
                categoryBindingSource.Add(_categoryEditForm.category);
                _applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            _categoryEditForm!.category = (Category)categoryBindingSource.Current;

            if (_categoryEditForm.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.SaveChanges();
            }
            else
            {
                categoryBindingSource.CancelEdit();
                _applicationDbContext!.Entry((Category)categoryBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                categoryBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
            }
        }
    }
}
