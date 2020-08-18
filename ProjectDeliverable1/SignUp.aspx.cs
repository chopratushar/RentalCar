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
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from Customer where UserName='" + TextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                if (temp == 1)
                {
                    Response.Write("Student Already Exist");
                }

                conn.Close();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "")
            {
                Response.Write("Enter A Username");

            }
            else if (TextBox2.Text == "")
            {
                Response.Write("Enter A Valid Password");

            }
            else if (TextBox1.Text == "")
            {
                Response.Write("Enter A Name");

            }
            else if (TextBox3.Text == "")
            {
                Response.Write("Enter Address");

            }
            else if (TextBox5.Text == "")
            {
                Response.Write("Enter Occupation");

            }
            else
            {
                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    string insertQuery = "insert into Customer(UserName,Password,Name,Address,Occupation)values (@username,@password,@name,@address,@occu)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@username", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@address", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@occu", TextBox5.Text);
                    cmd.ExecuteNonQuery();
                    TextBox4.Text = "";
                    TextBox3.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Text = "";
                    TextBox5.Text = "";

                    Response.Write("Customer registeration Successfully!!!thank you");

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