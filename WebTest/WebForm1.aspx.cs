using BranchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO Test
            new class();
        }

        protected void btnInvoke_Click(object sender, EventArgs e)
        {
            BranchHelper helper = new BranchHelper();
            helper.InvokeBuild();
        }
    }
}