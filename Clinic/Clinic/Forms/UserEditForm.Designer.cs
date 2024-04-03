namespace Clinic.Forms
{
    partial class UserEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            panel2 = new Panel();
            listView1 = new ListView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 447);
            panel2.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(12, 217);
            listView1.Name = "listView1";
            listView1.Size = new Size(613, 206);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 30);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 8;
            label4.Text = "Выберите сотрудника:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 159);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 7;
            label3.Text = "Повторите пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 6;
            label2.Text = "Введите пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите логин:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 152);
            textBox3.MaxLength = 50;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(443, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 119);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(443, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 86);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 27);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "М", "Ж" });
            comboBox1.Location = new Point(182, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(443, 28);
            comboBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 54);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(502, 13);
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
            button1.Location = new Point(361, 13);
            button1.Name = "button1";
            button1.Size = new Size(123, 29);
            button1.TabIndex = 0;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_ClickAsync;
            // 
            // UserEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 501);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserEditForm";
            Text = "Пользователь";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private ListView listView1;
    }
}