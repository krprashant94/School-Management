using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace School_Management
{
    public partial class student_bio : Form
    {
        private String adm_no;
        private String[] due_list;
        private OleDbDataReader res;
        private Db db = new Db();
        private MemoryStream stream;
        private byte[] bimg;
        private List<String> fee_details;
        private float total_due;
        private Form f;

        public student_bio(String adm_no_get)
        {
            InitializeComponent();
            theam();
            adm_no = adm_no_get;
            res = db.studentInfo(adm_no);
            while (res.Read())
            {
                admms.Text = res[0].ToString();
                name.Text = res[1].ToString();
                clas.Text = res[2].ToString();
                section.Text = res[3].ToString();
                roll_no.Text = res[4].ToString();
                address.Text = res[5].ToString();
                f_name.Text = res[6].ToString();
                m_name.Text = res[7].ToString();
                ph.Text = res[8].ToString();
                dob.Text = res[9].ToString();
                doa.Text = res[10].ToString();
                bloodGrp.Text = res[13].ToString();
                gander.Text = res[14].ToString();
                textBox3.Text = res[15].ToString();
                textBox2.Text = res[16].ToString();
                richTextBox1.Text = res[17].ToString();
                textBox1.Text = res[18].ToString();
                try
                {
                    bimg = (byte[])res[11];
                    stream = new MemoryStream(bimg);
                    photo.Image = Image.FromStream(stream);
                }
                catch (Exception)
                {

                }
                int i = 0;
                if (!String.IsNullOrEmpty(res[12].ToString()))
                {
                    due_list = res[12].ToString().Split(',');
                    total_due = 0;
                    try
                    {
                        for (i = 0; i < due_list.Length; i++)
                        {
                            fee_details = db.getFeeDetails(due_list[i]);
                            fee_balance.Rows.Add(fee_details[0], fee_details[1], fee_details[2]);
                            total_due += Int64.Parse(fee_details[2].ToString());
                        }
                        total.Text = total_due.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.ph.BackColor = th.DarkGray;
            this.address.BackColor = th.DarkGray;
            this.clas.BackColor = th.DarkGray;
            this.section.BackColor = th.DarkGray;
            this.roll_no.BackColor = th.DarkGray;
            this.f_name.BackColor = th.DarkGray;
            this.m_name.BackColor = th.DarkGray;
            this.dob.BackColor = th.DarkGray;
            this.doa.BackColor = th.DarkGray;
            this.bloodGrp.BackColor = th.DarkGray;
            this.gander.BackColor = th.DarkGray;

            this.button2.BackColor = th.DarkGray;
            this.button2.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button2.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.button1.BackColor = th.DarkGray;
            this.button1.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button1.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.textBox1.BackColor = th.DarkGray;
            this.textBox2.BackColor = th.DarkGray;
            this.textBox3.BackColor = th.DarkGray;
            this.richTextBox1.BackColor = th.DarkGray;
            this.BackColor = th.DarkGray;
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f = new fee_payment(adm_no, due_list);
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("No any due avelabe", "Due Not Avelable", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new fee_history(adm_no);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            f = new student_bio(adm_no);
            f.ShowDialog();
        }
    }
}
