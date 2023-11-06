using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class ProviderForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private ProviderEditForm? providerEditForm;

        public ProviderForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Providers.Load();

            providerBindingSource.DataSource = applicationDbContext!.Providers.Local.ToBindingList();

            dataGridViewProviders.ReadOnly = true;
            dataGridViewProviders.AllowUserToAddRows = false;
            dataGridViewProviders.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewProviders.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            providerEditForm = new ProviderEditForm
            {
                StartPosition = FormStartPosition.CenterParent,
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;

            providerEditForm!.Dispose();
            providerEditForm = null;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            providerEditForm!.provider = new Provider();

            if (providerEditForm.ShowDialog(this) == DialogResult.OK)
            {
                providerBindingSource.Add(providerEditForm.provider);
                applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            providerEditForm!.provider = (Provider)providerBindingSource.Current;
            if (providerEditForm.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.SaveChanges();
            }
            else
            {
                providerBindingSource.CancelEdit();
                applicationDbContext!.Entry((Provider)providerBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                providerBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }
    }
}
