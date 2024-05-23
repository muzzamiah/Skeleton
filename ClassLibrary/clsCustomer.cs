using System;

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
            //set the private data members to the test data value
            mCustomerId = 21;
            AgeCheck = true;
            DateAdded = DateTime.Now.Date;
            CustomerFirstName = "John";
            CustomerLastName = "Doe";
            CustomerDOB = new DateTime(1990, 5, 13);
            CustomerEmail = "john.doe@example.com";
            CustomerPhone = "123-456-7890";
            //always return true
            return true;
        }

        public string Valid(string customerFirstName, string customerLastName, string customerDOB, string customerPhone, string customerEmail, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (customerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (customerFirstName.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            //return any error messages
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
    }
}