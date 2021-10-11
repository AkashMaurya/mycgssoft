using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;


namespace CGSSOFT.Admin
{
    public partial class View_Data : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "";
                showGrid();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            searchByText();
        }


       
        protected void Button1_Click(object sender, EventArgs e)
        {
            // print document in PDF

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Vithal_Wadje.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            GridView1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
            pdfDoc.Open();
            htmlparser.Parse(sr);
            pdfDoc.Close();
            Response.Write(pdfDoc);
            Response.End();
            GridView1.AllowPaging = true;
            GridView1.DataBind();




        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void searchByText()
        {
            // Fulltext Search including no (change int to string for year )

            if (TextBox1.Text == "")
            {
                showGrid();
            }
            else
            {
                string query = " Select * From All_Thesis_Data where freetext (*, '%" + TextBox1.Text + "%')";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.Visible = true;
                            GridView1.DataBind();
                        }
                    }
                }

            }



        }


        private void showGrid()
        {
            string query = "Select * From All_Thesis_Data ";

            TextBox1.Text = "";


            using (SqlCommand cmd = new SqlCommand(query, con))
            {

                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.Visible = true;
                        GridView1.DataBind();
                    }
                }
            }
        }

     
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label1.Text = "";
            GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label1.Text = "";
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label Id = GridView1.Rows[e.RowIndex].FindControl("Label11") as Label;
            TextBox Thesis_Type = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox Department = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox ThesisTitle = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox StudentName = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            TextBox First_Supervisor = GridView1.Rows[e.RowIndex].FindControl("TextBox6") as TextBox;
            TextBox Second_Supervisor = GridView1.Rows[e.RowIndex].FindControl("TextBox7") as TextBox;
            TextBox Ext_Supervisor = GridView1.Rows[e.RowIndex].FindControl("TextBox8") as TextBox;
            TextBox Files = GridView1.Rows[e.RowIndex].FindControl("TextBox9") as TextBox;
            TextBox EYear = GridView1.Rows[e.RowIndex].FindControl("TextBox10") as TextBox;
            TextBox DFILE = GridView1.Rows[e.RowIndex].FindControl("TextBox11") as TextBox;


            String updatedata = "Update All_Thesis_Data set Thesis_Type='" + Thesis_Type.Text + "', Department='" + Department.Text + "', ThesisTitle='" + ThesisTitle.Text + "',StudentName='" + StudentName.Text + "',First_Supervisor='" + First_Supervisor.Text + "',Second_Supervisor='" + Second_Supervisor.Text + "',Ext_Supervisor='" + Ext_Supervisor.Text + "',Files='" + Files.Text + "',EYear='" + EYear.Text + "',DFILE='" + DFILE.Text + "' where Id=" + Id.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "Row Data Has Been Updated Successfully";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();

        }

     

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label Id = GridView1.Rows[e.RowIndex].FindControl("Label2") as Label;
          
            String updatedata = "delete from All_Thesis_Data where id=" + Id.Text;
           
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "Row Data Has Been Deleted Successfully";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            //Insert Data in GridView
            TextBox Thesis_Type = GridView1.FooterRow.FindControl("TextBox12") as TextBox;
            TextBox Department = GridView1.FooterRow.FindControl("TextBox13") as TextBox;
            TextBox ThesisTitle = GridView1.FooterRow.FindControl("TextBox14") as TextBox;
            TextBox StudentName = GridView1.FooterRow.FindControl("TextBox15") as TextBox;
            TextBox First_Supervisor = GridView1.FooterRow.FindControl("TextBox16") as TextBox;
            TextBox Second_Supervisor = GridView1.FooterRow.FindControl("TextBox17") as TextBox;
            TextBox Ext_Supervisor = GridView1.FooterRow.FindControl("TextBox18") as TextBox;
            TextBox Files = GridView1.FooterRow.FindControl("TextBox19") as TextBox;
            TextBox EYear = GridView1.FooterRow.FindControl("TextBox21") as TextBox;
            TextBox DFILE = GridView1.FooterRow.FindControl("TextBox12") as TextBox;


            String query = "insert into All_Thesis_Data  values ('" + Thesis_Type.Text + "','" + Department.Text + "','" + ThesisTitle.Text + "','" + StudentName.Text + "','" + First_Supervisor.Text + ",'" + Second_Supervisor.Text + ",'" + Ext_Supervisor.Text + ",'" + Files.Text + ",'" + EYear.Text + ",'" + DFILE.Text + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "New Row Inserted Successfully";
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.SelectedIndex = -1;
            this.searchByText();
        }
    }
}