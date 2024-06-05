using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class Muzza_1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clscustomer
        clsStaff AStaff = new clsStaff();
        //capture the attributes
        string StaffID = txt
        string StaffLastName = txtStaffLastName.Text;
        string StaffDOB = txtStaffDOB.Text;
        string StaffEmail = txtStaffEmail.Text;
        string StaffPhone = txtStaffPhone.Text;
        string DateAdded = txtDateAdded.Text;
        
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffEmail, DateAdded);
        //store the address in the session object
        if (Error == "")
        {
            AStaff.StaffFirstName = StaffFirstName;
            AStaff.StaffLastName = StaffLastName;
            AStaff.StaffDOB = Convert.ToDateTime(StaffDOB);
            AStaff.StaffEmail = StaffEmail;
            AStaff.StaffPhone = StaffPhone;
            AStaff.DateAdded = Convert.ToDateTime(DateAdded);


            Session["Staff"] = Staff;
            //navigate to the view page
            Response.Redirect("StaffViewer.aspx");
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
        clsStaff AStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        AStaff.StaffDOB = Convert.ToInt32(StaffDOB);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffFirstName.Text = AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffDOB.Text = AStaff.StaffDOB.ToString();
            txtStaffEmail.Text = AStaff.StaffEmail;
            txtStaffPhone.Text = AStaff.StaffPhone;
            txtDateAdded.Text = AStaff.DateAdded.ToString();
            

        }


    }
}