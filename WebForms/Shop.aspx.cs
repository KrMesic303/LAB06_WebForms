using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.DatabaseHelpers;

namespace WebForms
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseHelper.LoadArticles(gvArticles);
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            DatabaseHelper.AddArticleToDb(tbArticleName.Text, tbArticleAbout.Text);
            DatabaseHelper.LoadArticles(gvArticles);
        }
    }
}