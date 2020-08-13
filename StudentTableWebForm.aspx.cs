using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace StudentDataTableAssignment
{
    public partial class StudentTableWebForm : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DNNPA9S;Initial Catalog=JulyDotNetBatch2020" +
        ";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public void ShowGrid()
        {
            conn.Open();
            cmd = new SqlCommand("select * from StudentTable", conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            dr.Close();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGrid();
            }
        }

        protected void BtnInsertWithPara_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Insert into StudentTable(StudentRollNo," +
                "StudentName,StudentBranch,StudentGrade)values(@studroll,@studname,@studbranch,@studgrade)", conn);
            cmd.Parameters.AddWithValue("@studroll", 95);
            cmd.Parameters.AddWithValue("@studname", "Jai");
            cmd.Parameters.AddWithValue("@studbranch", "IT");
            cmd.Parameters.AddWithValue("@studgrade", 9.95);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();         
        }

        protected void btnInsertWithSp_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@studroll", txtRollNo.Text.ToString());
            cmd.Parameters.AddWithValue("@studname", txtName.Text.ToString());
            cmd.Parameters.AddWithValue("@studbranch", txtBranch.Text.ToString());
            cmd.Parameters.AddWithValue("@studgrade", txtGrade.Text.ToString());
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnUpdateWithQuotes_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Update StudentTable set " +
                "StudentName='"+txtName.Text+"',StudentBranch='"+txtBranch.Text+"'," +
                "StudentGrade="+txtGrade.Text+" where StudentRollNo="+txtRollNo.Text+"",conn);
            cmd.Parameters.Add("StudentRollNo", SqlDbType.Int).
                Value = Convert.ToInt32(txtRollNo.Text);
            cmd.Parameters.Add("StudentName", SqlDbType.VarChar,20).
                Value = txtName.Text;
            cmd.Parameters.Add("StudentBranch", SqlDbType.VarChar,20).
                Value = txtBranch.Text;
            cmd.Parameters.Add("StudentGrade", SqlDbType.Float).
                Value = Convert.ToSingle(txtGrade.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();

        }

        protected void btnUpdateWithSp_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("sp_update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@studroll", SqlDbType.Int).
               Value = Convert.ToInt32(txtRollNo.Text);
            cmd.Parameters.Add("@studname", SqlDbType.VarChar,20).
                Value = txtName.Text;
            cmd.Parameters.Add("@studbranch", SqlDbType.VarChar,20).
                Value = txtBranch.Text;
            cmd.Parameters.Add("@studgrade", SqlDbType.Float).
                Value = Convert.ToSingle(txtGrade.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            ShowGrid();
        }

        protected void btnDeleteWithQuotes_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnSearchWithQuotes_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select StudentName,StudentBranch,StudentGrade from " +
                "StudentTable where StudentRollNo=" + txtRollNo.Text + "", conn);
            cmd.Parameters.Add("StudentRollNo", SqlDbType.Int).
                Value = Convert.ToInt32(txtRollNo.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr[0].ToString();
                txtBranch.Text = dr[1].ToString();
                txtGrade.Text = dr[2].ToString();
            }
            else
            {
                Label1.Text = "Please enter a valid Student Roll No";
            }
            dr.Close();
            conn.Close();
        }

        protected void btnSearchWithPara_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select StudentName,StudentBranch,StudentGrade from StudentTable where StudentRollNo=@studroll", conn);
            cmd.Parameters.Add("@studroll", SqlDbType.Int).
                Value = Convert.ToInt32(txtRollNo.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = dr[0].ToString();
                txtBranch.Text = dr[1].ToString();
                txtGrade.Text = dr[2].ToString();
            }
            else
            {
                Label1.Text = "Please enter a valid Student Roll No";
            }
            dr.Close();
            conn.Close();
        }
    }

}