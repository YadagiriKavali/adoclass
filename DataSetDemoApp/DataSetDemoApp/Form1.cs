using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSetDemoApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(Helper.ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataTable dt;
        SqlDataAdapter daEmp;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            load_DATA();

            //ds = new DataSet();
            //daEmp = new SqlDataAdapter("Select * from Employe",Helper.ConnectionString);
            //MessageBox.Show(daEmp.SelectCommand.CommandText);
            //daEmp.Fill(ds, "Employe");
            //dt = ds.Tables["Employe"];
            //gvEmp.DataSource = dt;
            //foreach(DataRow dr in dt.Rows)
            //{
            //    cmbId.Items.Add(dr["EmpId"].ToString());

            //}

            //ds = new DataSet();
            //daEmp = new SqlDataAdapter("SELECT* From UserProfile", Helper.ConnectionString);
            //daEmp.Fill(ds, "UserProfile");
            //dt = ds.Tables["UserProfile"];
            //gvEmp.DataSource = dt;
            //foreach(DataRow dr in dt.Rows)
            //{
            //    cmbId.Items.Add(dr["UserId"].ToString());

            //}

            //SqlCommand cmdinsert, cmdUpdate, cmdDelete;
            //SqlConnection con = new SqlConnection(Helper.ConnectionString);
            //cmdinsert = new SqlCommand("Insert into UserProfile values(@UserName,@Password)", con);
            //SqlParameter perName = cmdinsert.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
            //SqlParameter persalary = cmdinsert.Parameters.Add("@Password", SqlDbType.VarChar, 50);
            ////SqlParameter UserId = cmdinsert.Parameters.Add("@UserId", SqlDbType.Int);
            //perName.SourceColumn = "UserName";
            //persalary.SourceColumn = "Password";
            //// UserId.SourceColumn = "UserId";
            //daEmp.InsertCommand = cmdinsert;






            //cmdUpdate = new SqlCommand("update UserProfile set UserName=@UserName,Password=@Password where UserId = @UserId ", con);
            //SqlParameter PerUserName = cmdUpdate.Parameters.Add("@UserName", SqlDbType.VarChar, 50);
            //SqlParameter PerUserPassword = cmdUpdate.Parameters.Add("@Password", SqlDbType.VarChar, 50);
            //SqlParameter UserId = cmdUpdate.Parameters.Add("@UserId", SqlDbType.Int);
            //PerUserName.SourceColumn = "UserName";
            //PerUserPassword.SourceColumn = "Password";
            //UserId.SourceColumn = "UserId";
            //daEmp.UpdateCommand = cmdUpdate;


            //cmdDelete = new SqlCommand("Delete from UserProfile where UserId = @UserId ", con);
            //SqlParameter UserId1 = cmdDelete.Parameters.Add("@UserId", SqlDbType.Int);
            //UserId1.SourceColumn = "UserId";

            //daEmp.DeleteCommand = cmdDelete;



            //SqlCommandBuilder cd = new SqlCommandBuilder(daEmp);
            //cd.ConflictOption = ConflictOption.OverwriteChanges;
            //MessageBox.Show(cd.GetInsertCommand().CommandText);
            //MessageBox.Show(cd.GetUpdateCommand().CommandText);
            //MessageBox.Show(cd.GetDeleteCommand().CommandText);


        }

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow drSelected;
            drSelected = dt.Rows[cmbId.SelectedIndex];
            int id = int.Parse(cmbId.Text);
            DataRow[] dre = dt.Select("UserId=" + id);
            drSelected = dre[0];

            txtName.Text = drSelected["UserName"].ToString();
            if(drSelected.IsNull("Password"))
            {
                txtSlary.Text = "0";

            }
            else
            {
                txtSlary.Text = drSelected["Password"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            daEmp.Update(dt);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow drSelected;
            drSelected = dt.Rows[cmbId.SelectedIndex];
            drSelected.Delete();



        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["UserName"] = txtName.Text;
            dr["Password"] = txtSlary.Text;
            dt.Rows.Add(dr);
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            DataRow drselected;
            drselected = dt.Rows[cmbId.SelectedIndex];
            drselected["UserName"] = txtName.Text;
            drselected["UserPassword"] = txtSlary.Text;

         
        }
        public void clear()
        {
            txtAddresss.Clear();
            txtnamebook.Clear();
            txtnumber.Clear();

        }
        public void load_DATA()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from  register",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            
        }

        private void btnSava_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Helper.ConnectionString);
            //SqlCommand cmd = new SqlCommand("Insert into register values(" +
            //    "'" + txtnamebook.Text + "'," +
            //    "'" + txtnumber.Text + "'," +
            //    "'" + txtAddresss .Text+ "')" +
            //    "", 
            //    con);


            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //MessageBox.Show("Save");
            //load_DATA();
            //clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("Create_Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", txtnamebook.Text));
            cmd.Parameters.Add(new SqlParameter("@PhoneNo", txtnumber.Text));
            cmd.Parameters.Add(new SqlParameter("@Address", txtAddresss.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            load_DATA();
            clear();








        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        int ID = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            txtnamebook.Text= dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtnumber.Text= dataGridView1.CurrentRow.Cells["PhoneNo"].Value.ToString();
            txtAddresss.Text= dataGridView1.CurrentRow.Cells["Address"].Value.ToString();


        }

        private void btnmodify(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.ConnectionString);
            SqlCommand cmd = new SqlCommand("update  register set  Name='" + txtnamebook.Text + "'," +
                "PhoneNo= '" + txtnumber.Text + "',Address='" + txtAddresss.Text + "' where Id='" + ID + "'",con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATED");
            load_DATA();
            clear();


        }

        private void btnDeletes_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete register  where  ID='" + ID + "' ",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DELETED");
            clear();
            load_DATA();



        }

        private void gvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //////SqlDataReader


            //con.Open();
            //SqlCommand cmd = new SqlCommand("select  Name,PhoneNo,Address  from  register where  Id ='" + txtIds.Text + "'", con);
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    lblname.Text = dr["Name"].ToString();
            //    lblPhone.Text = dr["PhoneNo"].ToString();
            //    lblAddress.Text = dr["address"].ToString();

            //}
            //dr.Close();
            //con.Close();


            //DataTable 


            //con.Open();
            //SqlCommand cmd = new SqlCommand("select  Name,PhoneNo,Address  from  register where  Id ='" + txtIds.Text + "'", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            
            //foreach (DataRow row  in  dt.Rows)
            //{
            //    lblname.Text = row["Name"].ToString();
            //    lblPhone.Text = row["PhoneNo"].ToString();
            //    lblAddress.Text = row["address"].ToString();

            //}
          
            //con.Close();


           // DataSet

            con.Open();
            SqlCommand cmd = new SqlCommand("select  Name,PhoneNo,Address  from  register where  Id ='" + txtIds.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                lblname.Text = row["Name"].ToString();
                lblPhone.Text = row["PhoneNo"].ToString();
                lblAddress.Text = row["address"].ToString();

            }

            con.Close();


        }

        private void btnmaxId_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT max(ID) from register", con);
            int maxId = Convert.ToInt32(cmd.ExecuteScalar());
            txtMaxID.Text = maxId.ToString();
            con.Close();





        }
    }
}
