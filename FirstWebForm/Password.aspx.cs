using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            Random res = new Random();
            string entered = TextBox1.Text;
            int num = int.Parse(entered);
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ@!()abcdefghijklmnopqrstuvwxyz0123456789";
            int charactersLength = characters.Length;
            String result = "";
            for (var i = 0; i < num; i++)
            {
                int x = res.Next(charactersLength);
                result += +characters[x];
            }
            lbl1.Text = result;

        }
    }
}