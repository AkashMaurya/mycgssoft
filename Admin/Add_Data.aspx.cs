using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CGSSOFT.Admin
{
    public partial class Add_Data : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            // save data
            SaveData();
        }



        private void SaveData()
        {
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('Please Type The Thesis Title');</script>");
                TextBox1.Focus();
            }
            else if (TextBox2.Text == "")
            {
                Response.Write("<script>alert('Please Type The Student Title');</script>");
                TextBox2.Focus();
            }
            else if (TextBox3.Text == "")
            {
                Response.Write("<script>alert('Please Type The First Username');</script>");
                TextBox3.Focus();
            }
            else if (TextBox6.Text == "")
            {
                Response.Write("<script>alert('Please Paste the Link Of View Data URL');</script>");
                TextBox6.Focus();
            }
            else if (TextBox7.Text == "")
            {
                Response.Write("<script>alert('Please Type The Year');</script>");
                TextBox7.Focus();
            }
            else if (TextBox8.Text == "")
            {
                Response.Write("<script>alert('Please Paste the Link Of Download Data URL');</script>");
                TextBox8.Focus();
            }
            else
            {
                string query = "insert into All_Thesis_Data values ('" + DropDownList1.Text + "','" + DropDownList2.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "') ";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Data is Saved is Successfully');</script>");
            }
        }
    }
}