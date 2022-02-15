using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestLoginLogoutApplication
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                List<KeyValuePair<string, string>> temp = (List<KeyValuePair<string, string>>)Application["login"];
                string a = Request.Form.Get("tendn");
                string b = Request.Form.Get("pass");
                string c = Request.Form.Get("repass");
                if (b != c)
                {
                    Response.Write("Mật khẩu không trùng khớp!");
                }
                else
                {
                    bool check = false;
                    foreach(KeyValuePair<string, string> cur in temp)
                    {
                        if (cur.Key == a)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (check)
                    {
                        Response.Write("Tên đăng nhập đã tồn tại!");
                    }
                    else
                    {
                        Session["name"] = a;
                        temp.Add(new KeyValuePair<string, string>(a, b));
                        Application["login"] = temp;
                        Response.Redirect("Home.aspx");
                    }
                }
            }
        }
    }
}