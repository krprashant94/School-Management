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
    public partial class addTeacher : Form
    {
        private Db db = new Db();
        public addTeacher()
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
            this.button1.BackColor = th.Main;
            this.panel2.BackColor = th.Main;
            this.rectangleShape5.BackColor = th.Gray;
            this.rectangleShape4.BackColor = th.Gray;
            this.rectangleShape3.BackColor = th.Gray;
            this.rectangleShape2.BackColor = th.Gray;
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
            try
            {
                if (textBox1.Text.Length > 3 && textBox2.Text.Length > 3 && textBox3.Text.Length > 9 && textBox4.Text.Length > 3 && richTextBox1.Text.Length > 5)
                {
                    if (db.addTeacher(textBox1.Text, textBox2.Text, textBox3.Text, richTextBox1.Text, textBox4.Text,aadhar_no.Text, checkBox1.Checked))
                    {
                        MessageBox.Show("Teacher's details has been added to database", "Sucess", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill the entire field as per instruction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Warning", MessageBoxButtons.OK);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Text = "Save Details";
            }
            else
            {
                button1.Text = "Add New Teacher";
            }
        }
    }
}
