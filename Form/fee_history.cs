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
    public partial class fee_history : Form
    {
        public List<List<String>> res;
        public fee_history(String adm_no)
        {
            InitializeComponent();
            theam();
            Db db= new Db();
            res = db.getFeeHistory(adm_no);
            int i = 0;
            for (i = 0; i < res.Count; i++)
            {
                dataGridView1.Rows.Add(res[i][0],res[i][3],res[i][4]);
            }

        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;
            this.button2.FlatAppearance.BorderColor = th.Gray;
            this.BackColor = th.Gray;
            this.button2.FlatAppearance.BorderColor = th.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
