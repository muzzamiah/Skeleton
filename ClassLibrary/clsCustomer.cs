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