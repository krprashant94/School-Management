namespace School_Management
{
    partial class student_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_list));
            this.spreadsheet = new System.Windows.Forms.DataGridView();
            this.admnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheet
            // 
            this.spreadsheet.AllowUserToAddRows = false;
            this.spreadsheet.AllowUserToDeleteRows = false;
            this.spreadsheet.AllowUserToResizeRows = false;
            this.spreadsheet.BackgroundColor = System.Drawing.Color.White;
            this.spreadsheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spreadsheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admnoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.rollnoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.mobDataGridViewTextBoxColumn});
            this.spreadsheet.Dock = System.Windows.Forms.DockStyle.Top;
            this.spreadsheet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.spreadsheet.GridColor = System.Drawing.Color.Gray;
            this.spreadsheet.Location = new System.Drawing.Point(0, 40);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.Size = new System.Drawing.Size(900, 531);
            this.spreadsheet.TabIndex = 0;
            this.spreadsheet.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.spreadsheet_RowHeaderMouseClick);
            // 
            // admnoDataGridViewTextBoxColumn
            // 
            this.admnoDataGridViewTextBoxColumn.DataPropertyName = "adm_no";
            this.admnoDataGridViewTextBoxColumn.HeaderText = "Admission No";
            this.admnoDataGridViewTextBoxColumn.Name = "admnoDataGridViewTextBoxColumn";
            this.admnoDataGridViewTextBoxColumn.Width = 90;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.Width = 50;
            // 
            // rollnoDataGridViewTextBoxColumn
            // 
            this.rollnoDataGridViewTextBoxColumn.DataPropertyName = "roll_no";
            this.rollnoDataGridViewTextBoxColumn.HeaderText = "Roll No";
            this.rollnoDataGridViewTextBoxColumn.Name = "rollnoDataGridViewTextBoxColumn";
            this.rollnoDataGridViewTextBoxColumn.Width = 50;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "f_name";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Father";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "m_name";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "Mother";
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            // 
            // mobDataGridViewTextBoxColumn
            // 
            this.mobDataGridViewTextBoxColumn.DataPropertyName = "mob";
            this.mobDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobDataGridViewTextBoxColumn.Name = "mobDataGridViewTextBoxColumn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(852, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 40);
            this.button5.TabIndex = 18;
            this.button5.Text = "_";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(876, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 40);
            this.button6.TabIndex = 19;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.progressBar1.Location = new System.Drawing.Point(12, 574);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(876, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // student_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button6;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.spreadsheet);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "student_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView spreadsheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn admnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;


    }
}