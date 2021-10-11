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
    public partial class home : System.Web.UI.MasterPage
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
        }

      

    }
}