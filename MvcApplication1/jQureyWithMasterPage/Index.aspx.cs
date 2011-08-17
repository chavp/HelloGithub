using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jQureyWithMasterPage
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SendCommand_Click(object sender, EventArgs e)
        {

            string user = Request.Form["user"];
            string firstname = Request.Form["firstname"];
            //TODO: ทำ logic ของคุณต่อไป ...
        }
    }
}