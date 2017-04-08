using Microsoft.Win32;
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
    public partial class setting : Form
    {
        private Regedit reg = new Regedit();
        private Encryption encrypt;
        private string cuPass;
        Db db0 = new Db(0);
        public setting()
        {
            InitializeComponent();
            theam();
            maskedTextBox1.Text = reg.get("savePath", "Printer");
            textBox1.Text = reg.get("fee", "Initial");
            server.Text = reg.get("Server", "Server");
            cuTheam.Text = reg.get("Theam", "Color");
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.connectServer.BackColor = th.Main;
            this.button1.BackColor = th.Main;
            this.button2.BackColor = th.Main;
            this.button3.BackColor = th.Main;
            this.button4.BackColor = th.Main;
            this.button7.BackColor = th.Main;


            this.panel1.BackColor = th.Gray;
            this.panel2.BackColor = th.Gray;
            this.panel3.BackColor = th.Gray;
            this.panel4.BackColor = th.Gray;
            this.panel5.BackColor = th.Gray;
            this.panel6.BackColor = th.Gray;
            this.panel7.BackColor = th.Gray;

            this.button5.BackColor = th.Gray;
            this.button5.FlatAppearance.CheckedBackColor = th.Gray;
            this.button5.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button6.BackColor = th.Gray;
            this.button6.FlatAppearance.CheckedBackColor = th.Gray;
            this.button6.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = th.Gray;

            this.BackColor = th.DarkGray;
        }

        private void server_Click(object sender, EventArgs e)
        {
            if (selectServer.ShowDialog() == DialogResult.OK)
            {
                server.Text = selectServer.FileName.ToString();

            }
        }

        private void connectServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (db0.conTest(server.Text.ToString()))
                {
                    reg.add("Server", server.Text, "Server");
                    MessageBox.Show(reg.get("Server", "Server"));
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
            System.Diagnostics.Process.Start(cplPath, "/name Microsoft.Printers");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg.add("fee", textBox1.Text, "Initial");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                encrypt = new Encryption();
                cuPass = reg.get(textBox2.Text.ToString(), "Initial");
                if (encrypt.md5(textBox3.Text).Equals(cuPass))
                {
                    reg.add(textBox2.Text, encrypt.md5(textBox4.Text), "Initial");
                    MessageBox.Show("User password changed", "Sucess", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                reg.add("User", textBox2.Text, "Initial");
                reg.add("Pass", textBox4.Text, "Initial");
                MessageBox.Show("User password changed", "Sucess", MessageBoxButtons.OK);
            }
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                maskedTextBox1.Text = folderBrowser.SelectedPath.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                reg.add("savePath", maskedTextBox1.Text, "Printer");
                MessageBox.Show("Folder location saved.","Success", MessageBoxButtons.OK);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                reg.add("Theam", cuTheam.Text, "Color");
                MessageBox.Show("Theam Changed", "Success", MessageBoxButtons.OK);
                Application.Restart();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message.ToString());
            }
        }
    }
}
