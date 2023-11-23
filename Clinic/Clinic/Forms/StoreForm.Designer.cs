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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            dataGridViewStore = new DataGridView();
            toolStrip1 = new ToolStrip();
            tabPage2 = new TabPage();
            splitter1 = new Splitter();
            panel3 = new Panel();
            dataGridViewRecipeItems = new DataGridView();
            panel2 = new Panel();
            dataGridViewRecipes = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeBindingSource = new BindingSource(components);
            toolStrip2 = new ToolStrip();
            tabPage3 = new TabPage();
            splitter2 = new Splitter();
            panel5 = new Panel();
            dataGridViewExpenseItems = new DataGridView();
            panel4 = new Panel();
            dataGridViewExpenses = new DataGridView();
            idDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseBindingSource = new BindingSource(components);
            toolStrip3 = new ToolStrip();
            recipeItemsBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            recipeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseItemsBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            expenseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            expenseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStore).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipeItems).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeItemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Остаток";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewStore);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 386);
            panel1.TabIndex = 3;
            // 
            // dataGridViewStore
            // 
            dataGridViewStore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStore.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewStore.ColumnHeadersHeight = 29;
            dataGridViewStore.Dock = DockStyle.Fill;
            dataGridViewStore.Location = new Point(0, 0);
            dataGridViewStore.Name = "dataGridViewStore";
            dataGridViewStore.RowHeadersWidth = 51;
            dataGridViewStore.RowTemplate.Height = 29;
            dataGridViewStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStore.Size = new Size(786, 386);
            dataGridViewStore.TabIndex = 2;
            dataGridViewStore.RowPrePaint += dataGridViewStore_RowPrePaint;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(786, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitter1);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(toolStrip2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Приходы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(253, 28);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 386);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewRecipeItems);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(253, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 386);
            panel3.TabIndex = 2;
            // 
            // dataGridViewRecipeItems
            // 
            dataGridViewRecipeItems.AutoGenerateColumns = false;
            dataGridViewRecipeItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipeItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewRecipeItems.ColumnHeadersHeight = 29;
            dataGridViewRecipeItems.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridViewRecipeItems.DataSource = recipeItemsBindingSource;
            dataGridViewRecipeItems.Dock = DockStyle.Fill;
            dataGridViewRecipeItems.Location = new Point(0, 0);
            dataGridViewRecipeItems.Name = "dataGridViewRecipeItems";
            dataGridViewRecipeItems.RowHeadersWidth = 51;
            dataGridViewRecipeItems.RowTemplate.Height = 29;
            dataGridViewRecipeItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipeItems.Size = new Size(536, 386);
            dataGridViewRecipeItems.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewRecipes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 386);
            panel2.TabIndex = 1;
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.AutoGenerateColumns = false;
            dataGridViewRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipes.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewRecipes.ColumnHeadersHeight = 29;
            dataGridViewRecipes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, dateDataGridViewTextBoxColumn, providerIdDataGridViewTextBoxColumn, providerDataGridViewTextBoxColumn });
            dataGridViewRecipes.DataSource = recipeBindingSource;
            dataGridViewRecipes.Dock = DockStyle.Fill;
            dataGridViewRecipes.Location = new Point(0, 0);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.RowHeadersWidth = 51;
            dataGridViewRecipes.RowTemplate.Height = 29;
            dataGridViewRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipes.Size = new Size(250, 386);
            dataGridViewRecipes.TabIndex = 0;
            dataGridViewRecipes.SelectionChanged += dataGridViewRecipes_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Номер";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // providerIdDataGridViewTextBoxColumn
            // 
            providerIdDataGridViewTextBoxColumn.DataPropertyName = "ProviderId";
            providerIdDataGridViewTextBoxColumn.HeaderText = "ProviderId";
            providerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            providerIdDataGridViewTextBoxColumn.Name = "providerIdDataGridViewTextBoxColumn";
            providerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // providerDataGridViewTextBoxColumn
            // 
            providerDataGridViewTextBoxColumn.DataPropertyName = "Provider";
            providerDataGridViewTextBoxColumn.HeaderText = "Provider";
            providerDataGridViewTextBoxColumn.MinimumWidth = 6;
            providerDataGridViewTextBoxColumn.Name = "providerDataGridViewTextBoxColumn";
            providerDataGridViewTextBoxColumn.Visible = false;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Data.Entities.Recipe);
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(786, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(splitter2);
            tabPage3.Controls.Add(panel5);
            tabPage3.Controls.Add(panel4);
            tabPage3.Controls.Add(toolStrip3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Расходы";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(253, 28);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 386);
            splitter2.TabIndex = 3;
            splitter2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridViewExpenseItems);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(253, 28);
            panel5.Name = "panel5";
            panel5.Size = new Size(536, 386);
            panel5.TabIndex = 2;
            // 
            // dataGridViewExpenseItems
            // 
            dataGridViewExpenseItems.AutoGenerateColumns = false;
            dataGridViewExpenseItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpenseItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewExpenseItems.ColumnHeadersHeight = 29;
            dataGridViewExpenseItems.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn1, unitNameDataGridViewTextBoxColumn1, expirationDateDataGridViewTextBoxColumn1, quantityDataGridViewTextBoxColumn1 });
            dataGridViewExpenseItems.DataSource = expenseItemsBindingSource;
            dataGridViewExpenseItems.Dock = DockStyle.Fill;
            dataGridViewExpenseItems.Location = new Point(0, 0);
            dataGridViewExpenseItems.Name = "dataGridViewExpenseItems";
            dataGridViewExpenseItems.RowHeadersWidth = 51;
            dataGridViewExpenseItems.RowTemplate.Height = 29;
            dataGridViewExpenseItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenseItems.Size = new Size(536, 386);
            dataGridViewExpenseItems.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewExpenses);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 386);
            panel4.TabIndex = 1;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.AutoGenerateColumns = false;
            dataGridViewExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpenses.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewExpenses.ColumnHeadersHeight = 29;
            dataGridViewExpenses.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn3, dateDataGridViewTextBoxColumn1, employeeIdDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn });
            dataGridViewExpenses.DataSource = expenseBindingSource;
            dataGridViewExpenses.Dock = DockStyle.Fill;
            dataGridViewExpenses.Location = new Point(0, 0);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.RowTemplate.Height = 29;
            dataGridViewExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenses.Size = new Size(250, 386);
            dataGridViewExpenses.TabIndex = 0;
            dataGridViewExpenses.SelectionChanged += dataGridViewExpenses_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            idDataGridViewTextBoxColumn3.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn3.HeaderText = "Номер";
            idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn1.HeaderText = "Дата";
            dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.Visible = false;
            // 
            // expenseBindingSource
            // 
            expenseBindingSource.DataSource = typeof(Data.Entities.Expense);
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(786, 25);
            toolStrip3.TabIndex = 0;
            toolStrip3.Text = "toolStrip3";
            // 
            // recipeItemsBindingSource
            // 
            recipeItemsBindingSource.DataMember = "RecipeItems";
            recipeItemsBindingSource.DataSource = recipeBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // recipeIdDataGridViewTextBoxColumn
            // 
            recipeIdDataGridViewTextBoxColumn.DataPropertyName = "RecipeId";
            recipeIdDataGridViewTextBoxColumn.HeaderText = "RecipeId";
            recipeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeIdDataGridViewTextBoxColumn.Name = "recipeIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.HeaderText = "Единицы измерения";
            unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // recipeDataGridViewTextBoxColumn
            // 
            recipeDataGridViewTextBoxColumn.DataPropertyName = "Recipe";
            recipeDataGridViewTextBoxColumn.HeaderText = "Recipe";
            recipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeDataGridViewTextBoxColumn.Name = "recipeDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // expenseItemsBindingSource
            // 
            expenseItemsBindingSource.DataMember = "ExpenseItems";
            expenseItemsBindingSource.DataSource = expenseBindingSource;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // expenseIdDataGridViewTextBoxColumn
            // 
            expenseIdDataGridViewTextBoxColumn.DataPropertyName = "ExpenseId";
            expenseIdDataGridViewTextBoxColumn.HeaderText = "ExpenseId";
            expenseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseIdDataGridViewTextBoxColumn.Name = "expenseIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn1
            // 
            productNameDataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            productNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn1.Name = "productNameDataGridViewTextBoxColumn1";
            // 
            // unitNameDataGridViewTextBoxColumn1
            // 
            unitNameDataGridViewTextBoxColumn1.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn1.HeaderText = "Единицы измерения";
            unitNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn1.Name = "unitNameDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // expirationDateDataGridViewTextBoxColumn1
            // 
            expirationDateDataGridViewTextBoxColumn1.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn1.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            expirationDateDataGridViewTextBoxColumn1.Name = "expirationDateDataGridViewTextBoxColumn1";
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            expenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn1
            // 
            productDataGridViewTextBoxColumn1.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn1.HeaderText = "Product";
            productDataGridViewTextBoxColumn1.MinimumWidth = 6;
            productDataGridViewTextBoxColumn1.Name = "productDataGridViewTextBoxColumn1";
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn1.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn1.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "StoreForm";
            Text = "Мой склад";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStore).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipeItems).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeItemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView dataGridViewStore;
        private Splitter splitter1;
        private Panel panel3;
        private Panel panel2;
        private ToolStrip toolStrip2;
        private ToolStrip toolStrip3;
        private Splitter splitter2;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dataGridViewRecipes;
        private BindingSource recipeBindingSource;
        private DataGridView dataGridViewRecipeItems;
        private DataGridView dataGridViewExpenseItems;
        private BindingSource expenseBindingSource;
        private DataGridView dataGridViewExpenses;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn recipeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private BindingSource recipeItemsBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn expenseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private BindingSource expenseItemsBindingSource;
    }
}