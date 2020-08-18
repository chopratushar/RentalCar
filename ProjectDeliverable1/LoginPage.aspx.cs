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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {


            if (TextBox1.Text == "")
            {
                Response.Write("Enter A Username");
               
            }
            else if (TextBox2.Text == "")
            {
                Response.Write("Enter A Valid Password");
                
            }
            else
            {

              if (rbtnCustomer.Checked)
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    string checkuser = "select id from Customer where UserName='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                    SqlCommand cmd = new SqlCommand(checkuser, conn);
                    

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            Session["UserName"] = TextBox1.Text;
                            Session["userid"] = String.Format("{0}", reader["id"]);

                            Response.Redirect("CarRental.aspx");
                        }
                        else
                        {
                            Response.Write("User Name or Password Incorrect");
                        }
                    }
                    conn.Close();




                }
                else if (rbtnAdmin.Checked)
                {
                    if (TextBox1.Text == "admin" && TextBox2.Text == "pass")
                    {

                        Session["UserName"] = TextBox1.Text;
                        Response.Redirect("AddCar.aspx");
                    }
                    else
                    {
                        Response.Write("User Name or Password Incorrect");
                    }
                }
                else
                {
                    Response.Write("Please Select User Type");

                }
            }
        }
    }
}