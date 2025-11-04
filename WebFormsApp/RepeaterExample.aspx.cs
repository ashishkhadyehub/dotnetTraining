using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class RepeaterExample : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            showgalleryphotos();
        }

        protected void showgalleryphotos()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from Photos", conn))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            rgallery.DataSource = dt;
                            rgallery.DataBind();
                        }
                    }
                }
            }
            catch (Exception es)
            {

            }
        }

        protected void lbtndelete_Click(object sender, EventArgs e)
        {
            try
            {

                RepeaterItem a = (sender as LinkButton).Parent as RepeaterItem;

                int b = int.Parse((a.FindControl("photoid") as Label).Text.ToString());
                con.Close();
                string qrys = "Select ImagePath from Photos where Srno=" + b;
                con.Open();
                SqlCommand cmd1 = new SqlCommand(qrys, con);
                SqlDataReader sdr = cmd1.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    string thumbpath = sdr.GetValue(0).ToString();

                    System.IO.File.Delete(Server.MapPath(thumbpath));
                }

                con.Close();
                string qry = "delete from Photos where Srno=" + b;
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.ExecuteNonQuery();


                showgalleryphotos();

            }
            catch (Exception es)
            {

            }
            finally
            {
                con.Close();
            }
        }
    }
}