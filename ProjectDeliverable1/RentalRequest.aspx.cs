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
    public partial class RentalRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null || Session["UserName"].ToString() == "" || Session["UserName"].ToString() != "admin")
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
                                 
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            conn.Open();
            SqlDataAdapter myda = new SqlDataAdapter("Select Customer.Name, Car.Manifacturer, Car.Model, Car.Year, RentalRequest.StartDate, RentalRequest.EndDate, RentalRequest.ID, RentalRequest.Note, RentalRequest.Approved, Car.RentPerDay From Customer, Car, RentalRequest where RentalRequest.Customer_ID = Customer.ID  and  RentalRequest.Car_ID = Car.ID", conn);
            DataTable ds = new DataTable();
            myda.Fill(ds);
            gv.DataSource = ds;
            gv.DataBind();
            conn.Close();

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gvrow in gv.Rows)
            {

                var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                if (checkbox.Checked)
                {
                    var lblID = gvrow.FindControl("Label1") as Label;

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    string insertQuery = "update RentalRequest set Approved = 'Y', Note = 'Acepted' where RentalRequest.ID = "+ lblID.Text;
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                 
                    cmd.ExecuteNonQuery();
                    FillDropDownList();

                }
            }
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gvrow in gv.Rows)
            {

                var checkbox = gvrow.FindControl("CheckBox1") as CheckBox;
                if (checkbox.Checked)
                {
                    var lblID = gvrow.FindControl("Label1") as Label;

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
                    conn.Open();
                    string insertQuery = "update RentalRequest set Approved = 'N', Note = 'Car in maintanance' where RentalRequest.ID = " + lblID.Text;
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);

                    cmd.ExecuteNonQuery();
                    FillDropDownList();

                }
            }
        }
    }
}