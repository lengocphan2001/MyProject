using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1522022
{
    public partial class Demo_Applicaion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                List<string> temp = (List<string>)Application["login"];
                string ten = Request.Form.Get("tendangnhap");
                if (temp.Contains(ten))
                {
                    Session["nowlogin"] = ten;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    temp.Add(ten);
                    Application["tendangnhap"] = temp;
                }
            }
        }
    }
}