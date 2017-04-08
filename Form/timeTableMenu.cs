using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School_Management
{
    public partial class timeTableMenu : Form
    {
        private Form fm;
        public timeTableMenu()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.DimGray;
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
            this.panel2.BackColor = th.DimGray;
            this.button2.BackColor = th.Main;
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
            fm = new timeTable();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm = new timeTable();
            fm.Show();
        }
    }
}
