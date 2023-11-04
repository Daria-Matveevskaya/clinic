using Clinic.Data.Entities;

namespace Clinic.Forms
{
    public partial class ProviderEditForm : Form
    {
        public Provider? provider;

        public ProviderEditForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox4.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", provider, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", provider, "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", provider, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox4.DataBindings.Add("Text", provider, "Phone", true, DataSourceUpdateMode.OnPropertyChanged);
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
