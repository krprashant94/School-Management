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
    public partial class list_of_exam : Form
    {
        Db db = new Db();
        private List<List<string>> examList;
        public list_of_exam()
        {
            InitializeComponent();
            theam();
            loadExamlist();
        }
        private void theam()
        {
            TheamPack th = new TheamPack();

            this.panel1.BackColor = th.Gray;

            this.button2.BackColor = th.Gray;
            this.button2.FlatAppearance.CheckedBackColor = th.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = th.Gray;

            this.button1.BackColor = th.Gray;
            this.button1.FlatAppearance.CheckedBackColor = th.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = th.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = th.Gray;

            this.BackColor = th.Main;
        }
        public void loadExamlist()
        {
            dataGridView1.Rows.Clear();
            examList = db.getAllExam();
            for (int i = 0; i < examList.Count; i++)
            {
                dataGridView1.Rows.Add(examList[i][2], examList[i][3], examList[i][1], examList[i][0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
