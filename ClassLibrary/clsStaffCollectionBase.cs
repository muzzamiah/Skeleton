using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollectionBase
    {
        public List<clsStaff> mStaffList { get; private set; }

        private void PopulateArray(clsDataConnection DB)

        {
            //populates the array list based on the data table in the parameter
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)

            {
                //create a blank Staff object
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record

                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffPhone = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhone"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
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