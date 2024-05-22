using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clscustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the attributes
        AnCustomer.CustomerFirstName = txtCustomerFirstName.Text;
        AnCustomer.CustomerLastName = txtCustomerLastName.Text;
        AnCustomer.CustomerDOB = Convert.ToDateTime(txtCustomerDOB.Text);
        AnCustomer.CustomerEmail = txtCustomerEmail.Text;
        AnCustomer.CustomerPhone = txtCustomerPhone.Text; 
        AnCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AnCustomer.AgeCheck = chkAgeCheck.Checked;
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("Sammy-2Viewer.aspx");
    }
}