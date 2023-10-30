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

            this.applicationDbContext = new ApplicationDbContext();

            this.dataGridViewDirectories.AutoGenerateColumns = true;
            this.dataGridViewDirectories.Columns.Clear();

            DataLoad();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.applicationDbContext?.Dispose();
            this.applicationDbContext = null;
        }

        private void DataLoad()
        {
            switch (selectedCategoryType)
            {
                case DirectoryTypeEnum.Category:
                    this.applicationDbContext?.Categories.Load();
                    this.categoryBindingSource.DataSource = this.applicationDbContext?.Categories.Local.ToBindingList();
                    this.dataGridViewDirectories.DataSource = this.categoryBindingSource;
                    this.dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    break;
                case DirectoryTypeEnum.Product:
                    this.applicationDbContext?.Products.Load();
                    this.productBindingSource.DataSource = this.applicationDbContext?.Products.Local.ToBindingList();
                    this.dataGridViewDirectories.DataSource = this.productBindingSource;
                    this.dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    this.dataGridViewDirectories.Columns["Description"].HeaderText = "Описание";
                    this.dataGridViewDirectories.Columns["CreateDate"].HeaderText = "Дата создания";
                    this.dataGridViewDirectories.Columns["CategoryName"].HeaderText = "Категория";
                    this.dataGridViewDirectories.Columns["CategoryName"].ReadOnly = true;
                    this.dataGridViewDirectories.Columns["Category"].Visible = false;
                    break;
                case DirectoryTypeEnum.Unit:
                    this.applicationDbContext?.Units.Load();
                    this.unitBindingSource.DataSource = this.applicationDbContext?.Units.Local.ToBindingList();
                    this.dataGridViewDirectories.DataSource = this.unitBindingSource;
                    this.dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    this.dataGridViewDirectories.Columns["Abbreviation"].HeaderText = "Обозначение";
                    break;
                case DirectoryTypeEnum.Provider:
                    this.applicationDbContext?.Providers.Load();
                    this.providerBindingSource.DataSource = applicationDbContext?.Providers.Local.ToBindingList();
                    this.dataGridViewDirectories.DataSource = this.providerBindingSource;
                    this.dataGridViewDirectories.Columns["Id"].Visible = false;
                    this.dataGridViewDirectories.Columns["Name"].HeaderText = "Наименование";
                    this.dataGridViewDirectories.Columns["Address"].HeaderText = "Адрес";
                    this.dataGridViewDirectories.Columns["Email"].HeaderText = "Электронный адрес";
                    this.dataGridViewDirectories.Columns["Phone"].HeaderText = "Номер телефона";
                    break;
                case DirectoryTypeEnum.Employee:
                    this.applicationDbContext?.Employees.Load();
                    this.employeeBindingSource.DataSource = applicationDbContext?.Employees.Local.ToBindingList();
                    this.dataGridViewDirectories.DataSource = this.employeeBindingSource;
                    this.dataGridViewDirectories.Columns["Id"].Visible = false;
                    this.dataGridViewDirectories.Columns["Surname"].HeaderText = "Фамилия";
                    this.dataGridViewDirectories.Columns["FirstName"].HeaderText = "Имя";
                    this.dataGridViewDirectories.Columns["PatronymicName"].HeaderText = "Отчество";
                    this.dataGridViewDirectories.Columns["GenderAsString"].HeaderText = "Пол";
                    this.dataGridViewDirectories.Columns["Gender"].Visible = false;
                    this.dataGridViewDirectories.Columns["BirthDate"].HeaderText = "Дата рождения";
                    break;
                default:
                    break;
            }
        }
    }
}
