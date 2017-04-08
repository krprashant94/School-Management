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
    public partial class getAdmNo : Form
    {
        public getAdmNo()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();
            this.button4.BackColor = th.Silver;
            this.panel1.BackColor = th.Silver;
            this.button4.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button4.FlatAppearance.MouseDownBackColor = th.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = th.Silver;

            this.button1.BackColor = th.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = th.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = th.Silver;
            this.BackColor = th.Main;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fm = new student_bio(textBox1.Text.ToString());
            fm.ShowDialog();
        }
    }
}
