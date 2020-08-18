using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectDeliverable1
{
    public partial class webservice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.QueryString["carid"] != null) {


                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select RentPerDay from Car where ID=" + Request.QueryString["carid"] ;
                SqlCommand cmd = new SqlCommand(checkuser, conn);


                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {                       
                        Response.Write("Rent Per Day = " + String.Format("{0}", reader["RentPerDay"]));

                    }
                    else
                    {
                        Response.Write("No cars Found For Car Id : " + Request.QueryString["carid"]);

                    }
                }
                conn.Close();


            }


        }
    }
}