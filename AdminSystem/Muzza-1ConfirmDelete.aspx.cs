﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the primary key value of the record to be deleted
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Staff to be deleted from the session object
        StaffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Staff book collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete
        StaffBook.ThisStaff.Find(StaffId);
        //delete the record
        StaffBook.Delete();
        //redirect back to the main page
        Response.Redirect("MuzzaList.aspx");
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        //redorect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}