namespace Clinic.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewCategories = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            dataGridViewProducts = new DataGridView();
            productsBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn });
            dataGridViewCategories.DataSource = categoryBindingSource;
            dataGridViewCategories.Dock = DockStyle.Left;
            dataGridViewCategories.Location = new Point(0, 0);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.RowTemplate.Height = 29;
            dataGridViewCategories.Size = new Size(300, 450);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn, createDateDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productsBindingSource;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(300, 0);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new Size(500, 450);
            dataGridViewProducts.TabIndex = 1;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Категория";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            createDateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            createDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewProducts);
            Controls.Add(dataGridViewCategories);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCategories;
        private BindingSource categoryBindingSource;
        private DataGridView dataGridViewProducts;
        private BindingSource productsBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}