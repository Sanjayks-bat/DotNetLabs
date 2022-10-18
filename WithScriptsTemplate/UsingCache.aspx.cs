using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WithScriptsTemplate
{
    public partial class UsingCache : System.Web.UI.Page
    {
        List<string> names = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                names.Add("Meena");
                names.Add("Mayur");
                ListBox1.DataSource = names;
                ListBox1.DataBind();
                ViewState["list"] = names;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Add the item in the textbox1  to list
            names = (List<string>)ViewState["list"];
            names.Add(TextBox1.Text);

            //Rebind the listbox1
            ListBox1.DataSource = names;
            ListBox1.DataBind();

            //Update the viewstate
            ViewState["names"] = names;

        }
    }
}