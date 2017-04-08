using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class fee_payment : Form
    {
        private String adm_no;
        private String[] due_list;
        private List<String> due_details;
        private List<String> payment_list = new List<String>();
        private Db db = new Db();
        private String timestamp;

        public fee_payment(String adm_no_get,String[] due_list_get)
        {
            InitializeComponent();
            theam();
            adm_no = adm_no_get;
            due_list = due_list_get;
            int i;
            for (i = 0; i < due_list.Length; i++)
            {
                due_details = db.getFeeDetails(due_list[i]);
                dueFeeList.Items.Add("₹ " + due_details[2] + " for " + due_details[1] + " #" + due_details[0]);
            }
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.DimGray;

            this.dueFeeList.BackColor = th.Main;

            this.label1.BackColor = th.DimGray;
            this.label2.BackColor = th.DimGray;

            this.feePaymentButton.BackColor = th.Main;
            this.feePaymentButton.FlatAppearance.MouseDownBackColor = th.Gray;
            this.feePaymentButton.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button2.BackColor = th.DarkGray;
            this.button2.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button2.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.button1.BackColor = th.DarkGray;
            this.button1.FlatAppearance.CheckedBackColor = th.DarkGray;
            this.button1.FlatAppearance.MouseDownBackColor = th.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = th.DarkGray;

            this.BackColor = th.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            String[] item_id = null;
            String tmp;
            timestamp = db.createRecipt();
            for (i = 0; i <= dueFeeList.CheckedItems.Count - 1; i++)
            {
                tmp = dueFeeList.CheckedItems[i].ToString();
                item_id =  tmp.Split('#');
                payment_list.Add(item_id[1]);
            }
            if (payment_list.Count != 0)
            {
                if (db.feePay(payment_list, adm_no, timestamp))
                {
                    PrintFormetter f = new PrintFormetter(adm_no, dueFeeList.CheckedItems, timestamp);
                }
                else
                {
                    MessageBox.Show("Transition Failuer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            payment_list.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
