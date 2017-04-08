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
    public partial class send_money_to_bank : Form
    {
        private Db db = new Db();
        public send_money_to_bank()
        {
            InitializeComponent();
            theam();
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

            this.panel2.BackColor = th.Main;
            this.button4.BackColor = th.Main;
            this.BackColor = th.DimGray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!bank_type.Text.ToString().Trim().Equals("") && bank_depoName.Text.Length > 3 && bank_acc.Text.Length > 2)
            {
                try
                {
                    char val;
                    string slipNo = db.createRecipt();
                    if (bank_type.Text.Equals("Deposit"))
                    {
                        val = 'D';
                    }
                    else
                    {
                        val = 'W';
                    }
                    if (db.addExpense(slipNo, bank_depoName.Text.ToString(), bank_acc.Text.ToString() + " " + bank_extranote.Text.ToString(), Int32.Parse(bank_amount.Text), val))
                    {
                        MessageBox.Show("Operation Successfully Done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
