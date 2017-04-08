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
    public partial class add_a_exam : Form
    {
        Db db = new Db();
        public add_a_exam()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();
            this.panel1.BackColor = th.DarkGray;

            this.button2.BackColor = th.DarkGray;
            this.button2.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button2.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.button1.BackColor = th.DarkGray;
            this.button1.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button1.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.panel2.BackColor = th.DimGray;
            this.rectangleShape6.BackColor = th.Gray;
            this.rectangleShape5.BackColor = th.Gray;
            this.rectangleShape4.BackColor = th.Gray;
            this.rectangleShape3.BackColor = th.Gray;

            this.rectangleShape2.BackColor = th.Gray;
            this.button3.BackColor = th.DimGray;
            this.comboBox3.BackColor = th.White;
            this.comboBox4.BackColor = th.White;
            this.textBox12.BackColor = th.White;
            this.textBox11.BackColor = th.White;
            this.textBox1.BackColor = th.White;
            this.textBox2.BackColor = th.White;
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

        private void add_a_exam_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerReportsProgress = true;
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string iv_class="", iv_section="", iv_exam="", iv_subject="", iv_fullmarks="", iv_passmarks="";
                this.Invoke(new MethodInvoker(delegate { iv_class = comboBox4.Text.ToString(); }));
                this.Invoke(new MethodInvoker(delegate { iv_section = comboBox3.Text.ToString(); }));
                this.Invoke(new MethodInvoker(delegate { iv_subject = textBox1.Text.ToString(); }));
                this.Invoke(new MethodInvoker(delegate { iv_exam = textBox2.Text.ToString(); }));
                this.Invoke(new MethodInvoker(delegate { iv_fullmarks = textBox11.Text.ToString(); }));
                this.Invoke(new MethodInvoker(delegate { iv_passmarks = textBox12.Text.ToString(); }));


                if (iv_exam.Length > 2 && iv_subject.Length > 2)
                {
                    if (!db.examexist(iv_class, iv_section, iv_exam, iv_subject))
                    {
                        List<List<String>> student_list;
                        student_list = db.getStudent(Int32.Parse(iv_class), iv_section);
                        for (int i = 0; i < student_list.Count; i++)
                        {
                            if (db.newExam(student_list[i][0].ToString(), iv_class, iv_section, iv_exam, iv_subject, iv_fullmarks, iv_passmarks))
                            {
                                backgroundWorker1.ReportProgress(i * 100 / student_list.Count);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exam already added to the database", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Too short input.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            button3.Text = "Updating... " + e.ProgressPercentage.ToString() + "%";

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button3.Text = "Make an Exam";
            textBox1.Text = "";
        }
    }
}
