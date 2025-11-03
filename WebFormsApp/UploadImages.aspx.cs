using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class UploadImages : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnUpload_Click(object sender, EventArgs e)
        {
            foreach (var file in fileUploadImage.PostedFiles)
            {
                string extension = System.IO.Path.GetExtension(file.FileName);
                Guid id = Guid.NewGuid(); //8999-hjhjh-hhjhj.jpg
                string filename = id.ToString() + extension;
                string imagePath = "Photos/" + filename;
                file.SaveAs(Server.MapPath(imagePath));

                con.Close();
                SqlCommand cmd = new SqlCommand("insert into Photos values (@path,@date)",con);
                cmd.Parameters.AddWithValue("@path", imagePath);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                con.Open();
                cmd.ExecuteNonQuery();

                this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Photo/Photos Uploaded,Thank you!','','success');", true);

            }
        }
    }
}