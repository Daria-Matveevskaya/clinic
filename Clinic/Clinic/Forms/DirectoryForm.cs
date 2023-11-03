using Clinic.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Clinic.Forms
{
    public partial class DirectoryForm : Form
    {
        public ApplicationDbContext? applicationDbContext;
        public DirectoryTypeEnum selectedCategoryType;

        public enum DirectoryTypeEnum
        {
            Category,
            Product,
            Unit,
            Provider,
            Employee,
        }

        public DirectoryForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationDbContext = new ApplicationDbContext();

            dataGridViewDirectories.AutoGenerateColumns = true;
            dataGridViewDirectories.Columns.Clear();

            DataLoad();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            applicationDbContext?.Dispose();
            applicationDbContext = null;
        }

        private void DataLoad()
        {
            switch (selectedCategoryType)
            {
                case DirectoryTypeEnum.Category:
                    applicationDbContext?.Categories.Load();
                    categoryBindingSource.DataSource = applicationDbContext?.Categories.Local.ToBindingList();
                    dataGridViewDirectories.DataSource = categoryBindingSource;
                    dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    break;
                case DirectoryTypeEnum.Product:
                    applicationDbContext?.Products.Load();
                    productBindingSource.DataSource = applicationDbContext?.Products.Local.ToBindingList();
                    dataGridViewDirectories.DataSource = productBindingSource;
                    dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    dataGridViewDirectories.Columns["Description"].HeaderText = "Описание";
                    dataGridViewDirectories.Columns["CreateDate"].HeaderText = "Дата создания";
                    dataGridViewDirectories.Columns["CategoryName"].HeaderText = "Категория";
                    dataGridViewDirectories.Columns["CategoryName"].ReadOnly = true;
                    dataGridViewDirectories.Columns["Category"].Visible = false;
                    break;
                case DirectoryTypeEnum.Unit:
                    applicationDbContext?.Units.Load();
                    unitBindingSource.DataSource = applicationDbContext?.Units.Local.ToBindingList();
                    dataGridViewDirectories.DataSource = unitBindingSource;
                    dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    dataGridViewDirectories.Columns["Abbreviation"].HeaderText = "Обозначение";
                    break;
                case DirectoryTypeEnum.Provider:
                    applicationDbContext?.Providers.Load();
                    providerBindingSource.DataSource = applicationDbContext?.Providers.Local.ToBindingList();
                    dataGridViewDirectories.DataSource = providerBindingSource;
                    dataGridViewDirectories.Columns["Id"].Visible = false;
                    dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    dataGridViewDirectories.Columns["Address"].HeaderText = "Адрес";
                    dataGridViewDirectories.Columns["Email"].HeaderText = "Электронный адрес";
                    dataGridViewDirectories.Columns["Phone"].HeaderText = "Номер телефона";
                    break;
                case DirectoryTypeEnum.Employee:
                    applicationDbContext?.Employees.Load();
                    employeeBindingSource.DataSource = applicationDbContext?.Employees.Local.ToBindingList();
                    dataGridViewDirectories.DataSource = employeeBindingSource;
                    dataGridViewDirectories.Columns["Id"].Visible = false;
                    dataGridViewDirectories.Columns["Surname"].HeaderText = "Фамилия";
                    dataGridViewDirectories.Columns["FirstName"].HeaderText = "Имя";
                    dataGridViewDirectories.Columns["PatronymicName"].HeaderText = "Отчество";
                    dataGridViewDirectories.Columns["GenderAsString"].HeaderText = "Пол";
                    dataGridViewDirectories.Columns["Gender"].Visible = false;
                    dataGridViewDirectories.Columns["BirthDate"].HeaderText = "Дата рождения";
                    break;
                default:
                    break;
            }
        }
    }
}
