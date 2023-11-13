using Clinic.Data.Entities;

namespace Clinic.Forms
{
    public partial class UnitEditForm : Form
    {
        public Unit? unit;

        public UnitEditForm()
        {
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
