using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orphanage
{
    public partial class sign_up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user id=root;database=orphanage";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();

                string sql = "INSERT INTO users(fname, lname, email, mobile, address, password) values(@fname, @lname, @email, @mobile, @address, @password)";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@mobile", txtmobile.Text);
                cmd.Parameters.AddWithValue("@address", txtAdress.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword1.Text);

                cmd.ExecuteNonQuery();
                Label1.Text = "ok";
                conn.Close();
            }
            catch(MySqlException ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script>");
            }
            
        }
    }
}