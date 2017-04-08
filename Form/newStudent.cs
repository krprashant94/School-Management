using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management
{
    public partial class newStudent : Form
    {
        private Db db = new Db();
        public newStudent()
        {
            InitializeComponent();
            panel4.Hide();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();
            this.save.BackColor = th.Main;
            this.save.FlatAppearance.MouseDownBackColor = th.Main;
            this.save.FlatAppearance.MouseOverBackColor = th.Main;
            this.checkBox1.BackColor = th.Main;

            this.button1.BackColor = th.Gray;
            this.button1.FlatAppearance.CheckedBackColor = th.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = th.Gray;

            this.BackColor = th.Gray;

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.CheckedBackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;
        }
        private void photo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    photo.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Image Formet Not Supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (adm_no.Text.Length <= 3)
                {
                    MessageBox.Show("You are entered a wrong Admission Number\nPlease Enter a valid Admission Number as per school standerd", "Error in Admission Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (full_name.Text.Length <= 5)
                {
                    MessageBox.Show("You are entered too short student name, It seems like there is no any name.\nPlease write the full name of the student", "Error in Student Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ph.Text.Length == 10)
                {
                    MessageBox.Show("Contact Number Must be 10 digit Mobile Number", "Error in Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Int32.Parse(clas.Text) < 0 || Int32.Parse(clas.Text) > 10)
                {
                    MessageBox.Show("Class Must be between 0 (Nursury) to 10", "Error in Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /*
            else if (!section.Text.Equals('A') || !section.Text.Equals('B') || !section.Text.Equals('C') || !section.Text.Equals('D') || !section.Text.Equals('E'))
            {
                MessageBox.Show("Section must be A, B, C, D, E", "Error in Section", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (photo.Image.Equals(""))
            {
                MessageBox.Show("You could not uploded any photo of the student.", "Error in Photo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
                else
                {
                    clas.Mask = null;
                    ph.Mask = null;
                    db.addStudent(adm_no.Text.ToString(), full_name.Text.ToString(), clas.Text.ToString(), section.Text.ToString(), roll_no.Text.ToString(), address.Text.ToString(), f_name.Text.ToString(), m_name.Text.ToString(), ph.Text.ToString(), dob.Text.ToString(), doa.Text.ToString(), openFileDialog1.FileName, bloodgroup.Text.ToString(), gander.Text.ToString(), checkBox1.Checked, aadhar_no.Text.ToString(), prev_school_name.Text.ToString(), prev_school_address.Text.ToString(), prev_school_SLC.Text.ToString());
                    
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong Class of the student", "Error in Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unexpacted Error\n"+exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ph.Mask = "(000)-000-0000";
                clas.Mask = "00";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                save.Text = "Update";
            else
                save.Text = "Save";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            panel4.Show();
            prev_school_name.Focus();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            panel4.Hide();
            textBox2.Text = prev_school_name.Text + ", " + prev_school_address.Text + ", " + prev_school_SLC.Text;
        }
    }
}
