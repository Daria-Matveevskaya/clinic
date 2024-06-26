﻿using Clinic.Data.Entities;

namespace Clinic.Forms
{
    public partial class UnitEditForm : Form
    {
        public Unit? unit;

        public UnitEditForm()
        {
            StartPosition = FormStartPosition.CenterParent;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", unit, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", unit, "Abbreviation", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox1.Enabled = unit!.Name == null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (unit!.Name == null || unit!.Name == string.Empty || (unit!.Name != null && unit!.Name.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Не указано наименование!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unit!.Abbreviation == null || unit!.Abbreviation == string.Empty || (unit!.Abbreviation != null && unit!.Abbreviation.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Не указано обозначение!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
