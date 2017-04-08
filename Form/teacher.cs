using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class teacher : Form
    {
        private List<List<String>> allTeacher;
        private Db db = new Db();
        public teacher()
        {
            InitializeComponent();
            theam();
            allTeacher = db.getAllTeacher();

            backgroundWorker1.WorkerReportsProgress = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel2.BackColor = th.Gray;
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
        private void button6_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int i;
            for (i = 0; i < allTeacher.Count; i++)
            {
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;
            dataGridView1.Rows.Add(allTeacher[i][0], allTeacher[i][1], allTeacher[i][2]);
        }
    }
}
