using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffName AName = new StaffName();
        AName = Session["AName"] as StaffName;
        Response.Write*AName.StaffID);
    }
}