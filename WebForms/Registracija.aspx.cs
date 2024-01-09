using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.DatabaseHelpers;

namespace WebForms
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistriraj_Click(object sender, EventArgs e)
        {
            if (!DatabaseHelper.CheckUserInDbExists(tbUsername.Text))
            {
                if (valCheckPassword.IsValid)
                {
                    if (DatabaseHelper.AddUserToDb(tbUsername.Text, tbPassword1.Text, tbFName.Text)) 
                        Response.Redirect("Login.aspx");
                }
            }
            else
            {
                tbUsername.BorderColor = Color.Red;
            }
        }


    }
}