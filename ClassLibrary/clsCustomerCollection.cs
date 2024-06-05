using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    { 
    


        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

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

    
                //object for the data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure
                DB.Execute("sproc_tblCustomer_SelectAll");
                //populate the array list with the data table
                PopulateArray(DB);
            
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
            //clsDataConnection DB = new clsDataConnection();
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
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@AgeCheck", mThisCustomer.AgeCheck);



            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
           //update an existing record based on the values of thisCustomer
           //connect to the database
           clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@CustomerPhone", mThisCustomer.CustomerPhone);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@CustomerDOB", mThisCustomer.CustomerDOB);
            DB.AddParameter("@AgeCheck", mThisCustomer.AgeCheck);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer 
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByEmail(string CustomerEmail)
        {
            //filters the records based on a full or partial email
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the email parameter to the database
            DB.AddParameter("@CustomerEmail", CustomerEmail);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)

        {
            //populates the array list based on the data table in the parameter
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)

            {
                //create a blank customer object
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record

                AnCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                AnCustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                AnCustomer.CustomerPhone = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPhone"]);
                AnCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                // (NEED TO FIX) AnCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                // (NEED TO FIX) AnCustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                // (NEED TO FIX) AnCustomer.AgeCheck = Convert.ToBoolean(DB.DataTable.Rows[Index]["AgeCheck"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }


        }

    }
}