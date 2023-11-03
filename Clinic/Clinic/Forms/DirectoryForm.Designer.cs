namespace Clinic.Forms
{
    partial class DirectoryForm
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
            dataGridViewDirectories = new DataGridView();
            employeeBindingSource = new BindingSource(components);
            unitBindingSource = new BindingSource(components);
            categoryBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            providerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDirectories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDirectories
            // 
            dataGridViewDirectories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDirectories.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDirectories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDirectories.Dock = DockStyle.Fill;
            dataGridViewDirectories.Location = new Point(0, 0);
            dataGridViewDirectories.Margin = new Padding(3, 2, 3, 2);
            dataGridViewDirectories.Name = "dataGridViewDirectories";
            dataGridViewDirectories.RowHeadersWidth = 51;
            dataGridViewDirectories.RowTemplate.Height = 29;
            dataGridViewDirectories.Size = new Size(700, 338);
            dataGridViewDirectories.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Data.Entities.Employee);
            // 
            // unitBindingSource
            // 
            unitBindingSource.DataSource = typeof(Data.Entities.Unit);
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Data.Entities.Category);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Data.Entities.Product);
            // 
            // providerBindingSource
            // 
            providerBindingSource.DataSource = typeof(Data.Entities.Provider);
            // 
            // DirectoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewDirectories);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DirectoryForm";
            Text = "DirectoryForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDirectories).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)providerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDirectories;
        private BindingSource unitBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource employeeBindingSource;
        private BindingSource productBindingSource;
        private BindingSource providerBindingSource;
    }
}