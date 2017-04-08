using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Web.UI;
using System.Text;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Text;
using Microsoft.Win32;
using System.Threading;
using System.Drawing;

namespace School_Management
{
    public partial class MainPage : Form
    {
        private Form formOpen;
        private Form fm;
        private string auth;
        Regedit reg = new Regedit();
        public MainPage()
        {
            InitializeComponent();
            theam();
            auth = reg.get("Auth", "Initial");
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.new_addmission.BackColor = th.Main;
            this.student.BackColor = th.Main;
            this.teacher.BackColor = th.Main;
            this.accounts.BackColor = th.Main;
            this.time_table.BackColor = th.Main;
            this.setting.BackColor = th.Main;
            this.button1.BackColor = th.Main;


            this.panel1.BackColor = th.Gray;
            this.panel6.BackColor = th.DarkGray;
            this.panel5.BackColor = th.DarkGray;
            this.panel3.BackColor = th.DarkGray;

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button3.BackColor = th.Gray;
            this.button3.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = th.Gray;

            this.BackColor = th.Gray;
        }

        private void student_Click(object sender, EventArgs e)
        {
            if (auth.Equals("Principal Desk"))
            {
                formOpen = Application.OpenForms["student"];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
                fm = new student();
                fm.TopLevel = false;
                fm.Parent = this.panel1;
                fm.Show();
            }
        }
        private void teacher_Click(object sender, EventArgs e)
        {
            if (auth.Equals("Principal Desk"))
            {
                formOpen = Application.OpenForms["teacherMenu"];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
                fm = new teacherMenu();
                fm.TopLevel = false;
                fm.Parent = this.panel1;
                fm.Show();
            }
        }

        private void time_table_Click(object sender, EventArgs e)
        {
            if (auth.Equals("Principal Desk") || auth.Equals("Examination Cell"))
            {
                formOpen = Application.OpenForms["timeTableMenu"];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
                fm = new timeTableMenu();
                fm.TopLevel = false;
                fm.Parent = this.panel1;
                fm.Show();
            }
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            Form fm = new about();
            fm.ShowDialog();
        }

        private void new_addmission_Click(object sender, EventArgs e)
        {
            if (auth.Equals("Principal Desk") || auth.Equals("Admission Cell"))
            {
                formOpen = Application.OpenForms["newStudent"];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
                fm = new newStudent();
                fm.TopLevel = false;
                fm.Parent = this.panel1;
                fm.Show();
            }
        }

        private void accounts_Click(object sender, EventArgs e)
        {
            if (auth.Equals("Principal Desk") || auth.Equals("Accounts"))
            {
                formOpen = Application.OpenForms["accountMenu"];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
                fm = new accountMenu();
                fm.TopLevel = false;
                fm.Parent = this.panel1;
                fm.Show();
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {
            formOpen = Application.OpenForms["setting"];
            if (formOpen != null)
            {
                formOpen.Close();
            }
            fm = new setting();
            fm.TopLevel = false;
            fm.Parent = this.panel1;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (auth.Equals("Principal Desk") || auth.Equals("Examination Cell"))
            {
                formOpen = Application.OpenForms["exam"];
                if (formOpen != null)
                {
                    formOpen.Close();
                }
                fm = new exam();
                fm.TopLevel = false;
                fm.Parent = this.panel1;
                fm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instamojo.com/@Redmorus");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
