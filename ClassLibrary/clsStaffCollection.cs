using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }




        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //worrying about later
            }
        }

        public clsStaff ThisStaff { get; set; }

        //constructor for the class
        public clsStaffCollection()
        {
            //create the items of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "07479875589";
            TestItem.StaffRole = "Manager";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
            //add the test item to the test list
            mStaffList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsStaff();
            //set its properties
            
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "07479875589";
            TestItem.StaffRole = "hello@yahoo.com";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
            //add the item to the test list
            mStaffList.Add(TestItem);

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Staff
                clsStaff AStaff = new clsStaff();
                //read in the fields for the current record

                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffPhone = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhone"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStaff.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }

        }




    }
}