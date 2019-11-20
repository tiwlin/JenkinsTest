using BranchLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebTest.WcfTest;

namespace WebTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // TODO Test
        }

        protected void btnInvoke_Click(object sender, EventArgs e)
        {
            BranchHelper helper = new BranchHelper();
            helper.InvokeBuild();
        }

        protected void btnWcf_Click(object sender, EventArgs e)
        {
            IUserService service = new UserServiceClient();
            string result = service.GetData(int.Parse(this.txtWcfParam.Text));
            this.lWcfResult.Text = result;
        }
    }
}