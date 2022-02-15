using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestLoginLogoutApplication
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] != null)
                Response.Write("Xin chào: " + Session["name"]);
            else Response.Write("Bạn chưa có tài khoản!");
        }
    }
}