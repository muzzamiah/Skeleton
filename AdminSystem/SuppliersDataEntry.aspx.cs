using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {

        //Creating an instance of the class I want to create
        clsSupplier ASupplier = new clsSupplier();
        //Cpturing the Supplier Name
        ASupplier.SupplierName = txtSupplierName.Text;
        //Store the supplier in the session object
        Session["ASupplier"] = ASupplier;
        //Navigate to the view page
        Response.Redirect("SuppliersViewer.aspx");

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}