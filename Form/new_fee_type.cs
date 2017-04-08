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
    public partial class new_fee_type : Form
    {
        private Db db = new Db();
        public new_fee_type()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.Gray;

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.CheckedBackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button1.BackColor = th.Gray;
            this.button1.FlatAppearance.CheckedBackColor = th.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = th.Gray;

            this.panel2.BackColor = th.Main;
            this.BackColor = th.DarkGray;
            this.SaveNewfeeType.BackColor = th.Main;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SaveNewfeeType_Click(object sender, EventArgs e)
        {
            if (newfeeID.Text.Length != 0 && feeType.Text.Length != 0 && ammount.Text.Length != 0 && cat.Text.Length != 0)
            {
                if (db.addFeetype(newfeeID.Text, feeType.Text, ammount.Text, cat.Text))
                {
                    MessageBox.Show("New Fee Type Added", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Importent fields are empty in this form.", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
