using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class ProviderForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly ProviderEditForm? _providerEditForm;

        public ProviderForm(ApplicationDbContext? applicationDbContext, ProviderEditForm? providerEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _providerEditForm = providerEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Providers.Load();

            providerBindingSource.DataSource = _applicationDbContext!.Providers.Local.ToBindingList();

            dataGridViewProviders.ReadOnly = true;
            dataGridViewProviders.AllowUserToAddRows = false;
            dataGridViewProviders.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewProviders.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            _providerEditForm!.provider = new Provider();

            if (_providerEditForm.ShowDialog(this) == DialogResult.OK)
            {
                providerBindingSource.Add(_providerEditForm.provider);
                _applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            _providerEditForm!.provider = (Provider)providerBindingSource.Current;
            if (_providerEditForm.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.SaveChanges();
            }
            else
            {
                providerBindingSource.CancelEdit();
                _applicationDbContext!.Entry((Provider)providerBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                providerBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
            }
        }
    }
}
