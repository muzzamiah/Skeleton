using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }

    }

    void DisplayStaffs()
    {
        //create an instance of the Staff Collection
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of Staffs in the collection
        lstStaffList.DataSource = Staffs.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataTextField = "StaffFirstName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("Muzza-1DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("Muzza-1List.aspx");

        }

        else //if no record has been selected

        {
            lblError.Text = "Please select a record from the list to edit";

        }       }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //variable to store the primary key value of the record to be deleted
            Int32 CustomerId;
            //if a record has been selected from the list
            if (lstCustomerList.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
                //store the data in the session object
                Session["CustomerId"] = CustomerId;
                //redirect to the edit page
                Response.Redirect("CustomerConfirmDelete.aspx");
            }
            else //if no record has been selected

            {
                lblError.Text = "Please select a record from the list to delete";
            }

        }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //create an instance of the customer object
            clsStaffCollection AStaff = new clsStaffCollection();
            //retrieve the value of email from the presentation layer
            AStaff.ReportByEmail(txtFilter.Text);
            //set the data sourc to the list of customers in the collection
            lstStaffList.DataSource = AStaff.StaffList;
            //set the name of the primary key
            lstStaffList.DataValueField = "StaffId";
            //set the name of the field to display
            lstStaffList.DataTextField = "StaffEmail";
            //bind the data to the list
            lstStaffList.DataBind();
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            //create an instance of the customer object
            clsStaffCollection AStaff = new clsStaffCollection();
            //retrieve the value of email from the presentation layer
            AStaff.ReportByEmail(txtFilter.Text);
            //set the data sourc to the list of customers in the collection
            lstStaffList.DataSource = AStaff.StaffList;
            //set the name of the primary key
            lstStaffList.DataValueField = "StaffId";
            //set the name of the field to display
            lstStaffList.DataTextField = "StaffEmail";
            //bind the data to the list
            lstStaffList.DataBind();

        }
    }
}