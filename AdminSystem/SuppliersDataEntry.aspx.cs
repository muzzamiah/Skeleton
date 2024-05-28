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
        //Capturing the Supplier ID
        ASupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
        //Capturing the Contact Phone Number
        ASupplier.ContactPhone = txtContactPhoneNumber.Text;
        //Capturing the Contact Email Address
        ASupplier.ContactEmail = txtContactEmailAddress.Text;
        //Capturing the Contract Start Date
        ASupplier.ContractStartDate = Convert.ToDateTime(txtContractStartDate.Text);
        //Capturing the Contract End Date
        ASupplier.ContractEndDate = Convert.ToDateTime(txtContractEndDate.Text);
        //Capturing if the Contract is Active
        ASupplier.Active = chkActive.Checked;
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