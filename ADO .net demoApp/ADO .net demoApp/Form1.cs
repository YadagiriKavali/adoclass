using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace ADO.net_demoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {

                con.ConnectionString = Helper.ConnectionString;// "Server=.;database=GOT;integrated security=true";
                con.Open();
                MessageBox.Show("Opened");
                            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed " + ex);
            }
            finally
            {
                con.Close();
            }

            //poollling  connection Exsting Connection  



        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Helper.ConnectionString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection= con;
            //try
            //{
            //    string sql = string.Format("Insert into Employe values('{0}','{1}')",txtname.Text.Replace("'","''"),txtSalary.Text);
            //    cmd.CommandText = sql;
            //    // cmd.CommandText = CommandType.Text;
            //    con.Open();
            //  cmd.ExecuteNonQuery();
            //    cmd.CommandText = "Select  @@identity";
            //    int id = Convert.ToInt32(cmd.ExecuteScalar());
            //    txtid.Text = id.ToString();

            //    MessageBox.Show(sql+""+" SuccessFully row Effected"+""+id);

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Internal server Down");
            //}
            //finally
            //{
            //     con.Close();
            //}
            try
            {
                SqlConnection con = new SqlConnection(Helper.ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                string sql = string.Format("Insert into Employe values('{0}','{1}')", txtname.Text.Replace("'", "''"), txtSalary.Text);
                cmd.CommandText = sql;
                MessageBox.Show("Success");
                con.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@Identity";
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                txtid.Text = id.ToString();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Not Perpaer"+ex);
            }
           

           



        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                string sql = string.Format("Update  Employe Set EmpName='{0}',EmpSalary='{1}' where  EmpId={2}", txtname.Text.Replace("'", "''"), txtSalary.Text,txtid.Text);
                cmd.CommandText = sql;
                // cmd.CommandText = CommandType.Text;
                con.Open();
               cmd.ExecuteNonQuery();
                MessageBox.Show(sql + "" + " SuccessFully row Effected");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Internal server Down");
            }
            finally
            {
                con.Close();
            }


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            try
            {
                string sql = string.Format("Delete  from  Employe where  EmpId={0}", txtid.Text);
                cmd.CommandText = sql;
                // cmd.CommandText = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(sql + "" + " SuccessFully row Effected");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Internal server Down");
            }
            finally
            {
                con.Close();
            }

        }

        private void btnGetAllEmp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employe ", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string s = "";
         
            while (dr.Read())
            {
                s += dr[0] + "\t" + "\t";
                s += dr[1] + "\t"+ "\t";
                s += dr[2] + "\n";

            }
            MessageBox.Show(s);
            dr.Close();
            con.Close();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employe Where EmpSalary > "+txtSalfilter.Text, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string s = "";

            while (dr.Read())
            {
                s += dr[0] + "\t" + "\t";
                s += dr[1] + "\t" + "\t";
                s += dr[2] + "\n";

            }
            MessageBox.Show(s);
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 1

            //try
            //{
            //    SqlConnection con = new SqlConnection(Helper.ConnectionString);
            //    string sql = string.Format("SELECT count(*) from UserProfile Where  UserName = '{0}' and Password = '{1}'", txtUsername.Text, txtpassword.Text);
            //    SqlCommand cmd = new SqlCommand(sql, con);
            //    MessageBox.Show(sql);
            //    con.Open();
            //    int count = Convert.ToInt32(cmd.ExecuteScalar());
            //    con.Close();
            //    if (count == 0)
            //    {
            //        MessageBox.Show("Invailed UserName Password");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Well ADO DotNet");
            //    }
            //}catch(Exception ex)
            //{
            //    MessageBox.Show("Error "+ex);
            //}


            // 2

            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            string sql = string.Format("Select UserId,Password from UserProfile Where UserName='{0}'", txtUsername.Text);
            SqlCommand cmd = new SqlCommand(sql, con);

            // MessageBox.Show(sql);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() && dr["Password"].ToString() == txtpassword.Text)
            {
                MessageBox.Show("WllCometo ADO DotNet");
            }
            else
            {
                MessageBox.Show("Invailed Password");
            }
            dr.Close();
            con.Close();


            //3


            //SqlConnection con = new SqlConnection(Helper.ConnectionString);

            //// The SqlCommand constructor expects the command text and connection as parameters
            //SqlCommand cmd = new SqlCommand("SELECT UserId, Password FROM UserProfile WHERE UserName = @UserName", con);

            //// Add parameter to prevent SQL injection and provide the value later
            //cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);

            //try
            //{
            //    con.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();

            //    if (dr.Read() && dr["Password"].ToString() == txtpassword.Text)
            //    {
            //        MessageBox.Show("Welcome to ADO.NET");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Password");
            //    }

            //    dr.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void btnFornKey_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString + ";MultipleActiveResultSets=True");
            string sql = string.Format("Select * from  Department",con);
            SqlCommand cmd = new SqlCommand(sql,con);
          
           
            MessageBox.Show(sql);
          
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            string s = "";
            while (dr.Read())
            {
                object deptid = dr["DeptId"];
                object deptName = dr["DeptName"];
               SqlCommand cmdemp=new SqlCommand("select * from Empdept Where DeptId=" +deptid,con);

                SqlDataReader drEmployee = cmdemp.ExecuteReader();
                while(drEmployee.Read()){
                    s += deptid+  "\t";
                    s += deptName + "\t";
                  
                    s += drEmployee["EmpId"] + "\t"+"\t";
                    s += drEmployee["EmpName"] + "\t";
                    s += drEmployee["Empsalary"] +  "\n";
                  
                 

                    
                }
                drEmployee.Close();

                //s += dr[0] + "\t";
                //s += dr[1] + "\n";
               
            }
            dr.Close();
            con.Close();
            MessageBox.Show(s);
            
        }
        byte[] buffer=null;
        private void btnpicbroser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                FileStream fc = new System.IO.FileStream(dlg.FileName, System.IO.FileMode.Open);
                buffer = new byte[fc.Length];
                fc.Read(buffer, 0, buffer.Length);
                fc.Close();
                pictureBox1.Load(dlg.FileName);
            }

        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(Helper.ConnectionString);
                string sql = "Insert into Employe Values(@EmpName,@EmpSalary,@Photo);Select  @EmpId=@@identity";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter Empname = new SqlParameter("@EmpName", SqlDbType.VarChar, 50);
                SqlParameter EmpSalary = new SqlParameter("@EmpSalary", SqlDbType.Money);
                SqlParameter Empid = new SqlParameter("@EmpId", SqlDbType.Int);
                SqlParameter Photo = new SqlParameter("@Photo", SqlDbType.Image);
                Empid.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(Empname);
                cmd.Parameters.Add(EmpSalary);
                cmd.Parameters.Add(Empid);
                cmd.Parameters.Add(Photo);
                Empname.Value = txtname.Text;
                EmpSalary.Value = txtSalary.Text;
                if (buffer != null)
                {
                    Photo.Value = buffer;
                }
                else
                {
                    Photo.Value = DBNull.Value;
                }
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtid.Text = Empid.Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }



        }

        private void btnGetpicfromDb(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection(Helper.ConnectionString);
                string sql = " select Photo  From    Employe  Where EmpId=" + txtGetIdBasePic.Text;
                SqlCommand cmd = new SqlCommand(sql,con);
                con.Open();

                byte[] buffer = (byte[])cmd.ExecuteScalar();
                con.Close();
                MemoryStream ms = new MemoryStream(buffer);
                pictureBox1.Image = new Bitmap(ms);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error"+Ex);
            }

            }
    }
}
