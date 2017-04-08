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
    public partial class exam : Form
    {
        public exam()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.DimGray;
            this.panel2.BackColor = th.Gray;
            this.panel3.BackColor = th.Gray;
            this.panel4.BackColor = th.Gray;
            this.panel5.BackColor = th.Gray;
            this.panel6.BackColor = th.DimGray;

            this.button3.BackColor = th.Main;
            this.button5.BackColor = th.Main;
            this.button6.BackColor = th.Main;
            this.button7.BackColor = th.Main;


            this.button2.BackColor = th.DimGray;
            this.button2.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.button4.BackColor = th.DimGray;
            this.button4.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button4.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button4.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.BackColor = th.DarkGray;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form fm = new add_a_exam();
            fm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form fm = new list_of_exam();
            fm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form fm = new make_a_marksheet();
            fm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form fm = new report_card();
            fm.ShowDialog();
        }
    }
}
