namespace School_Management
{
    partial class FirstRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRun));
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.MaskedTextBox();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selectServer = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pdf_save_path = new System.Windows.Forms.TextBox();
            this.selectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Database";
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.server.ForeColor = System.Drawing.Color.White;
            this.server.Location = new System.Drawing.Point(147, 7);
            this.server.Margin = new System.Windows.Forms.Padding(4);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(237, 24);
            this.server.TabIndex = 1;
            this.server.Click += new System.EventHandler(this.server_Click);
            // 
            // inputUsername
            // 
            this.inputUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.inputUsername.ForeColor = System.Drawing.Color.White;
            this.inputUsername.Location = new System.Drawing.Point(147, 68);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(237, 24);
            this.inputUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // inputPass
            // 
            this.inputPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.inputPass.ForeColor = System.Drawing.Color.White;
            this.inputPass.Location = new System.Drawing.Point(147, 98);
            this.inputPass.Name = "inputPass";
            this.inputPass.Size = new System.Drawing.Size(237, 24);
            this.inputPass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(14, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply and Connect to Database";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectServer
            // 
            this.selectServer.AddExtension = false;
            this.selectServer.DefaultExt = "pkp";
            this.selectServer.Filter = "Prashant Kumar DataBase File  (*.pkp)|*pkp";
            this.selectServer.InitialDirectory = "C:\\Users\\Admin\\Documents";
            this.selectServer.Title = "Select the Path of Server ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Save a Copy of Bill";
            // 
            // pdf_save_path
            // 
            this.pdf_save_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pdf_save_path.ForeColor = System.Drawing.Color.White;
            this.pdf_save_path.Location = new System.Drawing.Point(147, 38);
            this.pdf_save_path.Name = "pdf_save_path";
            this.pdf_save_path.Size = new System.Drawing.Size(237, 24);
            this.pdf_save_path.TabIndex = 2;
            this.pdf_save_path.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department";
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.department.ForeColor = System.Drawing.Color.White;
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "Principal Desk",
            "Accounts",
            "Admission Cell",
            "Examination Cell"});
            this.department.Location = new System.Drawing.Point(147, 129);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(237, 25);
            this.department.TabIndex = 5;
            // 
            // FirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 207);
            this.Controls.Add(this.department);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pdf_save_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirstRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox server;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog selectServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pdf_save_path;
        private System.Windows.Forms.FolderBrowserDialog selectFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox department;
    }
}