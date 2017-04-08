using System.Collections.Generic;
using System.Windows.Forms;


namespace School_Management
{
    public partial class student_list : Form
    {
        private Db db = new Db();
        private Form f;
        private DataGridViewRow row;
        private List<List<string>> res;
        private int clas;
        public student_list(int clas)
        {
            InitializeComponent();
            theam();

            this.clas = clas;
            backgroundWorker1.WorkerReportsProgress = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();


            this.panel1.BackColor = th.Gray;
            this.button5.BackColor = th.Gray;
            this.button5.FlatAppearance.CheckedBackColor = th.Gray;
            this.button5.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = th.Gray;
            this.button6.BackColor = th.Gray;
            this.button6.FlatAppearance.CheckedBackColor = th.Gray;
            this.button6.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = th.Gray;
            this.BackColor = th.DarkGray;

        }

        private void student_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            f = new student();
            f.Show();
        }

        private void spreadsheet_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = spreadsheet.Rows[e.RowIndex];
            f = new student_bio(row.Cells[0].Value.ToString());
            f.ShowDialog();
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                this.Close();
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            res = db.getStudent(clas);
            for (int i = 0; i < res.Count; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;
            progressBar1.Value = (i*100)/res.Count;
            spreadsheet.Rows.Add(res[i][0], res[i][1], res[i][2], res[i][3], res[i][4], res[i][5], res[i][6], res[i][7], res[i][8]);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
        }
    }
}
