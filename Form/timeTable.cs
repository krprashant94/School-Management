using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace School_Management
{
    public partial class timeTable : Form
    {
        Db db = new Db();
        public timeTable()
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

            this.button3.BackColor = th.Gray;
            this.button3.FlatAppearance.CheckedBackColor = th.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = th.Gray;

            this.BackColor = th.Main;
        }
        public timeTable(String inputClas, String inputSec)
        {
            InitializeComponent();
            clas.Text = inputClas;
            sec.Text = inputSec;
            this.Hide();
            setTimetable(inputClas + inputSec);
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!clas.Text.ToString().Equals("") && !sec.Text.ToString().Equals(""))
            {
                try
                {
                    setTimetable(clas.Text + sec.Text);
                }
                catch (Exception ex)
                {
                    try
                    {
                        db.createtimeTable(clas.Text + sec.Text);
                        MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Error : " + exp.Message, "Unexpacted Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void setTimetable(string inputClass)
        {
            int i=0;
            List<List<String>> res = db.getTimeTable(inputClass);
            if (res.Count == 0) { throw new Exception("The time table is not available for selected class. School Management is automatically attempted to create the time table please retry again."); }
            for (i = 0; i < 6; i++)
            {
                String[] list = res[i][0].ToString().Split(',');
                if (list[0].Equals((clas.Text+sec.Text).ToString()))
                {
                    try
                    {
                        switch (list[1])
                        {
                            case "1":
                                MO1.Text = res[i][1].ToString();
                                MO2.Text = res[i][2].ToString();
                                MO3.Text = res[i][3].ToString();
                                MO4.Text = res[i][4].ToString();
                                MO5.Text = res[i][5].ToString();
                                MO6.Text = res[i][6].ToString();
                                MO7.Text = res[i][7].ToString();
                                MO8.Text = res[i][8].ToString();
                                MO9.Text = res[i][9].ToString();
                                break;
                            case "2":
                                TU1.Text = res[i][1].ToString();
                                TU2.Text = res[i][2].ToString();
                                TU3.Text = res[i][3].ToString();
                                TU4.Text = res[i][4].ToString();
                                TU5.Text = res[i][5].ToString();
                                TU6.Text = res[i][6].ToString();
                                TU7.Text = res[i][7].ToString();
                                TU8.Text = res[i][8].ToString();
                                TU9.Text = res[i][9].ToString();
                                break;
                            case "3":
                                WE1.Text = res[i][1].ToString();
                                WE2.Text = res[i][2].ToString();
                                WE3.Text = res[i][3].ToString();
                                WE4.Text = res[i][4].ToString();
                                WE5.Text = res[i][5].ToString();
                                WE6.Text = res[i][6].ToString();
                                WE7.Text = res[i][7].ToString();
                                WE8.Text = res[i][8].ToString();
                                WE9.Text = res[i][9].ToString();
                                break;
                            case "4":
                                TH1.Text = res[i][1].ToString();
                                TH2.Text = res[i][2].ToString();
                                TH3.Text = res[i][3].ToString();
                                TH4.Text = res[i][4].ToString();
                                TH5.Text = res[i][5].ToString();
                                TH6.Text = res[i][6].ToString();
                                TH7.Text = res[i][7].ToString();
                                TH8.Text = res[i][8].ToString();
                                TH9.Text = res[i][9].ToString();
                                break;
                            case "5":
                                FR1.Text = res[i][1].ToString();
                                FR2.Text = res[i][2].ToString();
                                FR3.Text = res[i][3].ToString();
                                FR4.Text = res[i][4].ToString();
                                FR5.Text = res[i][5].ToString();
                                FR6.Text = res[i][6].ToString();
                                FR7.Text = res[i][7].ToString();
                                FR8.Text = res[i][8].ToString();
                                FR9.Text = res[i][9].ToString();
                                break;
                            case "6":
                                SA1.Text = res[i][1].ToString();
                                SA2.Text = res[i][2].ToString();
                                SA3.Text = res[i][3].ToString();
                                SA4.Text = res[i][4].ToString();
                                SA5.Text = res[i][5].ToString();
                                SA6.Text = res[i][6].ToString();
                                SA7.Text = res[i][7].ToString();
                                SA8.Text = res[i][8].ToString();
                                SA9.Text = res[i][9].ToString();
                                break;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
        private void edit_monday_rutine(object sender, EventArgs e)
        {
            if (!clas.Text.Equals(""))
            {
                DialogResult confirm = MessageBox.Show("Do you want to edit the rutine of Monday", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (confirm.ToString().Equals("Yes"))
                {
                    Form f = new editRutine("1", clas.Text+sec.Text);
                    f.ShowDialog();
                }
            }
        }

        private void edit_tue_rutine(object sender, EventArgs e)
        {
            if (!clas.Text.Equals(""))
            {
                DialogResult confirm = MessageBox.Show("Do you want to edit the rutine of Tuesday", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (confirm.ToString().Equals("Yes"))
                {
                    Form f = new editRutine("2", clas.Text + sec.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void edit_wed_rutine(object sender, EventArgs e)
        {
            if (!clas.Text.Equals(""))
            {
                DialogResult confirm = MessageBox.Show("Do you want to edit the rutine of Wednesday", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (confirm.ToString().Equals("Yes"))
                {
                    Form f = new editRutine("3", clas.Text + sec.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void edit_thus_rutine(object sender, EventArgs e)
        {
            if (!clas.Text.Equals(""))
            {
                DialogResult confirm = MessageBox.Show("Do you want to edit the rutine of Thusday", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (confirm.ToString().Equals("Yes"))
                {
                    Form f = new editRutine("4", clas.Text + sec.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void edir_fri_rutine(object sender, EventArgs e)
        {
            if (!clas.Text.Equals(""))
            {
                DialogResult confirm = MessageBox.Show("Do you want to edit the rutine of Friday", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (confirm.ToString().Equals("Yes"))
                {
                    Form f = new editRutine("5", clas.Text + sec.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void edir_sat_rutine(object sender, EventArgs e)
        {
            if (!clas.Text.Equals(""))
            {
                DialogResult confirm = MessageBox.Show("Do you want to edit the rutine of Saturday", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (confirm.ToString().Equals("Yes"))
                {
                    Form f = new editRutine("6", clas.Text + sec.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
