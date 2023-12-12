using Clinic.Data.Entities;

namespace Clinic.Forms
{
    public partial class EmployeeEditForm : Form
    {
        public Employee? employee;

        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            comboBox1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Clear();

            textBox1.DataBindings.Add("Text", employee, "Surname", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", employee, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", employee, "PatronymicName", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("Text", employee, "GenderAsString", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimePicker1.DataBindings.Add("Value", employee, "BirthDate", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (employee!.Surname == null || employee!.Surname == string.Empty || (employee!.Surname != null && employee!.Surname.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Не указана фамилия!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (employee!.FirstName == null || employee!.FirstName == string.Empty || (employee!.FirstName != null && employee!.FirstName.Replace(" ", "") == string.Empty))
            {
                MessageBox.Show("Не указано имя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
