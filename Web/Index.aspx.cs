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

namespace Maticsoft.Web
{
    public partial class Index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // Initalize();
            }

        }
        protected void Initalize()
        {
            //this.NewsList1.MyClassId = 4;
            //this.NewsList1.MyintTop = 5;
            //this.NewsList1.MyTitleLenth = 18;
        }
    }
}