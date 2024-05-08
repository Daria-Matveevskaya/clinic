namespace Clinic.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            toolStrip1 = new ToolStrip();
            toolStripButtonAdd = new ToolStripButton();
            toolStripButtonEdit = new ToolStripButton();
            toolStripButtonRemove = new ToolStripButton();
            employeeBindingSource = new BindingSource(components);
            dataGridViewEmployees = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patronymicNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderAsStringDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd, toolStripButtonEdit, toolStripButtonRemove });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            toolStripButtonAdd.Image = (Image)resources.GetObject("toolStripButtonAdd.Image");
            toolStripButtonAdd.ImageTransparentColor = Color.Magenta;
            toolStripButtonAdd.Name = "toolStripButtonAdd";
            toolStripButtonAdd.Size = new Size(100, 24);
            toolStripButtonAdd.Text = "Добавить";
            toolStripButtonAdd.ToolTipText = "Добавить";
            toolStripButtonAdd.Click += toolStripButtonAdd_Click;
            // 
            // toolStripButtonEdit
            // 
            toolStripButtonEdit.Image = (Image)resources.GetObject("toolStripButtonEdit.Image");
            toolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit.Name = "toolStripButtonEdit";
            toolStripButtonEdit.RightToLeft = RightToLeft.No;
            toolStripButtonEdit.Size = new Size(135, 24);
            toolStripButtonEdit.Text = "Редактировать";
            toolStripButtonEdit.Click += toolStripButtonEdit_Click;
            // 
            // toolStripButtonRemove
            // 
            toolStripButtonRemove.Image = (Image)resources.GetObject("toolStripButtonRemove.Image");
            toolStripButtonRemove.ImageTransparentColor = Color.Magenta;
            toolStripButtonRemove.Name = "toolStripButtonRemove";
            toolStripButtonRemove.Size = new Size(89, 24);
            toolStripButtonRemove.Text = "Удалить";
            toolStripButtonRemove.Click += toolStripButtonRemove_Click;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Data.Entities.Employee);
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AutoGenerateColumns = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewEmployees.ColumnHeadersHeight = 29;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, patronymicNameDataGridViewTextBoxColumn, genderAsStringDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn });
            dataGridViewEmployees.DataSource = employeeBindingSource;
            dataGridViewEmployees.Dock = DockStyle.Fill;
            dataGridViewEmployees.Location = new Point(0, 27);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowTemplate.Height = 29;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(800, 423);
            dataGridViewEmployees.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // patronymicNameDataGridViewTextBoxColumn
            // 
            patronymicNameDataGridViewTextBoxColumn.DataPropertyName = "PatronymicName";
            patronymicNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            patronymicNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            patronymicNameDataGridViewTextBoxColumn.Name = "patronymicNameDataGridViewTextBoxColumn";
            // 
            // genderAsStringDataGridViewTextBoxColumn
            // 
            genderAsStringDataGridViewTextBoxColumn.DataPropertyName = "GenderAsString";
            genderAsStringDataGridViewTextBoxColumn.HeaderText = "Пол";
            genderAsStringDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderAsStringDataGridViewTextBoxColumn.Name = "genderAsStringDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(toolStrip1);
            Name = "EmployeeForm";
            Text = "Сотрудники";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripButton toolStripButtonAdd;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripButton toolStripButtonRemove;
        private BindingSource employeeBindingSource;
        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronymicNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderAsStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;

        public ToolStrip toolStrip1;
    }
}