using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PostBack
{
    public partial class PostBackEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(this.IsPostBack+"<br/>");
            if(IsPostBack)
                Response.Write(TextBox1.Text);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(TextBox1.Text);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("<br/>values : "+TextBox1.Text);
        }
    }
}