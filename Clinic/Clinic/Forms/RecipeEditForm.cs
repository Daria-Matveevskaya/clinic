﻿using Clinic.Data;
using Clinic.Data.Entities;
using Clinic.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Clinic.Forms
{
    public partial class RecipeEditForm : Form
    {
        public Recipe? recipe;
        public List<Unit>? units;
        public List<Product>? products;
        public List<Provider>? providers;
        public List<RecipeItemModel>? recipeItemModels;

        public RecipeEditForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            unitBindingSource.DataSource = units;

            dateTimePicker1.DataBindings.Clear();
            comboBox1.DataBindings.Clear();

            dateTimePicker1.DataBindings.Add("Text", recipe, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            comboBox1.DataBindings.Add("Text", recipe, "ProviderName", true, DataSourceUpdateMode.OnPropertyChanged);

            comboBox1.DataSource = providers;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedItem = recipe!.Provider;

            recipeItemModels = recipe.RecipeItems.Select(r => new RecipeItemModel
            {
                IsChecked = true,
                ProductName = r.ProductName,
                UnitName = r.UnitName,
                ExpirationDate = r.ExpirationDate,
                Quantity = r.Quantity,
                Id = r.Id,
            }).ToList();

            recipeItemModels.AddRange(products!.Select(p => p.Name).Except(recipeItemModels.Select(r => r.ProductName)).Select(p => new RecipeItemModel
            {
                ProductName = p
            }));

            orderBindingSource.DataSource = recipeItemModels;

            dataGridViewRecipeItems.AllowUserToAddRows = false;
            dataGridViewRecipeItems.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridViewRecipeItems.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewRecipeItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
