namespace Clinic.Forms
{
    partial class StoreForm
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
            dataGridViewRecipeItems = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeItemBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipeItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRecipeItems
            // 
            dataGridViewRecipeItems.AutoGenerateColumns = false;
            dataGridViewRecipeItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipeItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewRecipeItems.ColumnHeadersHeight = 29;
            dataGridViewRecipeItems.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, recipeIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, recipeDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn });
            dataGridViewRecipeItems.DataSource = recipeItemBindingSource;
            dataGridViewRecipeItems.Dock = DockStyle.Fill;
            dataGridViewRecipeItems.Location = new Point(0, 0);
            dataGridViewRecipeItems.Name = "dataGridViewRecipeItems";
            dataGridViewRecipeItems.RowHeadersWidth = 51;
            dataGridViewRecipeItems.RowTemplate.Height = 29;
            dataGridViewRecipeItems.Size = new Size(800, 450);
            dataGridViewRecipeItems.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // recipeIdDataGridViewTextBoxColumn
            // 
            recipeIdDataGridViewTextBoxColumn.DataPropertyName = "RecipeId";
            recipeIdDataGridViewTextBoxColumn.HeaderText = "RecipeId";
            recipeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeIdDataGridViewTextBoxColumn.Name = "recipeIdDataGridViewTextBoxColumn";
            recipeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Товар";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // recipeDataGridViewTextBoxColumn
            // 
            recipeDataGridViewTextBoxColumn.DataPropertyName = "Recipe";
            recipeDataGridViewTextBoxColumn.HeaderText = "Recipe";
            recipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeDataGridViewTextBoxColumn.Name = "recipeDataGridViewTextBoxColumn";
            recipeDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.Visible = false;
            // 
            // recipeItemBindingSource
            // 
            recipeItemBindingSource.DataSource = typeof(Data.Entities.RecipeItem);
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRecipeItems);
            Name = "StoreForm";
            Text = "Мой склад";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipeItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeItemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRecipeItems;
        private BindingSource recipeItemBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
    }
}