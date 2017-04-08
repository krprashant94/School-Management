using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace School_Management
{
    class Db
    {
        private String ConnStr;
        private RegistryKey key, tmpReg;
        public Db()
        {
            key = Registry.CurrentUser.OpenSubKey(@"School\\Server");
            ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + key.GetValue("Server").ToString() + ";";
            key.Close();
        }
        public Db(int Conntest)
        {

        }

        public void addStudent(String adm_no, String full_name, String clas, String section, String roll_no, String address, String f_name, String m_name, String mob, String dob, String doa, String image, String bloodgroup, String gander, bool edit, String aadhar, String prev_school_name, String prev_school_address, String prev_school_slc_no)
        {
            tmpReg = Registry.CurrentUser.OpenSubKey(@"School\\Initial");
            String initialFee = tmpReg.GetValue("fee").ToString();
            tmpReg.Close();
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            int clasInt = Int32.Parse(clas);
            con.Open();
            var stream = File.ReadAllBytes(image);

            if (edit)
            {
                try
                {
                    cmd.CommandText = "UPDATE student_info SET full_name=@full_name, clas=@clasInt, sec= @section, roll_no= @roll_no,"
                    + " address=@address, f_name=@f_name, m_name=@m_name, mob=@mob, dob=@dob, doa=@doa, img=@stream, bloodgroup=@bloodgroup, gander=@gander, aadhar=@aadhar, prev_school_name = @prev_school_name, prev_school_address = @prev_school_address, prev_school_slc_no = @prev_school_slc_no WHERE adm_no=@adm_no";

                    cmd.Parameters.AddWithValue("@full_name", full_name);
                    cmd.Parameters.AddWithValue("@clasInt", clasInt);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@roll_no", roll_no);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@f_name", f_name);
                    cmd.Parameters.AddWithValue("@m_name", m_name);
                    cmd.Parameters.AddWithValue("@mob", mob);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@doa", doa);
                    cmd.Parameters.AddWithValue("@imageStream", stream);
                    cmd.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                    cmd.Parameters.AddWithValue("@gander", gander);
                    cmd.Parameters.AddWithValue("@adm_no", adm_no);
                    cmd.Parameters.AddWithValue("@aadhar", aadhar);
                    cmd.Parameters.AddWithValue("@prev_school_name", prev_school_name);
                    cmd.Parameters.AddWithValue("@prev_school_address", prev_school_address);
                    cmd.Parameters.AddWithValue("@prev_school_slc_no", prev_school_slc_no);

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Data Updated", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    initialFee = initialFee.Equals("0") ? "" : initialFee;
                    cmd.CommandText = "INSERT INTO student_info (adm_no, full_name, clas, sec, roll_no, address, f_name, m_name, mob, dob, doa, fee_due, img, bloodgroup, gander, aadhar, prev_school_name, prev_school_address, prev_school_slc_no) "
                        + " Values(@adm_no, @full_name, @clasInt, @section, @roll_no, @address, @f_name, @m_name, @mob, @dob, @doa, @initialFee, @stream, @bloodgroup, @gander, @aadhar, @prev_school_name, @prev_school_address, @prev_school_slc_no)";

                    cmd.Parameters.AddWithValue("@adm_no", adm_no);
                    cmd.Parameters.AddWithValue("@full_name", full_name);
                    cmd.Parameters.AddWithValue("@clasInt", clasInt);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@roll_no", roll_no);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@f_name", f_name);
                    cmd.Parameters.AddWithValue("@m_name", m_name);
                    cmd.Parameters.AddWithValue("@mob", mob);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@doa", doa);
                    cmd.Parameters.AddWithValue("@initialFee", initialFee);
                    cmd.Parameters.AddWithValue("@imageStream", stream);
                    cmd.Parameters.AddWithValue("@bloodgroup", bloodgroup);
                    cmd.Parameters.AddWithValue("@gander", gander);
                    cmd.Parameters.AddWithValue("@aadhar", aadhar);
                    cmd.Parameters.AddWithValue("@prev_school_name", prev_school_name);
                    cmd.Parameters.AddWithValue("@prev_school_address", prev_school_address);
                    cmd.Parameters.AddWithValue("@prev_school_slc_no", prev_school_slc_no);

                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Student Added", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public List<List<String>> getStudent(int clas)
        {
            List<List<String>> studentList = new List<List<String>>();
            List<String> student = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM student_info WHERE clas = @clas", con);
                cmd.Parameters.AddWithValue("@clas", clas);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    student.Add(res[0].ToString());
                    student.Add(res[1].ToString());
                    student.Add(res[2].ToString());
                    student.Add(res[3].ToString());
                    student.Add(res[4].ToString());
                    student.Add(res[5].ToString());
                    student.Add(res[6].ToString());
                    student.Add(res[7].ToString());
                    student.Add(res[8].ToString());
                    studentList.Add(student);
                    student = new List<String>();
                }
                con.Close();
                return studentList;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<List<String>> getStudent(int clas, String sec)
        {
            List<List<String>> studentList = new List<List<String>>();
            List<String> student = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM student_info WHERE clas = @clas AND sec=@sec", con);
                cmd.Parameters.AddWithValue("@clas", clas);
                cmd.Parameters.AddWithValue("@sec", sec);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    student.Add(res[0].ToString());
                    student.Add(res[1].ToString());
                    student.Add(res[2].ToString());
                    student.Add(res[3].ToString());
                    student.Add(res[4].ToString());
                    student.Add(res[5].ToString());
                    student.Add(res[6].ToString());
                    student.Add(res[7].ToString());
                    student.Add(res[8].ToString());
                    studentList.Add(student);
                    student = new List<String>();
                }
                con.Close();
                return studentList;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public OleDbDataReader studentInfo(String adm_no)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM student_info WHERE adm_no = @adm_no", con);
                cmd.Parameters.AddWithValue("@adm_no", adm_no);
                OleDbDataReader res = cmd.ExecuteReader();
                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<String> getFeeDetails(String id)
        {
            List<String> list = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM fee_type WHERE fee_id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    list.Add(res[0].ToString());
                    list.Add(res[1].ToString());
                    list.Add(res[2].ToString());
                    list.Add(res[3].ToString());
                }
                con.Close();
                return list;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<String> getAllFeeID()
        {
            List<String> list = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM fee_type WHERE 1", con);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    list.Add(res[0].ToString());
                }
                con.Close();
                return list;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<List<String>> getTimeTable(String classDay)
        {
            List<List<String>> timeTable = new List<List<String>>();
            List<String> row = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                classDay += ",%";
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM timeTable WHERE classDay like @classDay", con);
                cmd.Parameters.AddWithValue("@classDay", classDay);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    row.Add(res[0].ToString());
                    row.Add(res[1].ToString());
                    row.Add(res[2].ToString());
                    row.Add(res[3].ToString());
                    row.Add(res[4].ToString());
                    row.Add(res[5].ToString());
                    row.Add(res[6].ToString());
                    row.Add(res[7].ToString());
                    row.Add(res[8].ToString());
                    row.Add(res[9].ToString());
                    timeTable.Add(row);
                    row = new List<String>();
                }
                con.Close();
                return timeTable;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<String> getFreeTeacher(String priod, String day)
        {
            String classDay = "%," + day;
            List<string> teacherList = new List<string>();
            int i = 0;
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT t_name FROM teacher WHERE 1", con);
                OleDbCommand cmd1 = new OleDbCommand("SELECT " + priod + " FROM timeTable WHERE classDay like @classDay", con);
                cmd1.Parameters.AddWithValue("@classDay", classDay);
                cmd1.Parameters.AddWithValue("@priod", priod);
                OleDbDataReader res = cmd.ExecuteReader();
                OleDbDataReader res1 = cmd1.ExecuteReader();
                while (res.Read())
                {
                    teacherList.Add(res[0].ToString());
                    i++;
                }
                while (res1.Read())
                {
                    for (i = 0; i <= teacherList.Count-1; i++)
                    {
                        if(res1[0].ToString() == teacherList[i].ToString()){
                            teacherList.RemoveAt(i);
                            continue;
                        }
                    }
                }
                con.Close();
                return teacherList;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }           
        }

        public bool setTimeTable(String classDay, String p1, String p2, String p3, String p4, String p5, String p6, String p7, String p8, String p9)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE timeTable set p1 = @p1, p2=@p2, p3 = @p3, p4 = @p4,p5 = @p5,p6 = @p6, p7 = @p7, p8 = @p8, p9 = @p9 WHERE classDay=@classDay;";
                cmd.Parameters.AddWithValue("@p1", p1);
                cmd.Parameters.AddWithValue("@p2", p2);
                cmd.Parameters.AddWithValue("@p3", p3);
                cmd.Parameters.AddWithValue("@p4", p4);
                cmd.Parameters.AddWithValue("@p5", p5);
                cmd.Parameters.AddWithValue("@p6", p6);
                cmd.Parameters.AddWithValue("@p7", p7);
                cmd.Parameters.AddWithValue("@p8", p8);
                cmd.Parameters.AddWithValue("@p9", p9);
                cmd.Parameters.AddWithValue("@classDay", classDay);
                cmd.ExecuteNonQuery();                
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool addTeacher(String t_name, String speclist, String ph, String address, String payScale,String aadhar_no, bool edit)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                if (edit)
                {
                    cmd.CommandText = "UPDATE teacher SET specilist=@speclist, ph=@ph, address=@address, payScale=@payScale, aadhar_no= @aadhar_no"
                        + " WHERE t_name = @t_name";
                    cmd.Parameters.AddWithValue("@speclist", speclist);
                    cmd.Parameters.AddWithValue("@ph", ph);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@payScale", payScale);
                    cmd.Parameters.AddWithValue("@t_name", t_name);
                    cmd.Parameters.AddWithValue("@aadhar_no", aadhar_no);
                }
                else
                {
                    cmd.CommandText = "INSERT INTO teacher (t_name, specilist, ph, address, payScale, aadhar_no) "
                        + " Values(@t_name, @speclist, @ph, @address, @payScale, @aadhar_no)";
                    cmd.Parameters.AddWithValue("@t_name", t_name);
                    cmd.Parameters.AddWithValue("@speclist", speclist);
                    cmd.Parameters.AddWithValue("@ph", ph);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@payScale", payScale);
                    cmd.Parameters.AddWithValue("@aadhar_no", aadhar_no);
                }
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
       
        public bool removeTeacher(String t_name)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM teacher WHERE t_name = @t_name ";
                cmd.Parameters.AddWithValue("@t_name", t_name);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool feePay(List<String> pay_list, String adm_no, String timestamp)
        {
            String paidDetails = "";
            String[] due_list_from_db;
            List<String> newList = new List<String>();
            OleDbDataReader res;
            int i, j;
            bool flag;
            String fee_due = "";
            int amount = 0;
            String date = DateTime.Now.ToString("dd-MM-yyyy").ToString();

            OleDbConnection con = new OleDbConnection(ConnStr);
            con.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT fee_due FROM student_info WHERE adm_no = @adm_no", con);
                cmd.Parameters.AddWithValue("@adm_no", adm_no);
                res = cmd.ExecuteReader();
                while (res.Read())
                {
                    due_list_from_db = res[0].ToString().Split(',');
                    for (i = 0; i < due_list_from_db.Length; i++)
                    {
                        flag = false;
                        for (j = 0; j < pay_list.Count; j++)
                        {
                            if (due_list_from_db[i].Equals(pay_list[j]))
                            {
                                flag = true;                                
                            }
                        }
                        if (flag)
                        {
                            OleDbCommand quary2 = new OleDbCommand("SELECT amount FROM fee_type WHERE fee_id = @fee_id", con);
                            quary2.Parameters.AddWithValue("@fee_id", due_list_from_db[i]);
                            res = quary2.ExecuteReader();
                            while (res.Read())
                            {
                                amount += Int32.Parse(res[0].ToString());
                            }
                            paidDetails += due_list_from_db[i] + ',';
                        }
                        else
                        {
                            newList.Add(due_list_from_db[i]);
                        }
                    }
                    for (i = 0; i < newList.Count; i++)
                    {

                        if (newList.Count - 1 == i)
                        {
                            fee_due += newList[i];
                        }
                        else
                        {
                            fee_due += newList[i] + ",";
                        }
                    }
                    OleDbCommand cmd1 = new OleDbCommand("UPDATE student_info SET fee_due = @fee_due WHERE adm_no = @adm_no", con);
                    cmd1.Parameters.AddWithValue("@fee_due", fee_due);
                    cmd1.Parameters.AddWithValue("@adm_no", adm_no);
                    cmd1.ExecuteNonQuery();
                                       
                    OleDbCommand quary1 = con.CreateCommand();
                    quary1.CommandText = "INSERT INTO expense (recipt_id, adm_no, paidDetails, amountPay, payDate, type) "
                       + " Values( @recpt_id, @adm_no, @paidDetails, @amount, @dateTime, 'I')";

                    quary1.Parameters.AddWithValue("@recpt_id", timestamp);
                    quary1.Parameters.AddWithValue("@adm_no", adm_no);
                    quary1.Parameters.AddWithValue("@paidDetails", paidDetails);
                    quary1.Parameters.AddWithValue("@amountPay", amount.ToString());
                    quary1.Parameters.AddWithValue("@dateTime", date);
                    quary1.ExecuteNonQuery();
                }
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool addExpense(String recipt_id, String payTo, String paidDetails, int amountPay, Char type)
        {
            String date = DateTime.Now.ToString("dd-MM-yyyy").ToString();
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO expense (recipt_id, adm_no, paidDetails, amountPay, payDate, type) "
                    + " Values(@recipt_id, @adm_no, @paidDetails, @amountPay, @payDate, @type)";
                cmd.Parameters.AddWithValue("@recipt_id", recipt_id);
                cmd.Parameters.AddWithValue("@adm_no", payTo);
                cmd.Parameters.AddWithValue("@paidDetails", paidDetails);
                cmd.Parameters.AddWithValue("@amountPay", amountPay.ToString());
                cmd.Parameters.AddWithValue("@payDate", date);
                cmd.Parameters.AddWithValue("@type", type);
                
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public List<List<String>> getFeeHistory(String adm_no)
        {
            List<List<String>> feeHistory = new List<List<String>>();
            List<String> row = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM expense WHERE adm_no = @adm_no", con);
                cmd.Parameters.AddWithValue("@adm_no", adm_no);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    row.Add(res[0].ToString());
                    row.Add(res[1].ToString());
                    row.Add(res[2].ToString());
                    row.Add(res[3].ToString());
                    row.Add(res[4].ToString());
                    row.Add(res[5].ToString());
                    feeHistory.Add(row);
                    row = new List<String>();
                }
                con.Close();
                return feeHistory;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal bool conTest(String path)
        {
            String tmpConnStr = ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path+ ";";
            try
            {
                OleDbConnection con = new OleDbConnection(tmpConnStr);
                con.Open();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " or database may be corrupted.", "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal bool addFeetype(String fee_id, String fee_type, String amount, String category)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO fee_type (fee_id, fee_type, amount, category) "
                    + " Values(@fee_id, @fee_type, @amount, @category)";
                cmd.Parameters.AddWithValue("@fee_id", fee_id);
                cmd.Parameters.AddWithValue("@fee_type", fee_type);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<List<String>> getAllPayment(String date)
        {
            List<List<String>> feeHistory = new List<List<String>>();
            List<String> row = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM expense WHERE payDate LIKE @date", con);
                cmd.Parameters.AddWithValue("@date", '%'+date);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    row.Add(res[0].ToString());
                    row.Add(res[1].ToString());
                    row.Add(res[2].ToString());
                    row.Add(res[3].ToString());
                    row.Add(res[4].ToString());
                    row.Add(res[5].ToString());
                    feeHistory.Add(row);
                    row = new List<String>();
                }
                con.Close();
                return feeHistory;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool addFee( String adm_no, String feeID)
        {
            OleDbDataReader res;
            String fee_due = "";
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT fee_due FROM student_info WHERE adm_no = @adm_no", con);
                cmd.Parameters.AddWithValue("@adm_no", adm_no);
                res = cmd.ExecuteReader();
                while (res.Read())
                {
                    if (res[0].ToString().Length == 0)
                    {
                        fee_due = res[0].ToString() + feeID;
                    }
                    else
                    {
                        fee_due = res[0].ToString() + "," + feeID;
                    }
                }
                OleDbCommand cmd1 = new OleDbCommand("UPDATE student_info SET fee_due = @fee_due WHERE adm_no = @adm_no", con);
                cmd1.Parameters.AddWithValue("@fee_due", fee_due);
                cmd1.Parameters.AddWithValue("@adm_no", adm_no);
                cmd1.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool addFee(String clas, String sec, String feeID)
        {
            OleDbDataReader res, adm_no;
            String fee_due = "";
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd2 = new OleDbCommand("SELECT adm_no FROM student_info WHERE clas = @clas AND sec = @sec", con);
                cmd2.Parameters.AddWithValue("@clas", clas);
                cmd2.Parameters.AddWithValue("@sec", sec);
                adm_no = cmd2.ExecuteReader();
                while (adm_no.Read())
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT fee_due FROM student_info WHERE adm_no = @adm_no", con);
                    cmd.Parameters.AddWithValue("@adm_no", adm_no[0].ToString());
                    res = cmd.ExecuteReader();
                    while (res.Read())
                    {
                        if (res[0].ToString().Length == 0)
                        {
                            fee_due = res[0].ToString() + feeID;
                        }
                        else
                        {
                            fee_due = res[0].ToString() + "," + feeID;
                        }
                    }
                    OleDbCommand cmd1 = new OleDbCommand("UPDATE student_info SET fee_due = @fee_due WHERE adm_no = @adm_no", con);
                    cmd1.Parameters.AddWithValue("@fee_due", fee_due);
                    cmd1.Parameters.AddWithValue("@adm_no", adm_no[0].ToString());
                    cmd1.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<List<String>> getAllTeacher()
        {
            List<List<String>> allTeacher = new List<List<String>>();
            List<String> row = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM teacher WHERE 1", con);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    row.Add(res[0].ToString());
                    row.Add(res[1].ToString());
                    row.Add(res[2].ToString());
                    allTeacher.Add(row);
                    row = new List<String>();
                }
                con.Close();
                return allTeacher;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool addMarkSheet(String marks, String adm_no, String paper, String exam)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE marksheet SET marks = @marks WHERE adm_no = @adm_no AND paper=@paper AND exam = @exam";
                cmd.Parameters.AddWithValue("@marks", marks);
                cmd.Parameters.AddWithValue("@adm_no", adm_no);
                cmd.Parameters.AddWithValue("@paper", paper);
                cmd.Parameters.AddWithValue("@exam", exam);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        internal string createRecipt()
        {
            return (Int64.Parse(DateTime.Now.ToString("yyMMddHHmmssff")) - 17022514503837).ToString();
        }

        internal bool newExam(string name, string clas, string section, string exam, string paper, string full_marks, string pass_marks)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            con.Open();
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO marksheet (adm_no, clas, sec, exam, paper, total_marks, pass_marks, marks) "
                    + " Values(@adm_no, @clas, @sec, @exam, @paper, @full_marks, @pass_marks, @marks)";
                cmd.Parameters.AddWithValue("@adm_no", name);
                cmd.Parameters.AddWithValue("@clas", clas);
                cmd.Parameters.AddWithValue("@sec", section);
                cmd.Parameters.AddWithValue("@exam", exam);
                cmd.Parameters.AddWithValue("@paper", paper);
                cmd.Parameters.AddWithValue("@full_marks", full_marks);
                cmd.Parameters.AddWithValue("@pass_marks", pass_marks);
                cmd.Parameters.AddWithValue("@marks", "0");
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.StackTrace, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<List<String>> getAllExam()
        {
            List<List<String>> allExam = new List<List<String>>();
            List<String> exam = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT sec, clas, exam, paper  FROM marksheet GROUP BY sec, clas, exam, paper", con);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    exam.Add(res[0].ToString());
                    exam.Add(res[1].ToString());
                    exam.Add(res[2].ToString());
                    exam.Add(res[3].ToString());
                    allExam.Add(exam);
                    exam = new List<String>();
                }
                con.Close();
                return allExam;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<List<String>> getResult(String adm_no, String exam_name)
        {
            List<List<String>> result = new List<List<String>>();
            List<String> exam = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT *  FROM marksheet WHERE adm_no = @adm_no AND exam = @exam", con);
                cmd.Parameters.AddWithValue("@adm_no", adm_no);
                cmd.Parameters.AddWithValue("@exam", exam_name);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    exam.Add(res[0].ToString());
                    exam.Add(res[1].ToString());
                    exam.Add(res[2].ToString());
                    exam.Add(res[3].ToString());
                    exam.Add(res[4].ToString());
                    exam.Add(res[5].ToString());
                    exam.Add(res[6].ToString());
                    exam.Add(res[7].ToString());
                    exam.Add(res[8].ToString());
                    result.Add(exam);
                    exam = new List<String>();
                }
                con.Close();
                return result;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal bool examexist(string clas, string sec, string exam, string paper)
        {
            bool rte=false;
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM marksheet WHERE clas=@clas AND sec=@sec AND exam=@exam AND paper=@paper", con);
                cmd.Parameters.AddWithValue("@clas", clas);
                cmd.Parameters.AddWithValue("@sec", sec);
                cmd.Parameters.AddWithValue("@exam", exam);
                cmd.Parameters.AddWithValue("@paper", paper);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    rte = true;
                }
                con.Close();
                return rte;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<List<String>> getStudentInExam(String exam, String paper, string clas, string sec)
        {
            List<List<String>> result = new List<List<String>>();
            List<String> data = new List<String>();
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT adm_no, marks FROM marksheet WHERE exam = @exam AND paper = @paper AND clas = @clas AND sec = @sec", con);
                cmd.Parameters.AddWithValue("@exam", exam);
                cmd.Parameters.AddWithValue("@paper", paper);
                cmd.Parameters.AddWithValue("@clas", clas);
                cmd.Parameters.AddWithValue("@sec", sec);
                OleDbDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    data.Add(res[0].ToString());
                    data.Add(res[1].ToString());
                    result.Add(data);
                    data = new List<String>();
                }
                con.Close();
                return result;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        internal int getCount(int clas)
        {
            int count=0;
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM student_info WHERE clas =@clas", con);
                cmd.Parameters.AddWithValue("@clas", clas.ToString());
                count = Int32.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
                return count;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return count;
            }
        }

        internal int getCount(string gander)
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM student_info WHERE gander=@gander", con);
                cmd.Parameters.AddWithValue("@gender", gander);
                count = Int32.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
                return count;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return count;
            }
        }

        internal int getCount()
        {
            int count = 0;
            OleDbConnection con = new OleDbConnection(ConnStr);
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM student_info WHERE fee_due=''", con);
                count = Int32.Parse(cmd.ExecuteScalar().ToString());
                con.Close();
                return count;
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.Message, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return count;
            }
        }

        internal void createtimeTable(string inputClass)
        {
            OleDbConnection con = new OleDbConnection(ConnStr);
            con.Open();
            try
            {
                for (int i = 1; i <= 6; i++)
                {
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO timeTable (classDay) "
                        + " Values(@inputClass)";
                    cmd.Parameters.AddWithValue("@inputClass", inputClass+","+i.ToString());
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.StackTrace, "Database Connection Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}