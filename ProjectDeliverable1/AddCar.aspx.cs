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
    public partial class AddCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserName"] == null || Session["UserName"].ToString() == "" || Session["UserName"].ToString() != "admin")
            {
                Response.Write("<script>alert('Invalid Session')</script>");
                Response.Redirect("LoginPage.aspx");
            }

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnRequest_Click(object sender, EventArgs e)
        {
            Response.Redirect("RentalRequest.aspx");
        }

        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "")
            {
                Response.Write("Enter  Color");

            }
            else if (TextBox2.Text == "")
            {
                Response.Write("Enter RentPerDay");

            }
            else if (TextBox1.Text == "")
            {
                Response.Write("Enter A Manifacturer");

            }
            else if (TextBox3.Text == "")
            {
                Response.Write("Enter Model");

            }
            else if (TextBox5.Text == "")
            {
                Response.Write("Enter Year");

            }
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    string insertQuery = "insert into Car(Manifacturer,Model,Year,Color,RentPerDay)values (@Manifacturer,@Model,@Year,@Color,@RentPerDay)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Manifacturer", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Model", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Year", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@Color", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@RentPerDay", TextBox2.Text);
                    cmd.ExecuteNonQuery();

                    TextBox4.Text = "";
                    TextBox3.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Text = "";
                    TextBox5.Text = "";
                    Response.Write("Car Added Successfully!!!thank you");

                    conn.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("error" + ex.ToString());
                }
            }
        }
    }
}