using Clinic.Data;
using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class UnitForm : Form
    {
        private ApplicationDbContext? applicationDbContext;

        private UnitEditForm? unitEditForm;

        public UnitForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            applicationDbContext!.Units.Load();

            unitBindingSource.DataSource = applicationDbContext!.Units.Local.ToBindingList();

            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.AllowUserToAddRows = false;
            dataGridViewUnits.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewUnits.DefaultCellStyle.SelectionForeColor = Color.Black;

            unitEditForm = new UnitEditForm
            {
                StartPosition = FormStartPosition.CenterParent,
            };
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext!.Dispose();
            applicationDbContext = null;

            unitEditForm!.Dispose();
            unitEditForm = null;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            unitEditForm!.unit = new Unit();

            if (unitEditForm.ShowDialog(this) == DialogResult.OK)
            {
                unitBindingSource.Add(unitEditForm.unit);
                applicationDbContext!.SaveChanges();
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            unitEditForm!.unit = (Unit)unitBindingSource.Current;

            if (unitEditForm.ShowDialog(this) == DialogResult.OK)
            {
                applicationDbContext!.SaveChanges();
            }
            else
            {
                unitBindingSource.CancelEdit();
                applicationDbContext!.Entry((Unit)unitBindingSource.Current).Reload();
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить запись?", "Подтвердите действие", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                unitBindingSource.RemoveCurrent();
                applicationDbContext!.SaveChanges();
            }
        }
    }
}
