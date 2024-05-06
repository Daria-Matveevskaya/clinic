namespace Clinic.Forms
{
    partial class RequestEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestEditForm));
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            dataGridViewExpenseItems = new DataGridView();
            isCheckedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitNameDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            unitBindingSource = new BindingSource(components);
            expirationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expenseItemModelBindingSource = new BindingSource(components);
            panel3 = new Panel();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemModelBindingSource).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 54);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(665, 13);
            button2.Name = "button2";
            button2.Size = new Size(123, 29);
            button2.TabIndex = 1;
            button2.Text = "Отменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(524, 13);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewExpenseItems
            // 
            dataGridViewExpenseItems.AutoGenerateColumns = false;
            dataGridViewExpenseItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewExpenseItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewExpenseItems.ColumnHeadersHeight = 29;
            dataGridViewExpenseItems.Columns.AddRange(new DataGridViewColumn[] { isCheckedDataGridViewCheckBoxColumn, productNameDataGridViewTextBoxColumn, unitNameDataGridViewTextBoxColumn, expirationDateDataGridViewTextBoxColumn, Balance, quantityDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            dataGridViewExpenseItems.DataSource = expenseItemModelBindingSource;
            dataGridViewExpenseItems.Dock = DockStyle.Fill;
            dataGridViewExpenseItems.Location = new Point(0, 56);
            dataGridViewExpenseItems.Name = "dataGridViewExpenseItems";
            dataGridViewExpenseItems.RowHeadersVisible = false;
            dataGridViewExpenseItems.RowHeadersWidth = 51;
            dataGridViewExpenseItems.RowTemplate.Height = 29;
            dataGridViewExpenseItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExpenseItems.Size = new Size(800, 394);
            dataGridViewExpenseItems.TabIndex = 6;
            dataGridViewExpenseItems.CellContentClick += dataGridViewExpenseItems_CellContentClick;
            dataGridViewExpenseItems.RowPrePaint += dataGridViewExpenseItems_RowPrePaint;
            // 
            // isCheckedDataGridViewCheckBoxColumn
            // 
            isCheckedDataGridViewCheckBoxColumn.DataPropertyName = "IsChecked";
            isCheckedDataGridViewCheckBoxColumn.HeaderText = "";
            isCheckedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isCheckedDataGridViewCheckBoxColumn.Name = "isCheckedDataGridViewCheckBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitNameDataGridViewTextBoxColumn
            // 
            unitNameDataGridViewTextBoxColumn.DataPropertyName = "UnitName";
            unitNameDataGridViewTextBoxColumn.DataSource = unitBindingSource;
            unitNameDataGridViewTextBoxColumn.DisplayMember = "Name";
            unitNameDataGridViewTextBoxColumn.FlatStyle = FlatStyle.Flat;
            unitNameDataGridViewTextBoxColumn.HeaderText = "Единицы измерения";
            unitNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            unitNameDataGridViewTextBoxColumn.Name = "unitNameDataGridViewTextBoxColumn";
            unitNameDataGridViewTextBoxColumn.ReadOnly = true;
            unitNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            unitNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            unitNameDataGridViewTextBoxColumn.ValueMember = "Name";
            // 
            // unitBindingSource
            // 
            unitBindingSource.DataSource = typeof(Data.Entities.Unit);
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            expirationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Остаток";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // expenseItemModelBindingSource
            // 
            expenseItemModelBindingSource.DataSource = typeof(Models.ExpenseItemModel);
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 56);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 22);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(538, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // RequestEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dataGridViewExpenseItems);
            Controls.Add(panel3);
            Name = "RequestEditForm";
            Text = "Заявка";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenseItems).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseItemModelBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridViewExpenseItems;
        private Panel panel3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private BindingSource expenseItemModelBindingSource;
        private BindingSource unitBindingSource;
        private DataGridViewCheckBoxColumn isCheckedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn unitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}