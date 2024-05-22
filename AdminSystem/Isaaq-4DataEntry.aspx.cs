using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object AnAddress;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btmConfirm_Click(object sender, EventArgs e)
    {
        //create a new instance of clsClass
        clsAddress clsAddress = new clsAddress();
        //capture the Order Details
        AnAddress.OrderNo = txtProductNoId.Text;
        Session["AnAddress"] = AnAddress;
       
        //Navigate to the view page
        Response.Redirect("AddressBookViewer.aspx");
    }
}