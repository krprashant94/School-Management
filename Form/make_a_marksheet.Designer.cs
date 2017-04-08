namespace School_Management
{
    partial class make_a_marksheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(make_a_marksheet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.inputSection = new System.Windows.Forms.ComboBox();
            this.InputClass = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inputSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputExam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.markSheet = new System.Windows.Forms.DataGridView();
            this.roll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 40);
            this.panel1.TabIndex = 100;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.minimizeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(660, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 40);
            this.minimizeBtn.TabIndex = 7;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(684, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 40);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.inputSection);
            this.panel2.Controls.Add(this.InputClass);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.inputSubject);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.inputExam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 460);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update Marksheet";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "Section";
            // 
            // inputSection
            // 
            this.inputSection.BackColor = System.Drawing.Color.White;
            this.inputSection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputSection.ForeColor = System.Drawing.Color.Black;
            this.inputSection.FormattingEnabled = true;
            this.inputSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.inputSection.Location = new System.Drawing.Point(29, 146);
            this.inputSection.Name = "inputSection";
            this.inputSection.Size = new System.Drawing.Size(172, 28);
            this.inputSection.TabIndex = 2;
            // 
            // InputClass
            // 
            this.InputClass.BackColor = System.Drawing.Color.White;
            this.InputClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputClass.ForeColor = System.Drawing.Color.Black;
            this.InputClass.FormattingEnabled = true;
            this.InputClass.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.InputClass.Location = new System.Drawing.Point(29, 63);
            this.InputClass.Name = "InputClass";
            this.InputClass.Size = new System.Drawing.Size(172, 28);
            this.InputClass.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "Class";
            // 
            // inputSubject
            // 
            this.inputSubject.BackColor = System.Drawing.Color.White;
            this.inputSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSubject.ForeColor = System.Drawing.Color.Black;
            this.inputSubject.Location = new System.Drawing.Point(29, 314);
            this.inputSubject.Name = "inputSubject";
            this.inputSubject.Size = new System.Drawing.Size(172, 20);
            this.inputSubject.TabIndex = 4;
            this.inputSubject.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Subject";
            // 
            // inputExam
            // 
            this.inputExam.BackColor = System.Drawing.Color.White;
            this.inputExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputExam.ForeColor = System.Drawing.Color.Black;
            this.inputExam.Location = new System.Drawing.Point(29, 232);
            this.inputExam.Name = "inputExam";
            this.inputExam.Size = new System.Drawing.Size(172, 20);
            this.inputExam.TabIndex = 3;
            this.inputExam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Exam";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape4,
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(220, 460);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rectangleShape4.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape4.BorderWidth = 2;
            this.rectangleShape4.CornerRadius = 5;
            this.rectangleShape4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape4.FillColor = System.Drawing.Color.White;
            this.rectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape4.Location = new System.Drawing.Point(22, 304);
            this.rectangleShape4.Name = "rectangleShape1";
            this.rectangleShape4.Size = new System.Drawing.Size(188, 39);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rectangleShape3.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape3.BorderWidth = 2;
            this.rectangleShape3.CornerRadius = 5;
            this.rectangleShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape3.FillColor = System.Drawing.Color.White;
            this.rectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape3.Location = new System.Drawing.Point(20, 222);
            this.rectangleShape3.Name = "rectangleShape1";
            this.rectangleShape3.Size = new System.Drawing.Size(188, 39);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rectangleShape2.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.CornerRadius = 5;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape2.FillColor = System.Drawing.Color.White;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(20, 140);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.Size = new System.Drawing.Size(188, 39);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.FillColor = System.Drawing.Color.White;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(21, 57);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(188, 39);
            // 
            // markSheet
            // 
            this.markSheet.BackgroundColor = System.Drawing.Color.White;
            this.markSheet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.markSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roll,
            this.marks});
            this.markSheet.Dock = System.Windows.Forms.DockStyle.Right;
            this.markSheet.GridColor = System.Drawing.Color.Black;
            this.markSheet.Location = new System.Drawing.Point(220, 40);
            this.markSheet.Name = "markSheet";
            this.markSheet.Size = new System.Drawing.Size(488, 420);
            this.markSheet.TabIndex = 50;
            // 
            // roll
            // 
            this.roll.HeaderText = "Admission No";
            this.roll.Name = "roll";
            this.roll.Width = 200;
            // 
            // marks
            // 
            this.marks.HeaderText = "Marks";
            this.marks.Name = "marks";
            this.marks.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(220, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 40);
            this.panel4.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // make_a_marksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(708, 500);
            this.Controls.Add(this.markSheet);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "make_a_marksheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marksheet Creator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView markSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn roll;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox inputSection;
        private System.Windows.Forms.ComboBox InputClass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox inputSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputExam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}