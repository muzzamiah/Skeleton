using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }




        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //worrying about later
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            { //return the private data
                return mThisCustomer;

            }
            set
            {
                //set the private data
                mThisCustomer = value;

            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //private data member for the list
            List<clsCustomer> mCustomerList = new List<clsCustomer> ();
            //private member data for thisCustomer
            clsCustomer mThisCustomer = new clsCustomer ();
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //add the test item to the test list
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //add the item to the test list
            mCustomerList.Add(TestItem);

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;        
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                
                AnCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                AnCustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                AnCustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                // (need to fix) AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                // (need to fix) AnCustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                // (need to fix) AnCustomer.AgeCheck = Convert.ToBoolean(DB.DataTable.Rows[Index]["AgeCheck"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;

            }


          

            }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //sets the primary key value of the new record
            mThisCustomer.CustomerId = 123;
            //return the primary key of the new record
            return mThisCustomer.CustomerId;
        }
    }
}