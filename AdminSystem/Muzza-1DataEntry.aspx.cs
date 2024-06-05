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
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the attributes
        string StaffFirstName = txtStaffFirstName.Text;
        string StaffLastName = txtStaffLastName.Text;
        string StaffDOB = txtStaffDOB.Text;
        string StaffRole = txtStaffRole.Text;
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
            AStaff.StaffRole = StaffRole;
            AStaff.StaffPhone = StaffPhone;
            AStaff.DateAdded = Convert.ToDateTime(DateAdded);


            Session["AStaff"] = AStaff;
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
        //create an instance of the Staff class
        clsStaff AStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffFirstName.Text = AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffDOB.Text = AStaff.StaffDOB.ToString();
            txtStaffRole.Text = AStaff.StaffRole;
            txtStaffPhone.Text = AStaff.StaffPhone;
            txtDateAdded.Text = AStaff.DateAdded.ToString();


        }


    }
}