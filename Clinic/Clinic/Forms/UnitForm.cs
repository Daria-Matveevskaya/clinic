using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class UnitForm : Form
    {
        private readonly ApplicationDbContext? _applicationDbContext;
        private readonly UnitEditForm? _unitEditForm;

        public UnitForm(ApplicationDbContext? applicationDbContext, UnitEditForm? unitEditForm)
        {
            _applicationDbContext = applicationDbContext;
            _unitEditForm = unitEditForm;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _applicationDbContext!.Units.Load();

            unitBindingSource.DataSource = _applicationDbContext!.Units.Local.ToBindingList();

            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.AllowUserToAddRows = false;
            dataGridViewUnits.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewUnits.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            _unitEditForm!.unit = new Unit();

            if (_unitEditForm.ShowDialog(this) == DialogResult.OK)
            {
                unitBindingSource.Add(_unitEditForm.unit);
                _applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            _unitEditForm!.unit = (Unit)unitBindingSource.Current;

            if (_unitEditForm.ShowDialog(this) == DialogResult.OK)
            {
                _applicationDbContext!.SaveChanges();
            }
            else
            {
                unitBindingSource.CancelEdit();
                _applicationDbContext!.Entry((Unit)unitBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                unitBindingSource.RemoveCurrent();
                _applicationDbContext!.SaveChanges();
            }
        }
    }
}
