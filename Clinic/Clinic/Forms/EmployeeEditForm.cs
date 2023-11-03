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
