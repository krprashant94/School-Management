using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management
{
    public partial class FirstRun : Form
    {
        private Encryption encrypt = new Encryption();
        private Regedit reg = new Regedit();
        Db db = new Db(0);
        private string regValue;
        public FirstRun()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (inputPass.Text.Length != 0 && inputUsername.Text.Length != 0 && server.Text.Length != 0 && department.Text.Length !=0)
            {
                try
                {
                    if (db.conTest(server.Text.ToString()))
                    {
                        /* Set User Pass*/
                        reg.add(inputUsername.Text, encrypt.md5(inputPass.Text), "Initial");
                        reg.add("fee", "0", "Initial");
                        reg.add("Theam", "Black", "Color");
                        reg.add("Auth", department.Text.ToString(), "Initial");

                        /* Set Server*/
                        reg.add("savePath", pdf_save_path.Text, "Printer");
                        reg.add("Server", server.Text, "Server");
                        regValue = reg.get("Server", "Server");
                        MessageBox.Show("Database Path : " + regValue, "Sucess", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("You must fill all the field", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            }
        }

        private void server_Click(object sender, EventArgs e)
        {
            if (selectServer.ShowDialog() == DialogResult.OK)
            {
                server.Text = selectServer.FileName.ToString();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                pdf_save_path.Text = selectFolder.SelectedPath.ToString();

            }
        }
    }
}
