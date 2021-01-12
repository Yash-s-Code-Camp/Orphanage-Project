using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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


            string connStr = "server=localhost;user id=root;database=orphanage";

            MySqlConnection conn = new MySqlConnection(connStr);

            string sql = "SELECT * FROM users";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataAdapter da = new MySqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();

            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }


        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            string value = CheckBox1.Checked ? "True" : "False";

            Label1.Text = value;
        }
    }
}