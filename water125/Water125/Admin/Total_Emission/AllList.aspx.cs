using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FreeTextBoxControls;

namespace Maticsoft.Web.Admin.Total_Emission
{
    public partial class AllList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["strWhereNews"] = "";
            Response.Redirect("index.aspx?page=1");

        }
    }
}
