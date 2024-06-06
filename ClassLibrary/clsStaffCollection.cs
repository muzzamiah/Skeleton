using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private member data for thisStaff
        clsStaff mThisStaff = new clsStaff();

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

        public clsStaff ThisStaff
        {
            get
            { //return the private data
                return mThisStaff;

            }
            set
            {
                //set the private data
                mThisStaff = value;

            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //private data member for the list
            List<clsStaff> mStaffList = new List<clsStaff>();
            //private member data for thisStaff
            clsStaff mThisStaff = new clsStaff();
            //create the items of test data
            clsStaff TestItem = new clsStaff();
            //set its properties

            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

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
            TestItem.StaffRole = "Manager";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
           
            //add the item to the test list
            mStaffList.Add(TestItem);

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
           
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

        private void PopulateArray(clsDataConnection dB)
        {
            throw new NotImplementedException();
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffPhone", mThisStaff.StaffPhone);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            



            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffPhone", mThisStaff.StaffPhone);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
         
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff 
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByEmail(string StaffEmail)
        {
            //filters the records based on a full or partial email
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the email parameter to the database
            DB.AddParameter("@StaffEmail", StaffEmail);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByEmail(object text)
        {
            throw new NotImplementedException();
        }
    }

    }
