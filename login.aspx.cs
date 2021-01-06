using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orphanage
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Text.Equals("yddc902@gmail.com") && txtpassword.Text.Equals("123"))
            {
                lblstatus.Text = "Logged in";
            }
            else
            {
                lblstatus.Text = "Invalid Auhentication";
            }
           
        }
    }
}