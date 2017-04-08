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
    public partial class money_recipt : Form
    {
        private Db db = new Db();
        public money_recipt()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.Gray;
            this.panel3.BackColor = th.Main;

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.CheckedBackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button1.BackColor = th.Gray;
            this.button1.FlatAppearance.CheckedBackColor = th.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button3.BackColor = th.Main;
            this.BackColor = th.DimGray;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!mm_type.Text.ToString().Trim().Equals("") && mm_name.Text.Length > 3 && mm_purpose.Text.Length > 3)
            {
                try
                {
                    char val;
                    string slipNo = db.createRecipt();
                    if (mm_type.Text.Equals("Income"))
                    {
                        val = 'I';
                    }
                    else
                    {
                        val = 'O';
                    }
                    if (db.addExpense(slipNo, mm_name.Text.ToString(), mm_purpose.Text.ToString() + " " + mm_extranote.Text.ToString(), Int32.Parse(mm_amount.Text), val))
                    {
                        PrintFormetter f = new PrintFormetter(mm_name.Text, slipNo, mm_purpose.Text.ToString() + "<br/>( " + mm_extranote.Text.ToString() + " )", Int32.Parse(mm_amount.Text));
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Importent fields are empty in this form.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
