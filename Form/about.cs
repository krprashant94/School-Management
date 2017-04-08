using System.Windows.Forms;

namespace School_Management
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            theam();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();
            this.BackColor = th.Main;

            this.button1.BackColor = th.Main;
            this.button1.FlatAppearance.BorderColor = th.Main;
            this.button1.FlatAppearance.MouseDownBackColor = th.Main;
            this.button1.FlatAppearance.MouseOverBackColor = th.Main;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Prashant94");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/WayToPrashant");
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://redmorus.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instamojo.com/@Redmorus");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
        }
    }
}
