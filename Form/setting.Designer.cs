namespace School_Management
{
    partial class setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.server = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectServer = new System.Windows.Forms.Button();
            this.selectServer = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cuTheam = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(7, 27);
            this.server.Margin = new System.Windows.Forms.Padding(5);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(276, 27);
            this.server.TabIndex = 1;
            this.server.Click += new System.EventHandler(this.server_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataBase";
            // 
            // connectServer
            // 
            this.connectServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectServer.ForeColor = System.Drawing.Color.White;
            this.connectServer.Location = new System.Drawing.Point(186, 61);
            this.connectServer.Name = "connectServer";
            this.connectServer.Size = new System.Drawing.Size(98, 34);
            this.connectServer.TabIndex = 2;
            this.connectServer.Text = "Connect";
            this.connectServer.UseVisualStyleBackColor = false;
            this.connectServer.Click += new System.EventHandler(this.connectServer_Click);
            // 
            // selectServer
            // 
            this.selectServer.AddExtension = false;
            this.selectServer.DefaultExt = "pkp";
            this.selectServer.Filter = "Prashant Kumar DataBase File  (*.pkp)|*pkp";
            this.selectServer.InitialDirectory = "C:\\Users\\Admin\\Documents";
            this.selectServer.Title = "Select the Path of Server ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admission Fee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 27);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 27);
            this.textBox3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(196, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "New Password";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 27);
            this.textBox4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Change Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID";
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(195, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Printer";
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(11, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Printer Setting";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Save Bills in Folder";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(5, 27);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(279, 27);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(195, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.connectServer);
            this.panel1.Controls.Add(this.server);
            this.panel1.Location = new System.Drawing.Point(9, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 101);
            this.panel1.TabIndex = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.maskedTextBox1);
            this.panel2.Location = new System.Drawing.Point(309, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 101);
            this.panel2.TabIndex = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(612, 40);
            this.panel3.TabIndex = 1000;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(210, 40);
            this.label17.TabIndex = 19;
            this.label17.Text = "Setting";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(564, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 40);
            this.button5.TabIndex = 16;
            this.button5.Text = "_";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(588, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 40);
            this.button6.TabIndex = 17;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Location = new System.Drawing.Point(9, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 168);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Location = new System.Drawing.Point(9, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 101);
            this.panel5.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Location = new System.Drawing.Point(9, 433);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(294, 71);
            this.panel6.TabIndex = 150;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cuTheam);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.button7);
            this.panel7.Location = new System.Drawing.Point(309, 153);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(295, 101);
            this.panel7.TabIndex = 250;
            // 
            // cuTheam
            // 
            this.cuTheam.BackColor = System.Drawing.Color.White;
            this.cuTheam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuTheam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuTheam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuTheam.FormattingEnabled = true;
            this.cuTheam.Items.AddRange(new object[] {
            "Black",
            "Purple",
            "Green",
            "Teal",
            "Maroon"});
            this.cuTheam.Location = new System.Drawing.Point(7, 28);
            this.cuTheam.Name = "cuTheam";
            this.cuTheam.Size = new System.Drawing.Size(276, 28);
            this.cuTheam.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Theam Colour";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(195, 62);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 512);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(612, 512);
            this.MinimumSize = new System.Drawing.Size(612, 512);
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectServer;
        private System.Windows.Forms.OpenFileDialog selectServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cuTheam;
    }
}