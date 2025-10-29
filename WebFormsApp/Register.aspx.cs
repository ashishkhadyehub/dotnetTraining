﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class Register : System.Web.UI.Page
    {
        //1.Design UI form
        //2.Create DB table
        //3.Apply required validations to UI form
        //4.Create connectionstring in web.config
        //5.Create connection class object in back end
        //6.Write ado.net code to insert data into DB table

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Users values (@name,@contact,@email,@city)",con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@city", ddlCities.SelectedItem.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            ddlCities.SelectedIndex = 0;
            Response.Write("<script>alert('Registration Successful');</script>");

        }
    }
}