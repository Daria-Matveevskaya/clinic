﻿namespace Clinic.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            dataGridViewStore = new DataGridView();
            toolStrip1 = new ToolStrip();
            tabPage2 = new TabPage();
            splitter1 = new Splitter();
            panel3 = new Panel();
            dataGridViewRecipeItems = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeBindingSource = new BindingSource(components);
            recipeItemsBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dataGridViewRecipes = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            providerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip2 = new ToolStrip();
            toolStripButtonRecipeAdd = new ToolStripButton();
            toolStripButtonRecipeEdit = new ToolStripButton();
            toolStripButtonRecipeRemove = new ToolStripButton();
            tabPage3 = new TabPage();
            splitter2 = new Splitter();
            panel5 = new Panel();
            dataGridViewExpenseItems = new DataGridView();
            productNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            expenseBindingSource = new BindingSource(components);
            expenseItemsBindingSource = new BindingSource(components);
            panel4 = new Panel();
            dataGridViewExpenses = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            employeeFullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip3 = new ToolStrip();
            toolStripButtonExpenseAdd = new ToolStripButton();
            toolStripButtonExpenseEdit = new ToolStripButton();
            toolStripButtonExpenseRemove = new ToolStripButton();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            recipeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recipeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            expenseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)recipeItemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).BeginInit();
            toolStrip2.SuspendLayout();
            tabPage3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            toolStrip3.SuspendLayout();
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
            dataGridViewStore.RowHeadersVisible = false;
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
            splitter1.Location = new Point(403, 30);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 384);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewRecipeItems);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(403, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 384);
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
            dataGridViewRecipeItems.RowHeadersVisible = false;
            dataGridViewRecipeItems.RowHeadersWidth = 51;
            dataGridViewRecipeItems.RowTemplate.Height = 29;
            dataGridViewRecipeItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipeItems.Size = new Size(386, 384);
            dataGridViewRecipeItems.TabIndex = 0;
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
            // recipeItemsBindingSource
            // 
            recipeItemsBindingSource.DataMember = "RecipeItems";
            recipeItemsBindingSource.DataSource = recipeBindingSource;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Data.Entities.Recipe);
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewRecipes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 384);
            panel2.TabIndex = 1;
            // 
            // dataGridViewRecipes
            // 
            dataGridViewRecipes.AutoGenerateColumns = false;
            dataGridViewRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecipes.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewRecipes.ColumnHeadersHeight = 29;
            dataGridViewRecipes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dateDataGridViewTextBoxColumn, providerNameDataGridViewTextBoxColumn });
            dataGridViewRecipes.DataSource = recipeBindingSource;
            dataGridViewRecipes.Dock = DockStyle.Fill;
            dataGridViewRecipes.Location = new Point(0, 0);
            dataGridViewRecipes.Name = "dataGridViewRecipes";
            dataGridViewRecipes.RowHeadersVisible = false;
            dataGridViewRecipes.RowHeadersWidth = 51;
            dataGridViewRecipes.RowTemplate.Height = 29;
            dataGridViewRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecipes.Size = new Size(400, 384);
            dataGridViewRecipes.TabIndex = 0;
            dataGridViewRecipes.SelectionChanged += dataGridViewRecipes_SelectionChanged;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            dataGridViewTextBoxColumn3.HeaderText = "Номер";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            providerNameDataGridViewTextBoxColumn.DataPropertyName = "ProviderName";
            providerNameDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            providerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            providerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButtonRecipeAdd, toolStripButtonRecipeEdit, toolStripButtonRecipeRemove });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(786, 27);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonRecipeAdd
            // 
            toolStripButtonRecipeAdd.Image = (Image)resources.GetObject("toolStripButtonRecipeAdd.Image");
            toolStripButtonRecipeAdd.ImageTransparentColor = Color.Magenta;
            toolStripButtonRecipeAdd.Name = "toolStripButtonRecipeAdd";
            toolStripButtonRecipeAdd.Size = new Size(100, 24);
            toolStripButtonRecipeAdd.Text = "Добавить";
            toolStripButtonRecipeAdd.ToolTipText = "Добавить";
            // 
            // toolStripButtonRecipeEdit
            // 
            toolStripButtonRecipeEdit.Image = (Image)resources.GetObject("toolStripButtonRecipeEdit.Image");
            toolStripButtonRecipeEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonRecipeEdit.Name = "toolStripButtonRecipeEdit";
            toolStripButtonRecipeEdit.RightToLeft = RightToLeft.No;
            toolStripButtonRecipeEdit.Size = new Size(135, 24);
            toolStripButtonRecipeEdit.Text = "Редактировать";
            // 
            // toolStripButtonRecipeRemove
            // 
            toolStripButtonRecipeRemove.Image = (Image)resources.GetObject("toolStripButtonRecipeRemove.Image");
            toolStripButtonRecipeRemove.ImageTransparentColor = Color.Magenta;
            toolStripButtonRecipeRemove.Name = "toolStripButtonRecipeRemove";
            toolStripButtonRecipeRemove.Size = new Size(89, 24);
            toolStripButtonRecipeRemove.Text = "Удалить";
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
            splitter2.Location = new Point(403, 30);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 384);
            splitter2.TabIndex = 3;
            splitter2.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridViewExpenseItems);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(403, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 384);
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
            dataGridViewExpenseItems.RowHeadersVisible = false;
            dataGridViewExpenseItems.RowHeadersWidth = 51;
            dataGridViewExpenseItems.RowTemplate.Height = 29;
            dataGridViewExpenseItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenseItems.Size = new Size(386, 384);
            dataGridViewExpenseItems.TabIndex = 0;
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
            // expirationDateDataGridViewTextBoxColumn1
            // 
            expirationDateDataGridViewTextBoxColumn1.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn1.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            expirationDateDataGridViewTextBoxColumn1.Name = "expirationDateDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn1.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn1.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // expenseItemsBindingSource
            // 
            expenseItemsBindingSource.DataMember = "ExpenseItems";
            expenseItemsBindingSource.DataSource = expenseBindingSource;
            // 
            // expenseBindingSource
            // 
            expenseBindingSource.DataSource = typeof(Data.Entities.Expense);
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewExpenses);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(3, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 384);
            panel4.TabIndex = 1;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.AutoGenerateColumns = false;
            dataGridViewExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpenses.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewExpenses.ColumnHeadersHeight = 29;
            dataGridViewExpenses.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn1, employeeFullNameDataGridViewTextBoxColumn });
            dataGridViewExpenses.DataSource = expenseBindingSource;
            dataGridViewExpenses.Dock = DockStyle.Fill;
            dataGridViewExpenses.Location = new Point(0, 0);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersVisible = false;
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.RowTemplate.Height = 29;
            dataGridViewExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenses.Size = new Size(400, 384);
            dataGridViewExpenses.TabIndex = 0;
            dataGridViewExpenses.SelectionChanged += dataGridViewExpenses_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Номер";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn1.HeaderText = "Дата";
            dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            // 
            // employeeFullNameDataGridViewTextBoxColumn
            // 
            employeeFullNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFullName";
            employeeFullNameDataGridViewTextBoxColumn.HeaderText = "Получатель";
            employeeFullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeFullNameDataGridViewTextBoxColumn.Name = "employeeFullNameDataGridViewTextBoxColumn";
            employeeFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButtonExpenseAdd, toolStripButtonExpenseEdit, toolStripButtonExpenseRemove });
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(786, 27);
            toolStrip3.TabIndex = 0;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButtonExpenseAdd
            // 
            toolStripButtonExpenseAdd.Image = (Image)resources.GetObject("toolStripButtonExpenseAdd.Image");
            toolStripButtonExpenseAdd.ImageTransparentColor = Color.Magenta;
            toolStripButtonExpenseAdd.Name = "toolStripButtonExpenseAdd";
            toolStripButtonExpenseAdd.Size = new Size(100, 24);
            toolStripButtonExpenseAdd.Text = "Добавить";
            toolStripButtonExpenseAdd.ToolTipText = "Добавить";
            // 
            // toolStripButtonExpenseEdit
            // 
            toolStripButtonExpenseEdit.Image = (Image)resources.GetObject("toolStripButtonExpenseEdit.Image");
            toolStripButtonExpenseEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonExpenseEdit.Name = "toolStripButtonExpenseEdit";
            toolStripButtonExpenseEdit.RightToLeft = RightToLeft.No;
            toolStripButtonExpenseEdit.Size = new Size(135, 24);
            toolStripButtonExpenseEdit.Text = "Редактировать";
            // 
            // toolStripButtonExpenseRemove
            // 
            toolStripButtonExpenseRemove.Image = (Image)resources.GetObject("toolStripButtonExpenseRemove.Image");
            toolStripButtonExpenseRemove.ImageTransparentColor = Color.Magenta;
            toolStripButtonExpenseRemove.Name = "toolStripButtonExpenseRemove";
            toolStripButtonExpenseRemove.Size = new Size(89, 24);
            toolStripButtonExpenseRemove.Text = "Удалить";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // recipeIdDataGridViewTextBoxColumn
            // 
            recipeIdDataGridViewTextBoxColumn.DataPropertyName = "RecipeId";
            recipeIdDataGridViewTextBoxColumn.HeaderText = "RecipeId";
            recipeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeIdDataGridViewTextBoxColumn.Name = "recipeIdDataGridViewTextBoxColumn";
            recipeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // recipeDataGridViewTextBoxColumn
            // 
            recipeDataGridViewTextBoxColumn.DataPropertyName = "Recipe";
            recipeDataGridViewTextBoxColumn.HeaderText = "Recipe";
            recipeDataGridViewTextBoxColumn.MinimumWidth = 6;
            recipeDataGridViewTextBoxColumn.Name = "recipeDataGridViewTextBoxColumn";
            recipeDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.MinimumWidth = 6;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // expenseIdDataGridViewTextBoxColumn
            // 
            expenseIdDataGridViewTextBoxColumn.DataPropertyName = "ExpenseId";
            expenseIdDataGridViewTextBoxColumn.HeaderText = "ExpenseId";
            expenseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseIdDataGridViewTextBoxColumn.Name = "expenseIdDataGridViewTextBoxColumn";
            expenseIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            expenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            expenseDataGridViewTextBoxColumn.Width = 125;
            // 
            // productDataGridViewTextBoxColumn1
            // 
            productDataGridViewTextBoxColumn1.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn1.HeaderText = "Product";
            productDataGridViewTextBoxColumn1.MinimumWidth = 6;
            productDataGridViewTextBoxColumn1.Name = "productDataGridViewTextBoxColumn1";
            productDataGridViewTextBoxColumn1.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn1.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn1.MinimumWidth = 6;
            unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            unitDataGridViewTextBoxColumn1.Width = 125;
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
            ((System.ComponentModel.ISupportInitialize)recipeItemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecipes).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
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
        private ToolStripButton toolStripButtonRecipeAdd;
        private ToolStripButton toolStripButtonRecipeEdit;
        private ToolStripButton toolStripButtonRecipeRemove;
        private ToolStripButton toolStripButtonExpenseAdd;
        private ToolStripButton toolStripButtonExpenseEdit;
        private ToolStripButton toolStripButtonExpenseRemove;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn employeeFullNameDataGridViewTextBoxColumn;
    }
}