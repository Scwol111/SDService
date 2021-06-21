using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SDS_LIB;

namespace SDS_webapp
{
    public partial class Main : System.Web.UI.MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("Main.aspx", true);
            }
            catch { }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("Parametrs.aspx", true);
            }
            catch { }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("Account.aspx", true);
            }
            catch { }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            try 
            {
                Server.Transfer("Normes.aspx", true);
            }
            catch { }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("AdditionalParams.aspx", true);
            }
            catch { }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Server.Transfer("login.aspx", true);
            }
            catch { }
        }
    }
}