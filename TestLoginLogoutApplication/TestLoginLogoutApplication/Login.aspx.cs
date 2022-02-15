using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestLoginLogoutApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string a = Request.Form.Get("name");
                string b = Request.Form.Get("pass");
                List<KeyValuePair<string, string>> temp = (List<KeyValuePair<string, string>>)Application["login"];
                if (temp.Contains(new KeyValuePair<string, string>(a, b)))
                {
                    Session["name"] = a;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Write("Đăng nhập thất bại, tên đăng nhập hoặc mật khẩu không chính xác!");
                }
            }
        }
    }
}