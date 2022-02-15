using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1522022
{
    public partial class Demo_Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string a = Request.Form.Get("tendangnhap");
                string b = Request.Form.Get("matkhau");
                if (a == "admin" && b == "demo")
                {
                    Response.Cookies["tendangnhap"].Value = a;
                    Response.Cookies["tendangnhap"].Expires = DateTime.Now.AddDays(15);
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}