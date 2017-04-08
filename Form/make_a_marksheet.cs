using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School_Management
{
    public partial class make_a_marksheet : Form
    {
        Db db = new Db();
        private List<List<string>> marksheetStudentList;
        public make_a_marksheet()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.Gray;

            this.minimizeBtn.BackColor = th.Gray;
            this.minimizeBtn.FlatAppearance.CheckedBackColor = th.Gray;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = th.Gray;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = th.Gray;

            this.closeBtn.BackColor = th.Gray;
            this.closeBtn.FlatAppearance.CheckedBackColor = th.Gray;
            this.closeBtn.FlatAppearance.MouseDownBackColor = th.Gray;
            this.closeBtn.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button3.BackColor = th.Main;
            this.BackColor = th.Main;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker1.WorkerReportsProgress = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            loadStudentlist(inputExam.Text, inputSubject.Text, InputClass.Text, inputSection.Text);
        }

        private void loadStudentlist(string exam, string subject, string clas, string sec)
        {
            markSheet.Rows.Clear();
            marksheetStudentList = db.getStudentInExam(exam, subject, clas, sec);
            for (int i = 0; i < marksheetStudentList.Count; i++)
            {
                markSheet.Rows.Add(marksheetStudentList[i][0], marksheetStudentList[i][1]);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string adm_no;
                string mark;
                string paper="";
                string exam="";

                this.Invoke(new MethodInvoker(delegate { exam = this.inputExam.Text.ToString(); }));
                this.Invoke(new MethodInvoker(delegate { paper = this.inputSubject.Text.ToString(); }));

                for (int rows = 0; rows < markSheet.Rows.Count - 1; rows++)
                {
                    adm_no = (markSheet.Rows[rows].Cells[0].Value.ToString());
                    mark = (markSheet.Rows[rows].Cells[1].Value.ToString());
                    db.addMarkSheet(mark, adm_no, paper, exam);
                    int percentage = (rows * 100) / markSheet.Rows.Count;
                    backgroundWorker1.ReportProgress(percentage);
                }
                MessageBox.Show("Successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                backgroundWorker1.ReportProgress(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            button3.Text = "Updating... " + e.ProgressPercentage.ToString()+"%" ;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button3.Text = "Update Marksheet";
        }
    }
}
