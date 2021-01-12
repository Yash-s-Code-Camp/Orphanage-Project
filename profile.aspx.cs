using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orphanage
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connsStr = "server=localhost;user id=root;database=orphanage";
            MySqlConnection conn = new MySqlConnection(connsStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM users  WHERE email=@email";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", Session["email"].ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    throw new Exception("No data...");
                }
                
                string fname = reader.GetString(1);
                string lname = reader.GetString(2);
                string email = reader.GetString(3);
                string mobile = reader.GetString(4);
                string address = reader.GetString(5);

                txtfname.Text = fname;
                txtlname.Text = lname;
                txtEmail.Text = email;
                txtmobile.Text = mobile;
                txtAdress.Text = address;
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            
        }
    }
}