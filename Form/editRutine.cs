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
    public partial class editRutine : Form
    {
        private String clas;
        private Db db = new Db();
        private DialogResult confirm;
        public editRutine(String day, String inputClas)
        {
            InitializeComponent();
            theam();
            this.clas = inputClas;
            classDay.Text = clas + "," + day;
            switch (day)
            {
                case "1":
                    dayLabel.Text = "Monday";
                    break;
                case "2":
                    dayLabel.Text = "Tuesday";
                    break;
                case "3":
                    dayLabel.Text = "Wednesday";
                    break;
                case "4":
                    dayLabel.Text = "Thusday";
                    break;
                case "5":
                    dayLabel.Text = "Friday";
                    break;
                case "6":
                    dayLabel.Text = "Saturday";
                    break;
            }
            int i;

            List<List<String>> res = db.getTimeTable(clas);


            for (i = 0; i < res.Count; i++ )
            {
                String[] list = res[i][0].ToString().Split(',');
                if (list[0] == clas)
                {
                    try
                    {
                        if (list[1] == day)
                        {
                            comboBox1.Text = res[i][1].ToString();
                            comboBox2.Text = res[i][2].ToString();
                            comboBox3.Text = res[i][3].ToString();
                            comboBox4.Text = res[i][4].ToString();
                            comboBox5.Text = res[i][5].ToString();
                            comboBox6.Text = res[i][6].ToString();
                            comboBox7.Text = res[i][7].ToString();
                            comboBox8.Text = res[i][8].ToString();
                            comboBox9.Text = res[i][9].ToString();
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }


            List<string> p1 = db.getFreeTeacher("p1", day);
            List<string> p2 = db.getFreeTeacher("p2", day);
            List<string> p3 = db.getFreeTeacher("p3", day);
            List<string> p4 = db.getFreeTeacher("p4", day);
            List<string> p5 = db.getFreeTeacher("p5", day);
            List<string> p6 = db.getFreeTeacher("p6", day);
            List<string> p7 = db.getFreeTeacher("p7", day);
            List<string> p8 = db.getFreeTeacher("p8", day);
            List<string> p9 = db.getFreeTeacher("p9", day);
            for (i = 0; i <= p1.Count - 1; i++)
            {
                comboBox1.Items.Add(p1[i]);
            } for (i = 0; i <= p2.Count - 1; i++)
            {
                comboBox2.Items.Add(p2[i]);
            } for (i = 0; i <= p3.Count - 1; i++)
            {
                comboBox3.Items.Add(p3[i]);
            } for (i = 0; i <= p4.Count - 1; i++)
            {
                comboBox4.Items.Add(p4[i]);
            } for (i = 0; i <= p5.Count - 1; i++)
            {
                comboBox5.Items.Add(p5[i]);
            } for (i = 0; i <= p6.Count - 1; i++)
            {
                comboBox6.Items.Add(p6[i]);
            } for (i = 0; i <= p7.Count - 1; i++)
            {
                comboBox7.Items.Add(p7[i]);
            } for (i = 0; i <= p8.Count - 1; i++)
            {
                comboBox8.Items.Add(p8[i]);
            } for (i = 0; i <= p9.Count - 1; i++)
            {
                comboBox9.Items.Add(p9[i]);
            }

        }
        private void theam()
        {
            TheamPack th = new TheamPack();


            this.save.BackColor = th.Main;
            this.save.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.save.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.classDay.BackColor = th.DarkGray;
            this.panel1.BackColor = th.DimGray;

            this.button2.BackColor = th.DimGray;
            this.button2.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.button1.BackColor = th.DimGray;
            this.button1.FlatAppearance.CheckedBackColor = th.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = th.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = th.DimGray;

            this.panel2.BackColor = th.DarkGray;
            this.BackColor = th.Gray;
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            confirm = MessageBox.Show("Do you want to update the Time Table", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm.ToString() == "Yes")
            {
                if (db.setTimeTable(classDay.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, comboBox5.Text, comboBox6.Text, comboBox7.Text, comboBox8.Text, comboBox9.Text))
                {
                    MessageBox.Show("Your record is updated successfully", "Sucess");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
