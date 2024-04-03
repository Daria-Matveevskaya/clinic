namespace Clinic.Forms
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            toolStrip1 = new ToolStrip();
            toolStripButtonAdd = new ToolStripButton();
            toolStripButtonEdit = new ToolStripButton();
            toolStripButtonRemove = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            dataGridViewUsers = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            employeeFullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            normalizedUserNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            normalizedEmailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailConfirmedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            passwordHashDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            securityStampDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            concurrencyStampDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberConfirmedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            twoFactorEnabledDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            lockoutEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lockoutEnabledDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            accessFailedCountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonAdd, toolStripButtonEdit, toolStripButtonRemove, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
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
            toolStripButtonAdd.Click += toolStripButtonUserAdd_Click;
            // 
            // toolStripButtonEdit
            // 
            toolStripButtonEdit.Image = (Image)resources.GetObject("toolStripButtonEdit.Image");
            toolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit.Name = "toolStripButtonEdit";
            toolStripButtonEdit.RightToLeft = RightToLeft.No;
            toolStripButtonEdit.Size = new Size(135, 24);
            toolStripButtonEdit.Text = "Редактировать";
            toolStripButtonEdit.Click += toolStripButtonUserEdit_Click;
            // 
            // toolStripButtonRemove
            // 
            toolStripButtonRemove.Image = (Image)resources.GetObject("toolStripButtonRemove.Image");
            toolStripButtonRemove.ImageTransparentColor = Color.Magenta;
            toolStripButtonRemove.Name = "toolStripButtonRemove";
            toolStripButtonRemove.Size = new Size(89, 24);
            toolStripButtonRemove.Text = "Удалить";
            toolStripButtonRemove.Click += toolStripButtonUserRemoveAsync_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(167, 24);
            toolStripButton1.Text = "Роли пользователя";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, employeeFullNameDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, normalizedUserNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, normalizedEmailDataGridViewTextBoxColumn, emailConfirmedDataGridViewCheckBoxColumn, passwordHashDataGridViewTextBoxColumn, securityStampDataGridViewTextBoxColumn, concurrencyStampDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, phoneNumberConfirmedDataGridViewCheckBoxColumn, twoFactorEnabledDataGridViewCheckBoxColumn, lockoutEndDataGridViewTextBoxColumn, lockoutEnabledDataGridViewCheckBoxColumn, accessFailedCountDataGridViewTextBoxColumn });
            dataGridViewUsers.DataSource = userBindingSource;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(0, 27);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.RowTemplate.Height = 29;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(800, 423);
            dataGridViewUsers.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
            dataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Employee";
            dataGridViewTextBoxColumn2.HeaderText = "Employee";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
            // 
            // employeeFullNameDataGridViewTextBoxColumn
            // 
            employeeFullNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFullName";
            employeeFullNameDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            employeeFullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            employeeFullNameDataGridViewTextBoxColumn.Name = "employeeFullNameDataGridViewTextBoxColumn";
            employeeFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "Логин";
            userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // normalizedUserNameDataGridViewTextBoxColumn
            // 
            normalizedUserNameDataGridViewTextBoxColumn.DataPropertyName = "NormalizedUserName";
            normalizedUserNameDataGridViewTextBoxColumn.HeaderText = "NormalizedUserName";
            normalizedUserNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            normalizedUserNameDataGridViewTextBoxColumn.Name = "normalizedUserNameDataGridViewTextBoxColumn";
            normalizedUserNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // normalizedEmailDataGridViewTextBoxColumn
            // 
            normalizedEmailDataGridViewTextBoxColumn.DataPropertyName = "NormalizedEmail";
            normalizedEmailDataGridViewTextBoxColumn.HeaderText = "NormalizedEmail";
            normalizedEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            normalizedEmailDataGridViewTextBoxColumn.Name = "normalizedEmailDataGridViewTextBoxColumn";
            normalizedEmailDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailConfirmedDataGridViewCheckBoxColumn
            // 
            emailConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "EmailConfirmed";
            emailConfirmedDataGridViewCheckBoxColumn.HeaderText = "EmailConfirmed";
            emailConfirmedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            emailConfirmedDataGridViewCheckBoxColumn.Name = "emailConfirmedDataGridViewCheckBoxColumn";
            emailConfirmedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            passwordHashDataGridViewTextBoxColumn.HeaderText = "PasswordHash";
            passwordHashDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            passwordHashDataGridViewTextBoxColumn.Visible = false;
            // 
            // securityStampDataGridViewTextBoxColumn
            // 
            securityStampDataGridViewTextBoxColumn.DataPropertyName = "SecurityStamp";
            securityStampDataGridViewTextBoxColumn.HeaderText = "SecurityStamp";
            securityStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            securityStampDataGridViewTextBoxColumn.Name = "securityStampDataGridViewTextBoxColumn";
            securityStampDataGridViewTextBoxColumn.Visible = false;
            // 
            // concurrencyStampDataGridViewTextBoxColumn
            // 
            concurrencyStampDataGridViewTextBoxColumn.DataPropertyName = "ConcurrencyStamp";
            concurrencyStampDataGridViewTextBoxColumn.HeaderText = "ConcurrencyStamp";
            concurrencyStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            concurrencyStampDataGridViewTextBoxColumn.Name = "concurrencyStampDataGridViewTextBoxColumn";
            concurrencyStampDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // phoneNumberConfirmedDataGridViewCheckBoxColumn
            // 
            phoneNumberConfirmedDataGridViewCheckBoxColumn.DataPropertyName = "PhoneNumberConfirmed";
            phoneNumberConfirmedDataGridViewCheckBoxColumn.HeaderText = "PhoneNumberConfirmed";
            phoneNumberConfirmedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            phoneNumberConfirmedDataGridViewCheckBoxColumn.Name = "phoneNumberConfirmedDataGridViewCheckBoxColumn";
            phoneNumberConfirmedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // twoFactorEnabledDataGridViewCheckBoxColumn
            // 
            twoFactorEnabledDataGridViewCheckBoxColumn.DataPropertyName = "TwoFactorEnabled";
            twoFactorEnabledDataGridViewCheckBoxColumn.HeaderText = "TwoFactorEnabled";
            twoFactorEnabledDataGridViewCheckBoxColumn.MinimumWidth = 6;
            twoFactorEnabledDataGridViewCheckBoxColumn.Name = "twoFactorEnabledDataGridViewCheckBoxColumn";
            twoFactorEnabledDataGridViewCheckBoxColumn.Visible = false;
            // 
            // lockoutEndDataGridViewTextBoxColumn
            // 
            lockoutEndDataGridViewTextBoxColumn.DataPropertyName = "LockoutEnd";
            lockoutEndDataGridViewTextBoxColumn.HeaderText = "LockoutEnd";
            lockoutEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            lockoutEndDataGridViewTextBoxColumn.Name = "lockoutEndDataGridViewTextBoxColumn";
            lockoutEndDataGridViewTextBoxColumn.Visible = false;
            // 
            // lockoutEnabledDataGridViewCheckBoxColumn
            // 
            lockoutEnabledDataGridViewCheckBoxColumn.DataPropertyName = "LockoutEnabled";
            lockoutEnabledDataGridViewCheckBoxColumn.HeaderText = "LockoutEnabled";
            lockoutEnabledDataGridViewCheckBoxColumn.MinimumWidth = 6;
            lockoutEnabledDataGridViewCheckBoxColumn.Name = "lockoutEnabledDataGridViewCheckBoxColumn";
            lockoutEnabledDataGridViewCheckBoxColumn.Visible = false;
            // 
            // accessFailedCountDataGridViewTextBoxColumn
            // 
            accessFailedCountDataGridViewTextBoxColumn.DataPropertyName = "AccessFailedCount";
            accessFailedCountDataGridViewTextBoxColumn.HeaderText = "AccessFailedCount";
            accessFailedCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            accessFailedCountDataGridViewTextBoxColumn.Name = "accessFailedCountDataGridViewTextBoxColumn";
            accessFailedCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Identity.ApplicationUser);
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewUsers);
            Controls.Add(toolStrip1);
            Name = "AdministratorForm";
            Text = "Пользователи";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripButton toolStripButtonRemove;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridView dataGridViewUsers;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn employeeFullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn normalizedUserNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn normalizedEmailDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn emailConfirmedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn securityStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn concurrencyStampDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn phoneNumberConfirmedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn twoFactorEnabledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn lockoutEndDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn lockoutEnabledDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn accessFailedCountDataGridViewTextBoxColumn;
        private ToolStripButton toolStripButton1;
    }
}