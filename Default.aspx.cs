using System;

namespace SimpleAspNetApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Time now: " + DateTime.Now.ToString();
        }
    }
}
