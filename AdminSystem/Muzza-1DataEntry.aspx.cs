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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AStaff.Find(StaffId);
        if (Found == true)
        {
            txtStaffFirstName.Text = AStaff.StaffFirstName;
            txtStaffLastName.Text = AStaff.StaffLastName;
            txtStaffDOB.Text = AStaff.StaffDOB.ToString();
            txtStaffEmail.Text = AStaff.StaffEmail;
            txtStaffPhone.Text = AStaff.StaffPhone;
            txtDateAdded.Text = AStaff.DateAdded.ToString();
            //chkAgeCheck.Checked = AStaff.AgeCheck;

        }
    }
}

