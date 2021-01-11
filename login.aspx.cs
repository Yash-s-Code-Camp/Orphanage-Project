using MySql.Data.MySqlClient;
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
            string connsStr = "server=localhost;user id=root;database=orphanage";

            MySqlConnection conn = new MySqlConnection(connsStr);

            try
            {

                conn.Open();

                string sql = "SELECT * FROM users  WHERE email=@email and password=@password";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                
                //lblstatus.Text = reader.ToString();

                if (!reader.Read())
                {
                    throw new Exception("No data...");
                }

                //int emailID = reader.GetOrdinal("email"); //3
                //int passwordID = reader.GetOrdinal("password"); //6

                string email = reader.GetString(3);
                string password = reader.GetString(6);

                if (txtemail.Text.Equals(email) && txtpassword.Text.Equals(password))
                {
                    Session["email"] = email;
                    Response.Redirect("dashboard.aspx");
                }
                else
                {
                    lblstatus.Text = "Invalid Auhentication";
                    lblstatus.Text = ""+ email+" "+password;
                }
            }
            catch(Exception ex)
            {
                lblstatus.Text = ex.Message;
            }



        }
    }
}