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
    public partial class report_card : Form
    {
        Db db = new Db();
        private System.Data.OleDb.OleDbDataReader studentInfo;
        private List<List<string>> result;
        public report_card()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.label9.BackColor = th.Main;
            this.richTextBox1.BackColor = th.Main;
            this.textBox16.BackColor = th.Main;
            this.textBox15.BackColor = th.Main;
            this.textBox14.BackColor = th.Main;
            this.textBox13.BackColor = th.Main;
            this.textBox9.BackColor = th.Main;
            this.textBox8.BackColor = th.Main;
            this.textBox7.BackColor = th.Main; 
            this.textBox6.BackColor = th.Main;
            this.textBox5.BackColor = th.Main;


            this.panel1.BackColor = th.Gray;
            this.panel2.BackColor = th.DimGray;

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.CheckedBackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button1.BackColor = th.Gray;
            this.button1.FlatAppearance.CheckedBackColor = th.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = th.Gray;

            this.BackColor = th.Main;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            try
            {
                PrintFormetter p = new PrintFormetter(textBox6.Text.ToString(), textBox5.Text.ToString(), textBox9.Text.ToString(), textBox13.Text.ToString(), textBox7.Text.ToString() + " '" + textBox8.Text.ToString() + "' ", dataGridView2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            loadResult();
        }

        private void textBox13_TextChanged_1(object sender, EventArgs e)
        {
            loadResult();
        }

        public void loadResult()
        {
            int total = 0, pass = 0, obtain = 0;
            dataGridView2.Rows.Clear();
            richTextBox1.Text = "";
            try
            {
                studentInfo = db.studentInfo(textBox6.Text.ToString());
                while (studentInfo.Read())
                {
                    textBox5.Text = studentInfo[1].ToString();
                    textBox7.Text = studentInfo[2].ToString();
                    textBox8.Text = studentInfo[3].ToString();
                    textBox9.Text = studentInfo[4].ToString();
                }


                result = db.getResult(textBox6.Text, textBox13.Text);
                for (int i = 0; i < result.Count; i++)
                {
                    dataGridView2.Rows.Add(result[i][5], result[i][6], result[i][7], result[i][8]);
                    total += Int32.Parse(result[i][6]);
                    pass += Int32.Parse(result[i][7]);
                    obtain += Int32.Parse(result[i][8]);
                    if (Int32.Parse(result[i][8]) < Int32.Parse(result[i][7]))
                    {
                        richTextBox1.Text += "Fail in " + result[i][5] + "\n";
                    }
                }
                textBox14.Text = total.ToString();
                textBox16.Text = pass.ToString();
                textBox15.Text = obtain.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
