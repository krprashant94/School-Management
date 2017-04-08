using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace School_Management
{
    class PrintFormetter
    {
        private WebBrowser webBrowser = new WebBrowser();
        private StringBuilder sb;
        private string savePath;
        private Db db = new Db();
        private List<string> feeDetails;
        public OleDbDataReader studentInfo;
        Encryption digit = new Encryption();
        Regedit reg = new Regedit();
        string date = DateTime.Now.ToString("dd-MM-yyyy");
        private string studentName;
        private string studentClass;
        private string billNo;


        public PrintFormetter(string adm_no, CheckedListBox.CheckedItemCollection checkedItemCollection, String slipNo)
        {
            this.billNo = slipNo;
            savePath = reg.get("savePath", "Printer");
            int i;
            try
            {
                List<List<string>> academic_fee = new List<List<string>>();
                List<List<string>> other_fee = new List<List<string>>();
                List<List<string>> fine = new List<List<string>>();
                List<string> tmp = new List<string>();
                for (i = 0; i < checkedItemCollection.Count; i++)
                {
                    String[] item_id = null;
                    item_id = checkedItemCollection[i].ToString().Split('#');
                    feeDetails = db.getFeeDetails(item_id[1]);
                    if (feeDetails[3].Trim().Equals("Academic Fee"))
                    {
                        tmp.Add(feeDetails[1].ToString());
                        tmp.Add(feeDetails[2].ToString());
                        academic_fee.Add(tmp);
                    }
                    if (feeDetails[3].Trim().Equals("Other"))
                    {
                        tmp.Add(feeDetails[1].ToString());
                        tmp.Add(feeDetails[2].ToString());
                        other_fee.Add(tmp);
                    }
                    if (feeDetails[3].Trim().Equals("Fine"))
                    {
                        tmp.Add(feeDetails[1].ToString());
                        tmp.Add(feeDetails[2].ToString());
                        fine.Add(tmp);
                    }
                    tmp = new List<string>();
                }
                studentInfo = db.studentInfo(adm_no);
                while (studentInfo.Read())
                {
                    studentName = studentInfo[1].ToString();
                    studentClass = studentInfo[2].ToString() + " " + studentInfo[3].ToString();
                }
                try
                {
                    printBill(adm_no, date, studentName, studentClass, slipNo, academic_fee, other_fee, fine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public PrintFormetter(String name, String slipNo, String disc, int amt)
        {
            this.billNo = slipNo;
            savePath = reg.get("savePath", "Printer");

            List<List<string>> other = new List<List<string>>();
            List<string> tmp = new List<string>();
            tmp.Add(disc);
            tmp.Add(amt.ToString());
            other.Add(tmp);
            printBill("N/A", date, name, "N/A", slipNo, new List<List<string>>(), other, new List<List<string>>());
        }

        public PrintFormetter(String adm_no, String name, String roll_no, String exam, String clas, DataGridView marksSheet)
        {
            resultPrint(adm_no, name, roll_no, exam, clas, marksSheet);
        }

        private void printBill(string adm_no, string date, string name, string clas, string slNo, List<List<string>> academic_fee, List<List<string>> other_fee, List<List<string>> fine)
        {
            int total = 0, line = 0;
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                sb = new StringBuilder();
                string head = "<!DOCTYPE html><head><style>@page {   size: 7in 9.25in;   margin: 27mm 16mm 27mm 16mm; }</style></head>" +
                            "<body>" +
                            "<div style='width:149mm; height:210mm; border:1px solid black; padding:1mm; margin:1mm;'>" +
                            "    <div  align='center'>" +
                            "        <h1>Vani Vidya Mandir</h1>" +
                            "        Gamhria-832108" +
                            "    </div>" +
                            "    <hr/>";
                string layer1 = "<table width='100%' cellspacing='0' cellpadding='2'>" +
                                "        <tr><td colspan = '2'></td></tr>" +
                                "        <tr>" +
                                "            <td><b>Admission No : </b>" + adm_no + "</td>" +
                                "            <td align = 'right'><b>Date: </b>" + date + "</td>" +
                                "        </tr>" +
                                "        <tr><td colspan = '2'><b>Name : </b>" + name + "</td></tr>" +
                                "        <tr>" +
                                "        	<td><b>Class : </b>" + clas + "</td>" +
                                "            <td align = 'right'><b>Sl. No : </b>" + slNo + "</td>" +
                                "       	</tr>" +
                                "    </table><hr/>";
                string layer2 = "<table border = '0'  width='100%' cellpadding='0' cellspacing='2'>" +
                "        <tr>" +
                "            <th width='80%'>Discription</th>" +
                "            <th>Amount</th>" +
                "        </tr>" +
                "    </table><hr/>";
                string layer3 = "<div style='height:130mm'><table border = '0'  width='100%'>";
                if (academic_fee.Count != 0)
                {
                    layer3 += "<tr><td colspan='2'><b>Academic Fee</b></td></tr>";
                    line++;
                    for (int i = 0; i < academic_fee.Count; i++)
                    {
                        layer3 += "<tr>" +
                            "<td>&emsp;" + academic_fee[i][0] + "</td>" +
                            "   <td align='right'>" + academic_fee[i][1] + "</td>" +
                            "</tr>";
                        line++;
                        total += Int32.Parse(academic_fee[i][1]);
                    }
                }
                if (other_fee.Count != 0)
                {
                    layer3 += "<tr><td colspan='2'><b>Other</b></td></tr>";
                    line++;
                    for (int i = 0; i < other_fee.Count; i++)
                    {
                        layer3 += "<tr>" +
                            "<td>&emsp;" + other_fee[i][0] + "</td>" +
                            "   <td align='right'>" + other_fee[i][1] + "</td>" +
                            "</tr>";
                        line++;
                        total += Int32.Parse(other_fee[i][1]);
                    }
                } if (fine.Count != 0)
                {
                    layer3 += "<tr><td colspan='2'><b>Fine</b></td></tr>";
                    line++;
                    for (int i = 0; i < fine.Count; i++)
                    {
                        layer3 += "<tr>" +
                            "<td>&emsp;" + fine[i][0] + "</td>" +
                            "   <td align='right'>" + fine[i][1] + "</td>" +
                            "</tr>";
                        line++;
                        total += Int32.Parse(fine[i][1]);
                    }
                }

                layer3 += "</table></div> <hr/>";

                string layer4 = "<table width='100%' cellpadding='0' cellspacing='0'>" +
                                "            <tr>" +
                                "                <th align = 'right' width='80%'>Total</th>" +
                                "                <th align = 'right'>" + total + "</th>" +
                                "            </tr>" +
                                "        </table>" +
                                "        <hr/>";

                string closing = "<table width='100%'>            <tr>                <td width='80%'>" +
                   digit.ToWords(total) + " Only</td>                <td align='right'>Signature</td>            </tr>        </table></div></body>";

                sb.Append(head);
                sb.Append(layer1);
                sb.Append(layer2);
                sb.Append(layer3);
                sb.Append(layer4);
                sb.Append(closing);
                string fileName = savePath+"/bill-"+billNo+".html";
                try
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }

                    using (FileStream fs = File.Create(fileName))
                    {
                        Byte[] title = new UTF8Encoding(true).GetBytes(sb.ToString());
                        fs.Write(title, 0, title.Length);
                    }

                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.ToString());
                }  


                webBrowser.DocumentText = sb.ToString();
                webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
            }
        }
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.ShowPageSetupDialog();
            webBrowser.ShowPrintDialog();
            webBrowser.Dispose();
        }


        private void resultPrint(String adm_no, String name, String roll_no, String exam, String clas, DataGridView marksSheet)
        {
            StringBuilder sb = new StringBuilder();
            string head = "<!DOCTYPE html>" +
                        "<body>" +
                        "<div style='width:210mm; border:1px solid black; padding:1mm; margin:1mm;'>" +
                        "    <div  align='center'>" +
                        "        <div style='font-size:35px;'><b>Vani Vidya Mandir</b></div>" +
                        "        Gamhria-832108" +
                        "    </div>" +
                        "    <hr/>";
            string layer1 = "    <table width='100%' cellspacing='0' cellpadding='2'>" +
                        "        <tr><td><b>Name : </b>" + name + "</td><td align = 'right'><b>Exam : </b>" + exam + "</td></tr>" +
                        "        <tr>" +
                        "            <td><b>Admission No : </b>" + adm_no + "</td>" +
                        "            <td align = 'right'><b>Date: </b>" + date + "</td>" +
                        "        </tr>" +
                        "        <tr>" +
                        "        	<td><b>Roll No. : </b>" + roll_no + "</td>" +
                        "        	<td  align = 'right'><b>Class : </b>" + clas + "</td>" +
                        "       	</tr>" +
                        "    </table>" +
                        "    <hr/>";
            string layer2 = "<table border='1px' width='100%' cellpadding='2' cellspacing='0'>" +
                        "        <tr>" +
                        "            <th rowspan='2' width='50%'>Subject</th>" +
                        "            <th colspan='3'>Marks</th>" +
                        "            <th width='10%' rowspan='2'>Remark</th>" +
                        "            <th width='10%' rowspan='2'>Rank</th>" +
                        "        </tr>" +
                        "        <tr>" +
                        "            <th width='10%'>Total</th>" +
                        "            <th width='10%'>Pass</th>" +
                        "            <th width='10%'>Obtain</th>" +
                        "        </tr>";
            string layer3 = "";
            int total = 0, pass = 0, obtain = 0;
            string remark;

            for (int i = 0; i < marksSheet.Rows.Count; i++)
            {
                int subTotal = Int32.Parse(marksSheet.Rows[i].Cells[1].Value.ToString());
                int subPass = Int32.Parse(marksSheet.Rows[i].Cells[2].Value.ToString());
                int subObtain = Int32.Parse(marksSheet.Rows[i].Cells[3].Value.ToString());
                total += subTotal;
                pass += subPass;
                obtain += subObtain;
                remark = subPass < subObtain ? subObtain >= 75 ? "D" : "P" : "F";

                layer3 += "<tr>" +
                        "            <td  width='55%'>" + marksSheet.Rows[i].Cells[0].Value + "</td>" +
                        "            <td  width='15%' align='center'>" + marksSheet.Rows[i].Cells[1].Value + "</td>" +
                        "            <td  width='15%' align='center'>" + marksSheet.Rows[i].Cells[2].Value + "</td>" +
                        "            <td  width='15%' align='center'>" + marksSheet.Rows[i].Cells[3].Value + "</td>" +
                        "            <td  width='15%' align='center'>" + remark + "</td>" +
                        "            <td  width='15%' align='center'>&nbsp;</td>" +
                        "        </tr>";
            }
            remark = pass > obtain ? "Fail" : "Pass";

            string layer4 = "<tr>" +
                        "            <td  width='55%' align='right'>Total</td>" +
                        "            <td  width='15%' align='right'>" + total + "</td>" +
                        "            <td  width='15%' align='right'>" + pass + "</td>" +
                        "            <td  width='15%' align='right'>" + obtain + "</td>" +
                        "            <td  width='15%' align='right'>" + remark + "</td>" +
                        "            <td  width='15%' align='right'>&nbsp;</td>" +
                        "        </tr>" +
                        "    </table>";
            string footer = "<hr/>" +

                        "    <table width='100%' cellspacing='0' cellpadding='2'>" +
                        "        <tr>" +
                        "            <td>Parent Sign.</td>" +
                        "            <td align = 'right'>Principal Sign.</td>" +
                        "        </tr>" +
                        "    </table>" +
                        "</div>" +
                        "</body>";

            sb.Append(head);
            sb.Append(layer1);
            sb.Append(layer2);
            sb.Append(layer3);
            sb.Append(layer4);
            sb.Append(footer);

            webBrowser.DocumentText = sb.ToString();
            webBrowser.DocumentCompleted += webBrowser_DocumentCompleted;
        }
    }
}
