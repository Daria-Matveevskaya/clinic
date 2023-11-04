namespace Clinic.Forms
{
    partial class UnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitForm));
            dataGridViewUnits = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abbreviationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripButtonAdd = new ToolStripButton();
            toolStripButtonEdit = new ToolStripButton();
            toolStripButtonSave = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.AutoGenerateColumns = false;
            dataGridViewUnits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, abbreviationDataGridViewTextBoxColumn });
            dataGridViewUnits.DataSource = unitBindingSource;
            dataGridViewUnits.Dock = DockStyle.Fill;
            dataGridViewUnits.Location = new Point(0, 27);
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.RowHeadersWidth = 51;
            dataGridViewUnits.RowTemplate.Height = 29;
            dataGridViewUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnits.Size = new Size(800, 423);
            dataGridViewUnits.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // abbreviationDataGridViewTextBoxColumn
            // 
            abbreviationDataGridViewTextBoxColumn.DataPropertyName = "Abbreviation";
            abbreviationDataGridViewTextBoxColumn.HeaderText = "Обозначение";
            abbreviationDataGridViewTextBoxColumn.MinimumWidth = 6;
            abbreviationDataGridViewTextBoxColumn.Name = "abbreviationDataGridViewTextBoxColumn";
            // 
            // unitBindingSource
            // 
            unitBindingSource.DataSource = typeof(Data.Entities.Unit);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd, toolStripButtonEdit, toolStripButtonSave });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 4;
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
            // toolStripButtonSave
            // 
            toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
            toolStripButtonSave.ImageTransparentColor = Color.Magenta;
            toolStripButtonSave.Name = "toolStripButtonSave";
            toolStripButtonSave.Size = new Size(89, 24);
            toolStripButtonSave.Text = "Удалить";
            toolStripButtonSave.Click += toolStripButtonRemove_Click;
            // 
            // UnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewUnits);
            Controls.Add(toolStrip1);
            Name = "UnitForm";
            Text = "Единицы измерения";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUnits;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripButton toolStripButtonSave;
        private BindingSource unitBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abbreviationDataGridViewTextBoxColumn;
    }
}