namespace Clinic.Forms
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            panel5 = new Panel();
            dataGridViewExpenseItems = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseBindingSource = new BindingSource(components);
            expenseItemsBindingSource = new BindingSource(components);
            splitter2 = new Splitter();
            dataGridViewExpenses = new DataGridView();
            toolStrip3 = new ToolStrip();
            toolStripButtonExpenseAdd = new ToolStripButton();
            toolStripButtonExpenseEdit = new ToolStripButton();
            toolStripButtonExpenseRemove = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridViewExpenseItems);
            panel5.Controls.Add(splitter2);
            panel5.Controls.Add(dataGridViewExpenses);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 423);
            panel5.TabIndex = 4;
            // 
            // dataGridViewExpenseItems
            // 
            dataGridViewExpenseItems.AutoGenerateColumns = false;
            dataGridViewExpenseItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpenseItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewExpenseItems.ColumnHeadersHeight = 29;
            dataGridViewExpenseItems.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, expenseIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, expenseDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn });
            dataGridViewExpenseItems.DataSource = expenseItemsBindingSource;
            dataGridViewExpenseItems.Dock = DockStyle.Fill;
            dataGridViewExpenseItems.Location = new Point(404, 0);
            dataGridViewExpenseItems.Name = "dataGridViewExpenseItems";
            dataGridViewExpenseItems.RowHeadersVisible = false;
            dataGridViewExpenseItems.RowHeadersWidth = 51;
            dataGridViewExpenseItems.RowTemplate.Height = 29;
            dataGridViewExpenseItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenseItems.Size = new Size(396, 423);
            dataGridViewExpenseItems.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // expenseIdDataGridViewTextBoxColumn
            // 
            expenseIdDataGridViewTextBoxColumn.DataPropertyName = "ExpenseId";
            expenseIdDataGridViewTextBoxColumn.HeaderText = "ExpenseId";
            expenseIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseIdDataGridViewTextBoxColumn.Name = "expenseIdDataGridViewTextBoxColumn";
            expenseIdDataGridViewTextBoxColumn.Visible = false;
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
            // expenseDataGridViewTextBoxColumn
            // 
            expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            expenseDataGridViewTextBoxColumn.MinimumWidth = 6;
            expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            expenseDataGridViewTextBoxColumn.Visible = false;
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
            // expenseItemsBindingSource
            // 
            expenseItemsBindingSource.DataMember = "ExpenseItems";
            expenseItemsBindingSource.DataSource = expenseBindingSource;
            // 
            // expenseBindingSource
            // 
            expenseBindingSource.DataSource = typeof(Data.Entities.Expense);
            // 
            // splitter2
            // 
            splitter2.Location = new Point(400, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(4, 423);
            splitter2.TabIndex = 4;
            splitter2.TabStop = false;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.AutoGenerateColumns = false;
            dataGridViewExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpenses.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewExpenses.ColumnHeadersHeight = 29;
            dataGridViewExpenses.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22 });
            dataGridViewExpenses.DataSource = expenseBindingSource;
            dataGridViewExpenses.Dock = DockStyle.Left;
            dataGridViewExpenses.Location = new Point(0, 0);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersVisible = false;
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.RowTemplate.Height = 29;
            dataGridViewExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenses.Size = new Size(400, 423);
            dataGridViewExpenses.TabIndex = 1;
            dataGridViewExpenses.SelectionChanged += dataGridViewExpenses_SelectionChanged;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButtonExpenseAdd, toolStripButtonExpenseEdit, toolStripButtonExpenseRemove, toolStripButton3 });
            toolStrip3.Location = new Point(0, 0);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(800, 27);
            toolStrip3.TabIndex = 3;
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
            toolStripButtonExpenseAdd.Click += toolStripButtonExpenseAdd_Click;
            // 
            // toolStripButtonExpenseEdit
            // 
            toolStripButtonExpenseEdit.Image = (Image)resources.GetObject("toolStripButtonExpenseEdit.Image");
            toolStripButtonExpenseEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonExpenseEdit.Name = "toolStripButtonExpenseEdit";
            toolStripButtonExpenseEdit.RightToLeft = RightToLeft.No;
            toolStripButtonExpenseEdit.Size = new Size(135, 24);
            toolStripButtonExpenseEdit.Text = "Редактировать";
            toolStripButtonExpenseEdit.Click += toolStripButtonExpenseEdit_Click;
            // 
            // toolStripButtonExpenseRemove
            // 
            toolStripButtonExpenseRemove.Image = (Image)resources.GetObject("toolStripButtonExpenseRemove.Image");
            toolStripButtonExpenseRemove.ImageTransparentColor = Color.Magenta;
            toolStripButtonExpenseRemove.Name = "toolStripButtonExpenseRemove";
            toolStripButtonExpenseRemove.Size = new Size(89, 24);
            toolStripButtonExpenseRemove.Text = "Удалить";
            toolStripButtonExpenseRemove.Click += toolStripButtonExpenseRemove_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(139, 24);
            toolStripButton3.Text = "Экспорт в Excel";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Id";
            dataGridViewTextBoxColumn17.HeaderText = "Номер";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "Date";
            dataGridViewTextBoxColumn18.HeaderText = "Создан";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.DataPropertyName = "ExpDate";
            dataGridViewTextBoxColumn19.HeaderText = "Выдан";
            dataGridViewTextBoxColumn19.MinimumWidth = 6;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.DataPropertyName = "EmployeeId";
            dataGridViewTextBoxColumn20.HeaderText = "EmployeeId";
            dataGridViewTextBoxColumn20.MinimumWidth = 6;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.DataPropertyName = "Employee";
            dataGridViewTextBoxColumn21.HeaderText = "Employee";
            dataGridViewTextBoxColumn21.MinimumWidth = 6;
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.DataPropertyName = "EmployeeFullName";
            dataGridViewTextBoxColumn22.HeaderText = "EmployeeFullName";
            dataGridViewTextBoxColumn22.MinimumWidth = 6;
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            dataGridViewTextBoxColumn22.Visible = false;
            // 
            // RequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(toolStrip3);
            Name = "RequestForm";
            Text = "Мои заявки";
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButtonExpenseAdd;
        private ToolStripButton toolStripButtonExpenseEdit;
        private ToolStripButton toolStripButtonExpenseRemove;
        private ToolStripButton toolStripButton3;
        private DataGridView dataGridViewExpenses;
        private Splitter splitter2;
        private DataGridView dataGridViewExpenseItems;
        private BindingSource expenseBindingSource;
        private BindingSource expenseItemsBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    }
}