using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAPI.Models;
using System.Text;

namespace WebAPI.Class
{
    public partial class Concloe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] fruits = { "Banana", "Orange", "Apple", "Mango" };
            StringBuilder  text=new StringBuilder ();
            foreach (var item in fruits)
            {
                text.Append(item+"<br>");
            }
            Response.Write(new Stu().GetFullName()+text);
        }
    }
}