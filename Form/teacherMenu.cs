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
    public partial class teacherMenu : Form
    {
        Form fm;
        public teacherMenu()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.button3.BackColor = th.Main;
            this.button2.BackColor = th.Main;
            this.button1.BackColor = th.Main;

            this.button6.BackColor = th.DimGray;
            this.button6.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button6.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button6.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.button5.BackColor = th.DimGray;
            this.button5.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button5.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button5.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.panel3.BackColor = th.DimGray;
            this.panel4.BackColor = th.DimGray;
            this.panel5.BackColor = th.DimGray;
            this.panel1.BackColor = th.DimGray;
            this.panel2.BackColor = th.DimGray;

            this.BackColor = th.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm = new teacher();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fm = new addTeacher();
            fm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fm = new payToTeacher();
            fm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
