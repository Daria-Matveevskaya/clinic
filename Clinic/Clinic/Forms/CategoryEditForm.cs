using Clinic.Data.Entities;
using Clinic.Models;

namespace Clinic.Forms
{
    public partial class CategoryEditForm : Form
    {
        public Category? category;
        public CategoryEditForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBox1.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", category, "Name", true, DataSourceUpdateMode.OnPropertyChanged);

            textBox1.Enabled = category!.Name == null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (category!.Name == null || category!.Name == string.Empty || (category!.Name != null && category!.Name.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Не указано наименование!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
