namespace School_Management
{
    partial class report_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_card));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.paper_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paper_marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Class";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(420, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Roll No. ";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Brush Script MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(569, 451);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Print";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(22, 378);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(321, 96);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paper_name,
            this.total_marks,
            this.pass_marks,
            this.paper_marks});
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(22, 134);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(582, 238);
            this.dataGridView2.TabIndex = 7;
            // 
            // paper_name
            // 
            this.paper_name.HeaderText = "Subject";
            this.paper_name.Name = "paper_name";
            this.paper_name.Width = 300;
            // 
            // total_marks
            // 
            this.total_marks.HeaderText = "Total Marks";
            this.total_marks.Name = "total_marks";
            this.total_marks.Width = 75;
            // 
            // pass_marks
            // 
            this.pass_marks.HeaderText = "Pass Mark";
            this.pass_marks.Name = "pass_marks";
            this.pass_marks.Width = 75;
            // 
            // paper_marks
            // 
            this.paper_marks.HeaderText = "Marks Obtain";
            this.paper_marks.Name = "paper_marks";
            this.paper_marks.Width = 75;
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.ForeColor = System.Drawing.Color.White;
            this.textBox16.Location = new System.Drawing.Point(440, 375);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(72, 20);
            this.textBox16.TabIndex = 9;
            this.textBox16.Text = " ";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.ForeColor = System.Drawing.Color.White;
            this.textBox15.Location = new System.Drawing.Point(518, 375);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(73, 20);
            this.textBox15.TabIndex = 10;
            this.textBox15.Text = " ";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.ForeColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(360, 375);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(74, 20);
            this.textBox14.TabIndex = 8;
            this.textBox14.Text = " ";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.ForeColor = System.Drawing.Color.White;
            this.textBox13.Location = new System.Drawing.Point(434, 54);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(157, 20);
            this.textBox13.TabIndex = 2;
            this.textBox13.Text = "Exam Name";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged_1);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(508, 108);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(83, 20);
            this.textBox9.TabIndex = 6;
            this.textBox9.Text = " ";
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(129, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(48, 20);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = " ";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(71, 108);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(43, 20);
            this.textBox7.TabIndex = 4;
            this.textBox7.Text = " ";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(22, 81);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 1;
            this.textBox6.Text = "Adm_No";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(22, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(190, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = " ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 40);
            this.panel1.TabIndex = 100;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(575, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(599, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 40);
            this.panel2.TabIndex = 20;
            // 
            // report_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(623, 524);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "report_card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Card";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn paper_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass_marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn paper_marks;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}