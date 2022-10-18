using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee() { EmpID = 1001, EName = "Eena", Designation = "Analyst" });
                employees.Add(new Employee() { EmpID = 1002, EName = "mena", Designation = "Analyst" });
                employees.Add(new Employee() { EmpID = 1003, EName = "dena", Designation = "Analyst" });
                ViewState["EmpData"] = employees;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "You have selected "+ Convert.ToString(Session["Course"])+ " Course";
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = "Your selected value: " + ListBox2.SelectedValue.ToString() + " and text is : a"+ListBox2.SelectedItem.Text;
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            List<string> dataFromSession = (List<string>)Session["Hobbies"];
            ListBox3.DataSource = dataFromSession;
            ListBox3.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie varReadCookie = Request.Cookies["RemindMe"];
            Button3.Text = varReadCookie.Value;

            HttpCookie varPrefCookie = Request.Cookies["Preferences"];
            string cookieValue = varPrefCookie.Value;
            string[] splits = cookieValue.Split(':');

            ApplyColor(splits[0], "BackColor");
            ApplyColor(splits[1], "ForeColor");
        }

        private void ApplyColor(string color , string property)
        {
            System.Drawing.Color resultColor = System.Drawing.Color.White;
            switch (color)
            {
                case "Aqua":
                    resultColor = System.Drawing.Color.Aqua;
                    break;

                case "White":
                    resultColor = System.Drawing.Color.White;
                    break;
                default:
                    resultColor = System.Drawing.Color.Teal;
                    break;
            }
            if (property == "BackColor")
            {
                ListBox3.BackColor = resultColor;
                ListBox2.BackColor = resultColor;

            }
            else if(property == "ForeColor")
            {
                ListBox3.ForeColor = resultColor;
                ListBox2.ForeColor = resultColor;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ViewState["EmpData"];
            GridView1.DataBind();
        }
    }
}