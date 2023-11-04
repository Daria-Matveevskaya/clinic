using Clinic.Data.Entities;
using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class CategoryForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private CategoryEditForm? categoryEditForm;

        public CategoryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();
            applicationDbContext!.Categories.Load();

            categoryBindingSource.DataSource = applicationDbContext!.Categories.Local.ToBindingList();

            dataGridViewCategories.ReadOnly = true;
            dataGridViewCategories.AllowUserToAddRows = false;
            dataGridViewCategories.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewCategories.DefaultCellStyle.SelectionForeColor = Color.Black;

            categoryEditForm = new CategoryEditForm
            {
                StartPosition = FormStartPosition.CenterParent,
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;

            categoryEditForm!.Dispose();
            categoryEditForm = null;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            categoryEditForm!.category = new Category();

            if (categoryEditForm.ShowDialog(this) == DialogResult.OK)
            {
                categoryBindingSource.Add(categoryEditForm.category);
                applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            categoryEditForm!.category = (Category)categoryBindingSource.Current;

            if (categoryEditForm.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.SaveChanges();
            }
            else
            {
                categoryBindingSource.CancelEdit();
                applicationDbContext!.Entry((Category)categoryBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                categoryBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }
    }
}
