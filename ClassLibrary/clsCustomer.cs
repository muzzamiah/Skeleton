using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool AgeCheck { get; set; }
        public DateTime DateAdded { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime CustomerDOB { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }



        public bool Find(int customerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", customerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should either be one or zero
            if (DB.Count == 1)

            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                AgeCheck = Convert.ToBoolean(DB.DataTable.Rows[0]["AgeCheck"]);
                DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                CustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                CustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                CustomerPhone = Convert.ToString(DB.DataTable.Rows[0]["CustomerPhone"]);
                ////return that everything worked OK
                return true;
                //if no record was found
            }
            else
            {

                //return false indicating there is a problem
                return false;

            }

        }

        public string Valid(string customerFirstName, string customerLastName, string customerDOB, string customerPhone, string customerEmail, string dateAdded)

        {
            //create a string variable to store the error
            String Error = "";
           
            //if the customer firstname is blank
            if (customerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The firstname no may not be blank : ";
            }
            //if the customer firstname is greater than 6 characters
            if (customerFirstName.Length > 6)
            {
                //record the error
                Error = Error + "The firstname no must be less than 6 characters : ";
            }

            //create a temporary variable to store date values
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(customerDOB);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date ws not a valid date : ";
            }

            //is the customer lastname blank
            if (customerLastName.Length == 0)
            {
                //record the error
                Error = Error + "The lastname may not be blank : ";
            }
            //if the customer lastname is too long
            if (customerLastName.Length > 9)
            {
                //record the error
                Error = Error + "The lastname must be less than 9 characters : ";
            }

            //is the customer phone blank
            if (customerPhone.Length == 0)
            {
                //record the error
                Error = Error + "The phone may not be blank : ";
            }
            //if the customer phone is too long
            if (customerPhone.Length > 50)
            {
                //record the error
                Error = Error + "The phone must be less than 50 characters : ";
            }

            //is the town blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the town is too long
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }


            return Error;
        }

    

        //private data member for the customer id property
        private Int32 mCustomerId;

        //CustomerId public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        // STATS FOR LASTNAME and DATE ADDED

        public DataTable StatisticsGroupedByCustomerLastName()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Count_GroupByCustomerLastName");
            //there should be either zero, one or more records
            return DB.DataTable;
        }

        public DataTable StatisticsGroupedByDateAdded()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Count_GroupByDateAdded");
            //there should be either zero, one or more records
            return DB.DataTable;
        }

    }
}

