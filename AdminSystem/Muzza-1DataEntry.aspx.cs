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
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffId != -1)
            {
                //dipslay the current data for the record
                DisplayStaff();

            }

        }
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
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded, StaffRole);
        //store the address in the session object
        if (Error == "")
        {
            AStaff.StaffId = StaffId;
            AStaff.StaffFirstName = StaffFirstName;
            AStaff.StaffLastName = StaffLastName;
            AStaff.StaffDOB = Convert.ToDateTime(StaffDOB);
            AStaff.StaffRole= StaffRole;
            AStaff.StaffPhone = StaffPhone;
            AStaff.DateAdded = Convert.ToDateTime(DateAdded);

            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e StaffId = -1 then add the data

            if (StaffId == -1)
            {
                //set the ThisStaff Property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            //redirect back to the list page
            Response.Redirect("Muzza-1DataEntry.aspx");


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

    void DisplayStaff()
    {
        //create an instance of the Staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffId);
        //display the data for the record
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtStaffFirstName.Text = StaffBook.ThisStaff.StaffFirstName;
        txtStaffLastName.Text = StaffBook.ThisStaff.StaffLastName;
        txtStaffDOB.Text = StaffBook.ThisStaff.StaffDOB.ToString();
        txtStaffEmail.Text = StaffBook.ThisStaff.StaffEmail;
        txtStaffPhone.Text = StaffBook.ThisStaff.StaffPhone;
        txtDateAdded.Text = StaffBook.ThisStaff.DateAdded.ToString();
        txtStaffRole.Text = StaffBook.ThisStaff.StaffRole;


    }


}