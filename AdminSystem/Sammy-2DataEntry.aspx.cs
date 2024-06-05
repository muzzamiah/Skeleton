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

    //variable to store the primary key with page level cope
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //dipslay the current data for the record
                DisplayCustomer();

            }
           
        }
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
            AnCustomer.CustomerId = CustomerId;
            AnCustomer.CustomerFirstName = CustomerFirstName;
            AnCustomer.CustomerLastName = CustomerLastName;
            AnCustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.CustomerPhone = CustomerPhone;
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            AnCustomer.AgeCheck = chkAgeCheck.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            //if this is a new record i.e CustomerId = -1 then add the data

            if (CustomerId == -1)
            {
                //set the ThisCustomer Property
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("Sammy-2DataEntry.aspx");

            
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

        void DisplayCustomer()
        {
            //create an instance of the customer book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerId);
            //display the data for the record
            txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
            txtCustomerFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
            txtCustomerLastName.Text = CustomerBook.ThisCustomer.CustomerLastName;
            txtCustomerDOB.Text = CustomerBook.ThisCustomer.CustomerDOB.ToString();
            txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail;
            txtCustomerPhone.Text = CustomerBook.ThisCustomer.CustomerPhone;
            txtDateAdded.Text = CustomerBook.ThisCustomer.DateAdded.ToString();
            chkAgeCheck.Checked = CustomerBook.ThisCustomer.AgeCheck;

        }

    
}