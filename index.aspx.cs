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
    public partial class index : System.Web.UI.Page
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                con.Close();
                showGrid();
                if (TextBox1.Text == "")
                {
                    showGrid();
                }
                findView();
                updatecounter();
                // Label1.Text = "Displaying Page " + (GridView1.PageIndex + 1).ToString() + "of " + GridView1.PageCount.ToString();

            }
        }



        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            searchByText();
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
                string query = " Select Distinct [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor],[Files],[EYear] From All_Thesis_Data where freetext (ThesisTitle, '%" + TextBox1.Text + "%') OR freetext (StudentName, '%" + TextBox1.Text + "%') OR freetext (First_Supervisor,'%" + TextBox1.Text + "%') OR freetext (Second_Supervisor,'%" + TextBox1.Text + "%') OR freetext (Ext_Supervisor, '%" + TextBox1.Text + "%') OR freetext (EYear, '%" + TextBox1.Text + "%') ";

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
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
            }
        }



        private void showGrid()
        {
            string query = "Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data ";

            TextBox1.Text = "";
            DropDownList2.SelectedIndex = 0;

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




        private void findView()
        {
            String query = "Select * from viewsite";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Label2.Text = "Website View Counter :" + ds.Tables[0].Rows[0]["viewsite"].ToString();
            con.Close();

        }


        private void updatecounter()
        {
            String updatedata = "update viewsite set viewsite = viewsite+1";
            con.Open();
            SqlCommand cmd = new SqlCommand(updatedata, con);
            cmd.CommandText = updatedata;
            cmd.ExecuteNonQuery();
            con.Close();
        }





        //Phd Thesis
        private void SearchByPhdThesis()
        {

            string query = "Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Thesis_Type ='PHD Thesis' ";

            TextBox1.Text = "";
            DropDownList2.SelectedIndex = 0;

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
                        //GridView1.PageIndex = e.NewPageIndex;
                        GridView1.SelectedIndex = -1;
                        GridView1.DataBind();
                    }
                }
            }
        }


        //master thesis
        private void SearchByMasterThesis()
        {

            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Thesis_Type ='Master Thesis' ";
            TextBox1.Text = "";
            DropDownList2.SelectedIndex = 0;

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






        /// <summary>
        /// Start The CODE FOR FILTER DATA
        /// </summary>


        //DropDownList 2 Coding Starts
        //search by LEARNING & DEVELOPMENT
        private void LEARNING_DEVELOPMENT()
        {
            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='DEPARTMENT OF LEARNING AND DEVELOPMENTAL DISABILITIES' ";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;

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
                        TextBox1.Text = "";
                    }
                }
            }
        }




        //search by  DISTANCE_LEARNING
        private void DISTANCE_LEARNING()
        {
            string query = " Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='DEPARTMENT OF DISTANCE LEARNING' ";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;

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
                        TextBox1.Text = "";
                    }
                }

            }
        }

        //search by NATURAL_RESOURCE 
        private void NATURAL_RESOURCE()
        {
            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='DEPARTMENT OF NATURAL RESOURCES AND ENVIRONMENT' ";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;
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
                        TextBox1.Text = "";
                    }
                }
            }
        }


        private void LIFE_SCIENCES()
        {
            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='DEPARTMENT OF LIFE SCIENCES' ";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;
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
                        TextBox1.Text = "";
                    }
                }
            }
        }


        // Search by GEOINFORMATICS
        private void GEOINFORMATICS()
        {
            //DPT. DEPARTMENT OF GEOINFORMATICS
            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='DEPARTMENT OF GEOINFORMATICS' ";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;

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
                        TextBox1.Text = "";
                    }
                }
            }
        }


        //Search by GIFTED_EDUCATION
        private void GIFTED_EDUCATION()
        {
            // DPT. DEPARTMENT OF GIFTED EDUCATION
            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='DEPARTMENT OF GIFTED EDUCATION' ";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;

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
                        TextBox1.Text = "";
                    }
                }
            }
        }

        //Search by Technology_and_Innovation
        private void Technology_and_Innovation()
        {
            //DPT. Department of Technology and Innovation Management
            string query = "  Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data where Department ='Department of Technology and Innovation Management' ";

            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;

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
                        TextBox1.Text = "";
                    }
                }
            }
        }

        private void All_Department_Thesis()
        {

            string query = "Select [Thesis_Type] ,[Department]  ,[ThesisTitle]  ,[StudentName]  ,[First_Supervisor]   ,[Second_Supervisor],[Ext_Supervisor]  ,[Files]     ,[EYear] From All_Thesis_Data ";

            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;

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





        protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {


            if (TextBox1.Text != "")
            {


                GridView1.PageIndex = e.NewPageIndex;
                //GridView1.SelectedIndex = -1;
                this.searchByText();

            }

            else if (DropDownList1.SelectedIndex == 1)
            {
                //all Thesis type

                GridView1.PageIndex = e.NewPageIndex;
                //GridView1.SelectedIndex = -1;
                showGrid();
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                //search by phd
                // TextBox1.Text = "";
                // DropDownList2.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                // GridView1.SelectedIndex = -1;
                SearchByPhdThesis();

            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                //search by master
                // TextBox1.Text = "";
                //DropDownList2.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                // GridView1.SelectedIndex = -1;
                SearchByMasterThesis();
            }



            // Dropdownlist 2 starts here

            else if (DropDownList2.SelectedIndex == 1)
            {
                //All Department Theis Data
                GridView1.PageIndex = e.NewPageIndex;
                // GridView1.SelectedIndex = -1;
                this.All_Department_Thesis();
            }


            else if (DropDownList2.SelectedIndex == 2)
            {
                //all LEARNING_DEVELOPMENT
                //TextBox1.Text = "";
                //DropDownList1.SelectedIndex = 0;

                GridView1.PageIndex = e.NewPageIndex;
                // GridView1.SelectedIndex = -1;
                this.LEARNING_DEVELOPMENT();
            }

            else if (DropDownList2.SelectedIndex == 3)
            {
                //all DISTANCE_LEARNING
                // TextBox1.Text = "";
                //DropDownList1.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                // GridView1.SelectedIndex = -1;
                this.DISTANCE_LEARNING();
            }

            else if (DropDownList2.SelectedIndex == 4)
            {
                //All NATURAL_RESOURCE
                // TextBox1.Text = "";
                //DropDownList1.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                //GridView1.SelectedIndex = -1;
                this.NATURAL_RESOURCE();
            }

            else if (DropDownList2.SelectedIndex == 5)
            {
                //All Life_Science
                // TextBox1.Text = "";
                // DropDownList1.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                // GridView1.SelectedIndex = -1;
                this.LIFE_SCIENCES();
            }



            else if (DropDownList2.SelectedIndex == 6)
            {
                //All GEOINFORMATICS
                //TextBox1.Text = "";
                //DropDownList1.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                //GridView1.SelectedIndex = -1;
                this.GEOINFORMATICS();
            }


            else if (DropDownList2.SelectedIndex == 7)
            {
                //All GIFTED_EDUCATION
                //TextBox1.Text = "";
                //DropDownList1.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                //GridView1.SelectedIndex = -1;

                this.GIFTED_EDUCATION();
            }

            else if (DropDownList2.SelectedIndex == 8)
            {
                //All Technology_and_Innovation
                //TextBox1.Text = "";
                // DropDownList1.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;

                //GridView1.SelectedIndex = -1;
                this.Technology_and_Innovation();
            }



            else
            {
                //all thesis by default on page load
                //TextBox1.Text = "";
                //DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                GridView1.PageIndex = e.NewPageIndex;
                //GridView1.SelectedIndex = -1;
                this.showGrid();
            }


        }



        //for PHD AND MASTER THEIS DROPDOWN Code
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 1)
            {
                showGrid();
            }

            else if (DropDownList1.SelectedIndex == 2)
            {
                SearchByPhdThesis();
            }

            else if (DropDownList1.SelectedIndex == 3)
            {
                SearchByMasterThesis();
            }
        }



        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (DropDownList2.SelectedIndex == 1)
            {
                //All_Department_Thesis
                All_Department_Thesis();
            }

            // For Learning and Desibilities
            else if (DropDownList2.SelectedIndex == 2)
            {
                LEARNING_DEVELOPMENT();
                //DropDownList1.SelectedIndex = 0;
            }


            // for DISTANCE_LEARNING
            else if (DropDownList2.SelectedIndex == 3)
            {
                DISTANCE_LEARNING();
                // DropDownList1.SelectedIndex = 0;
            }


            //for NATURAL_RESOURCE
            else if (DropDownList2.SelectedIndex == 4)
            {
                NATURAL_RESOURCE();
                //DropDownList1.SelectedIndex = 0;
            }



            //for LIFE_SCIENCES
            else if (DropDownList2.SelectedIndex == 5)
            {
                LIFE_SCIENCES();
                // DropDownList1.SelectedIndex = 0;
            }


            // for GEOINFORMATICS
            else if (DropDownList2.SelectedIndex == 6)
            {
                GEOINFORMATICS();
                // DropDownList1.SelectedIndex = 0;
            }


            // for GIFTED_EDUCATION
            else if (DropDownList2.SelectedIndex == 7)
            {
                GIFTED_EDUCATION();
                //DropDownList1.SelectedIndex = 0;
            }


            // for Technology_and_Innovation
            else if (DropDownList2.SelectedIndex == 8)
            {
                Technology_and_Innovation();
                //DropDownList1.SelectedIndex = 0;
            }



        }

    }
}