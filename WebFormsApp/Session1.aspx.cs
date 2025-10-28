﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class Session1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Session["Name"]= txtName.Text;
            Session["Contact"]= txtContact.Text;
            //20 minutes session timeout
            //Session.Timeout = 60;
            Response.Redirect("Session2.aspx");
        }
    }
}