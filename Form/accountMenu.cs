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
    public partial class accountMenu : Form
    {
        private Form fm;
        public accountMenu()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();
            this.panel1.BackColor = th.DimGray;
            this.panel2.BackColor = th.DimGray;
            this.button5.BackColor = th.DimGray;

            this.button5.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button5.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button5.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.button6.BackColor = th.DimGray;
            this.button6.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button6.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button6.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.panel3.BackColor = th.DimGray;
            this.button1.BackColor = th.Main;
            this.panel4.BackColor = th.DimGray;
            this.button2.BackColor = th.Main;
            this.panel5.BackColor = th.DimGray;
            this.button3.BackColor = th.Main;
            this.panel6.BackColor = th.DimGray;
            this.button4.BackColor = th.Main;
            this.panel7.BackColor = th.DimGray;
            this.button7.BackColor = th.Main;
            this.panel8.BackColor = th.DimGray;
            this.button8.BackColor = th.Main;
            this.button9.BackColor = th.Main;
            this.BackColor = th.Gray;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm = new new_fee_type();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm = new apply_fee();
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fm = new money_recipt();
            fm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fm = new send_money_to_bank();
            fm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fm = new account();
            fm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fm = new getAdmNo();
            fm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fm = new payToTeacher();
            fm.ShowDialog();
        }
    }
}
