using System;
using System.Activities.Expressions;
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
        string CustomerFirstName = txtCustomerFirstName.Text;
        string CustomerLastName = txtCustomerLastName.Text;
        string CustomerDOB = txtCustomerDOB.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerPhone = txtCustomerPhone.Text;
        string DateAdded = txtDateAdded.Text;
        string AgeCheck = chkAgeCheck.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
        //store the address in the session object
        if (Error == "")
        {
            AnCustomer.CustomerFirstName = CustomerFirstName;
            AnCustomer.CustomerLastName = CustomerLastName;
            AnCustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.CustomerPhone = CustomerPhone;
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);


            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("Sammy-2Viewer.aspx");
        }

        else
        {
            //display the error message
            lblError.Text = Error;

        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerFirstName.Text = AnCustomer.CustomerFirstName;
            txtCustomerLastName.Text = AnCustomer.CustomerLastName;
            txtCustomerDOB.Text = AnCustomer.CustomerDOB.ToString();
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerPhone.Text = AnCustomer.CustomerPhone;
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
            chkAgeCheck.Checked = AnCustomer.AgeCheck;

        }


    }
}