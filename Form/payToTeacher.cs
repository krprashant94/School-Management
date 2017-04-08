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
    public partial class payToTeacher : Form
    {
        private Db db = new Db();
        private List<List<string>> allTeacher;
        public payToTeacher()
        {
            InitializeComponent();
            allTeacher = db.getAllTeacher();
            int i;
            for (i = 0; i < allTeacher.Count; i++)
            {
                comboBox2.Items.Add(allTeacher[i][0]);
            }
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.Gray;
            this.panel2.BackColor = th.DimGray;

            this.button5.BackColor = th.Gray;
            this.button5.FlatAppearance.CheckedBackColor = th.Gray;
            this.button5.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button6.BackColor = th.Gray;
            this.button6.FlatAppearance.CheckedBackColor = th.Gray;
            this.button6.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button2.BackColor = th.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = th.Silver;

            this.BackColor = th.Main;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!comboBox2.Text.Equals("") && !monthYear.Text.Equals("") && textBox5.Text.Length > 0)
            {
                try
                {
                    string recipt = db.createRecipt();
                    if (db.addExpense(recipt, comboBox2.Text + " (Teacher)", "Salary Payed for Month " + monthYear.Text.ToString(), Int32.Parse(textBox5.Text), 'O'))
                    {
                        PrintFormetter f = new PrintFormetter(comboBox2.Text + " (Teacher)", recipt, "Salary Payed for Month " + monthYear.Text.ToString(), Int32.Parse(textBox5.Text));
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
