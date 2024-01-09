using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.DatabaseHelpers;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            
            //provjera podataka u bazi:
            if (!DatabaseHelper.CheckUsernamePassword(tbUsernameLogin.Text, tbPasswordLogin.Text))
            {
                tbLoginError.Visible = true;
            }
            else
            {     
                //ako su podatci točni, preusmjeriti na Shop.aspx
                Response.Redirect("Shop.aspx");
            }


        }
    }
}