using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CGSSOFT
{
    public partial class login : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con.Close();
                TextBox1.Text = "";
                TextBox2.Text = "";

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // save data
            SaveData();
        }


        private void SaveData()
        {
            string query = "select username,epassword from logindata where username ='" + TextBox1.Text + "'And epassword='" + TextBox2.Text + "' ";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TextBox1.Text == dr["username"].ToString() && TextBox2.Text == dr["epassword"].ToString())
                {
                    Session["username"] = TextBox1.Text;
                    Response.Redirect("~/Admin/Add_Data.aspx");
                }
                else
                {
                    Response.Redirect("<script> alert('Something Wrong in username or Password try Again'); </script>");
                }

            }
            con.Close();
        }

    }
}