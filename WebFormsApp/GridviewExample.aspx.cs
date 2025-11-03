using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class GridviewExample : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                gvdata.DataSource=bindData();
                gvdata.DataBind();
            }
        }

        protected DataSet bindData()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from UserData order by Srno desc", con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into UserData values (@name,@city)", con);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@city", txtcity.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            gvdata.DataSource = bindData();
            gvdata.DataBind();
            txtname.Text = "";
            txtcity.Text = "";
        }

        protected void gvdata_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvdata.EditIndex = e.NewEditIndex;
            gvdata.DataSource = bindData();
            gvdata.DataBind();
        }

        protected void gvdata_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvdata.EditIndex = -1;
            gvdata.DataSource = bindData();
            gvdata.DataBind();
        }

        protected void gvdata_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvdata.Rows[e.RowIndex];
            string name = (row.FindControl("txteName") as TextBox).Text;
            string country = (row.FindControl("txteCountry") as TextBox).Text;
            con.Close();
            SqlCommand cmd = new SqlCommand("Update UserData set Name=@name,Country=@country where Srno='" + gvdata.DataKeys[e.RowIndex].Value + "'", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@country", country);
            con.Open();
            cmd.ExecuteNonQuery();
            
            gvdata.EditIndex = -1;
            gvdata.DataSource = bindData();
            gvdata.DataBind();
        }

        protected void gvdata_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            

            con.Close();
            SqlCommand cmd = new SqlCommand("Delete from UserData where Srno='" + gvdata.DataKeys[e.RowIndex].Value + "'", con);
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            gvdata.EditIndex = -1;
            gvdata.DataSource = bindData();
            gvdata.DataBind();
        }
    }
}