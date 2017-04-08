using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace School_Management
{
    public partial class student : Form
    {
        Db db = new Db();
        private Form f;
        private int backgroundCount;
        public student()
        {
            InitializeComponent();
            theam();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.zero.BackColor = th.Gray;
            this.one.BackColor = th.Gray;
            this.two.BackColor = th.Gray;
            this.three.BackColor = th.Gray;
            this.four.BackColor = th.Gray;
            this.five.BackColor = th.Gray;
            this.six.BackColor = th.Gray;
            this.seven.BackColor = th.Gray;
            this.eight.BackColor = th.Gray;
            this.nine.BackColor = th.Gray;
            this.ten.BackColor = th.Gray;

            this.button5.BackColor = th.Gray;
            this.button5.FlatAppearance.CheckedBackColor = th.Gray;
            this.button5.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = th.Gray;
            this.button6.BackColor = th.Gray;
            this.button6.FlatAppearance.CheckedBackColor = th.Gray;
            this.button6.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = th.Gray;

            this.panel1.BackColor = th.Gray;
            this.panel2.BackColor = th.DarkGray;
            this.panel3.BackColor = th.Main;
            this.panel4.BackColor = th.Main;
            this.BackColor = th.DarkGray;
        }
        private void zero_Click(object sender, EventArgs e)
        {
            f = new student_list(0);
            f.Show();
        }

        private void one_Click(object sender, EventArgs e)
        {
            f = new student_list(1);
            f.Show();
        }

        private void two_Click(object sender, EventArgs e)
        {
            f = new student_list(2);
            f.Show();
        }

        private void three_Click(object sender, EventArgs e)
        {
            f = new student_list(3);
            f.Show();
        }

        private void four_Click(object sender, EventArgs e)
        {
            f = new student_list(4);
            f.Show();
        }

        private void five_Click(object sender, EventArgs e)
        {
            f = new student_list(5);
            f.Show();
        }

        private void six_Click(object sender, EventArgs e)
        {
            f = new student_list(6);
            f.Show();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            f = new student_list(7);
            f.Show();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            f = new student_list(8);
            f.Show();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Form f = new student_list(9);
            f.Show();
        }

        private void ten_Click(object sender, EventArgs e)
        {
            Form f = new student_list(10);
            f.Show();
        }

        private void student_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                backgroundCount = db.getCount(i);
                backgroundWorker1.ReportProgress(i);
            }
            backgroundCount = db.getCount("M");
            backgroundWorker1.ReportProgress(11);
            backgroundCount = db.getCount("F");
            backgroundWorker1.ReportProgress(12);
            backgroundCount = (db.getCount("M") + db.getCount("F"));
            backgroundWorker1.ReportProgress(13);
            backgroundCount = (db.getCount("M") + db.getCount("F") - db.getCount());
            backgroundWorker1.ReportProgress(14);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int p = e.ProgressPercentage;
            try
            {
                switch (p)
                {
                    case 0:
                        label17.Text = backgroundCount.ToString();
                        break;
                    case 1:
                        label18.Text = backgroundCount.ToString();
                        break;
                    case 2:
                        label19.Text = backgroundCount.ToString();
                        break;
                    case 3:
                        label20.Text = backgroundCount.ToString();
                        break;
                    case 4:
                        label21.Text = backgroundCount.ToString();
                        break;
                    case 5:
                        label22.Text = backgroundCount.ToString();
                        break;
                    case 6:
                        label23.Text = backgroundCount.ToString();
                        break;
                    case 7:
                        label24.Text = backgroundCount.ToString();
                        break;
                    case 8:
                        label25.Text = backgroundCount.ToString();
                        break;
                    case 9:
                        label26.Text = backgroundCount.ToString();
                        break;
                    case 10:
                        label27.Text = backgroundCount.ToString();
                        break;
                    case 11:
                        label28.Text = backgroundCount.ToString();
                        break;
                    case 12:
                        label29.Text = backgroundCount.ToString();
                        break;
                    case 13:
                        label30.Text = backgroundCount.ToString();
                        break;
                    case 14:
                        label31.Text = backgroundCount.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
