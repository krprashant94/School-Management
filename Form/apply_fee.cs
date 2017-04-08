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
    public partial class apply_fee : Form
    {
        private Db db = new Db();
        private List<string> allFeeID;
        public apply_fee()
        {
            InitializeComponent();
            theam();
            allFeeID = db.getAllFeeID();
            int i;
            for (i = 0; i < allFeeID.Count; i++)
            {
                applyfeeID.Items.Add(allFeeID[i]);
            }
        }
        private void theam()
        {
            TheamPack th = new TheamPack();
            this.panel1.BackColor = th.DarkGray;

            this.button5.BackColor = th.DarkGray;
            this.button5.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button5.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button5.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.button6.BackColor = th.DarkGray;
            this.button6.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button6.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button6.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.panel4.BackColor = th.Main;

            this.applyfeeID.BackColor = th.White;
            this.label12.BackColor = th.DimGray;
            this.applySection.BackColor = th.White;
            this.label11.BackColor = th.DimGray;
            this.label10.BackColor = th.DimGray;
            this.label12.BackColor = th.DimGray;
            this.button1.BackColor = th.Main;
            this.button1.FlatAppearance.BorderColor = th.Main;
            this.button1.FlatAppearance.MouseDownBackColor = th.Main;
            this.button1.FlatAppearance.MouseOverBackColor = th.Main;

            this.applyAdmNo.BackColor = th.White;
            this.applyClass.BackColor = th.White;

            this.rectangleShape2.FillColor = th.DimGray;
            this.rectangleShape3.FillColor = th.DimGray;

            this.BackColor = th.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
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

        private void applyAdmNo_TextChanged(object sender, EventArgs e)
        {
            applyClass.Text = "";
            applySection.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker1.ReportProgress(10);
            string iv_applyAdmNo = "", iv_applyClass = "", iv_applySection = "", iv_applyfeeID = "";
            this.Invoke(new MethodInvoker(delegate { iv_applyClass = applyClass.Text.ToString(); }));
            this.Invoke(new MethodInvoker(delegate { iv_applySection = applySection.Text.ToString(); }));
            this.Invoke(new MethodInvoker(delegate { iv_applyfeeID = applyfeeID.Text.ToString(); }));
            this.Invoke(new MethodInvoker(delegate { iv_applyAdmNo = applyAdmNo.Text.ToString(); }));

            backgroundWorker1.ReportProgress(50);


            if (iv_applyClass.Length != 0 && applySection.Text.Length != 0)
            {
                if (db.addFee(iv_applyClass, iv_applySection, iv_applyfeeID))
                {
                    backgroundWorker1.ReportProgress(100);
                    MessageBox.Show("The fee is sucessfuly applyed to class " + iv_applyClass + " '" + iv_applySection + "'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (iv_applyAdmNo.Length != 0)
            {
                if (db.addFee(iv_applyAdmNo, iv_applyfeeID))
                {
                    backgroundWorker1.ReportProgress(100);
                    MessageBox.Show("The fee is sucessfuly applyed to student " + iv_applyAdmNo + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Importent fields are empty in this form.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            button1.Text = "Updating... " + e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button1.Text = "Save";
        }

        private void applyClass_TextChanged(object sender, EventArgs e)
        {
            applyAdmNo.Text = "";
        }

        private void applySection_TextChanged(object sender, EventArgs e)
        {
            applyAdmNo.Text = "";
        }
    }
}
