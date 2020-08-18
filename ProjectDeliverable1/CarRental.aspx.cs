using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectDeliverable1
{
    public partial class CarRental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Session["userid"] == null ||  Session["UserName"] == null ||  Session["UserName"].ToString() == "" || Session["userid"].ToString() == "" )
            {
                Response.Write("<script>alert('Invalid Session')</script>");
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                FillDropDownList();
            }
        }

        private void FillDropDownList()
        {


            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            SqlDataAdapter myda = new SqlDataAdapter("Select ID,Manifacturer  FROM Car", conn);
            myda.Fill(ds);
            DropDownList2.DataSource = ds;
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("Select", "0"));
            conn.Close();

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            SqlDataAdapter myda = new SqlDataAdapter("Select ID, Year FROM Car where Model='" + DropDownList1.SelectedItem.Text + "'", conn);
            myda.Fill(ds);
            DropDownList3.DataSource = ds;          
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, new ListItem("Select", "0"));
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Response.Write("<script>alert('" + DropDownList2.SelectedItem.Text + "')</script>");
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            SqlDataAdapter myda = new SqlDataAdapter("Select ID , Model FROM Car where Manifacturer='" + DropDownList2.SelectedItem.Text + "'", conn);
            myda.Fill(ds);
            DropDownList1.DataSource = ds;
            
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Select", "0"));

        }

        protected void btnRequest_Click(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedItem.Value == "0")
            {
                Response.Write("Select Year");

            }
            else if (StartDate.SelectedDate.ToString() == "") {
                Response.Write("Select Start Date");
            }
            else if (EndDate.SelectedDate.ToString() == "")
            {
                Response.Write("Select Start Date");
            }
            else
            {
                try
                {


                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    string insertQuery = "insert into RentalRequest(StartDate,EndDate,Car_ID,Customer_ID)values (@StartDate,@EndDate,@CarID,@Customer_ID)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.SelectedDate.ToString());
                    cmd.Parameters.AddWithValue("@EndDate", EndDate.SelectedDate.ToString());
                    cmd.Parameters.AddWithValue("@CarID", DropDownList2.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@Customer_ID", Session["userid"]);

                    cmd.ExecuteNonQuery();

                    DropDownList2.SelectedValue = "0";
                    DropDownList1.SelectedValue = "0";
                    DropDownList3.SelectedValue = "0";
                    Response.Write("Request Added Successfully!!!thank you");

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