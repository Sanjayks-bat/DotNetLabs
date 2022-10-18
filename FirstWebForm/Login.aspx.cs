using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            btn.Text = "Submitted Successfully!";
            Session["Course"] = DropDownList1.Text;
            Session["Hobbies"] = new List<string>() { "Cricket", "Football" };

            //Cookie creation
            HttpCookie cookie = new HttpCookie("RemindMe");
            cookie.Value = "To attend Townhall session";
            cookie.Expires = DateTime.Now.AddDays(1);
            

            HttpCookie preFCookie = new HttpCookie("Preferences");
            preFCookie.Value = "Aqua:White";
            preFCookie.Expires = DateTime.Now.AddDays(1);

            Response.Cookies.Add(cookie);
            Response.Cookies.Add(preFCookie);
        }
    }
}