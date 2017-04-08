using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace School_Management
{
    public partial class account : Form
    {
        private Db db = new Db();
        private List<List<String>> res;
        private string paymentMonthCondtion;
        private float income;
        private float outgoing;
        private float bankDeposit;
        private float bankWithdrow;
        public account()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.BackColor = th.DarkGray;
            this.panel1.BackColor = th.Gray;
            this.panel2.BackColor = th.Main;

            this.button6.FlatAppearance.CheckedBackColor = th.Gray;
            this.button6.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = th.Gray;
            this.button6.BackColor = th.Gray;

            this.button5.BackColor = th.Gray;
            this.button5.FlatAppearance.CheckedBackColor = th.Gray;
            this.button5.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = th.Gray;

            this.panel2.BackColor = th.Main;
            this.panel3.BackColor = th.Main;
            this.panel4.BackColor = th.Main;

            this.BackColor = th.DarkGray;
        }

        private void paymentMonth_TextChanged(object sender, EventArgs e)
        {
            if (!paymentMonth.Text.Trim().Equals(""))
            {
                updateList(paymentMonth.Text);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateList(dateTimePicker1.Text);
        }

        private void updateList(String condtion)
        {

            paymentMonthCondtion = condtion.ToString();
            dataGridView1.Rows.Clear();

            backgroundWorker1.WorkerReportsProgress = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            income = 0; outgoing = 0; bankDeposit = 0; bankWithdrow = 0;
            
            int i;
            res = db.getAllPayment(paymentMonthCondtion);
            for (i = 0; i < res.Count; i++)
            {
                float rowAmmount = float.Parse(res[i][3]);
                switch (res[i][5])
                {
                    case "I":
                        income += rowAmmount;
                        break;
                    case "O":
                        outgoing += rowAmmount;
                        break;
                    case "D":
                        bankDeposit += rowAmmount;
                        break;
                    case "W":
                        bankWithdrow += rowAmmount;
                        break;
                }
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            int i = e.ProgressPercentage;
            dataGridView1.Rows.Add(res[i][0], res[i][1], res[i][2], res[i][3], res[i][4]);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            label23.Text = income.ToString();
            label22.Text = outgoing.ToString();
            label24.Text = (income - outgoing).ToString();

            label28.Text = bankDeposit.ToString();
            label27.Text = bankWithdrow.ToString();
            label29.Text = (bankDeposit - bankWithdrow).ToString();
        }
    }
}
