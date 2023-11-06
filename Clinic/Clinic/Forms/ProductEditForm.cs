using Clinic.Data.Entities;

namespace Clinic.Forms
{
    public partial class ProductEditForm : Form
    {
        public Product? product;

        public List<Category>? categories;
        public ProductEditForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            comboBox1.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", product, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", product, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("Text", product, "CategoryName", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedItem = product!.Category;

            textBox1.Enabled = product!.Name == string.Empty;
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
