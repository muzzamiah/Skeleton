using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1Viewer : System.Web.UI.Page
{
    public clsSupplier ASupplier { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new instnce of clsSupplier
        clsSupplier supplier = new clsSupplier();
        //Get the data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        //Display the supplier name for this entry
        Response.Write(ASupplier.SupplierName);

    }
}