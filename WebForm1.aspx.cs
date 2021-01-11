using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orphanage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = CheckBox1.Checked ? "Checked" : "Not checked";

            Label1.Text = value;
        }


        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string value = CheckBox1.Checked ? "True" : "False";

            Label1.Text = value;
        }
    }
}