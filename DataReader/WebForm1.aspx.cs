using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace DataReader
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=PRADEEP\\SQLEXPRESS;Initial Catalog=product;Integrated Security=true"))
            {
                SqlCommand cmd = new SqlCommand("select Name,UnitPrice,QtyAvailable,(UnitPrice * QtyAvailable) as Price from tblProduct", con);
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();

                }

            }

        }
    }
}