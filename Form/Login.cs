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
    public partial class Login : Form
    {
        private Regedit reg = new Regedit();
        private Encryption encrypt = new Encryption();
        private string pass;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName.Text.Length != 0 && passWord.Text.Length != 0)
            {
                try
                {
                    pass = reg.get(userName.Text.ToString(), "Initial");
                    if (encrypt.md5(passWord.Text).Equals(pass))
                    {
                        reg.add("Login", "true", "Initial");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username and Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                    }
                }catch(Exception){
                    MessageBox.Show("Wrong Username and Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
