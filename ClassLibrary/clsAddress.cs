using System;

namespace ClassLibrary
{
    public class clsAddress
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int OrderNo { get; set; }
        public decimal Price { get; set; }
        public string OrderAddress { get; set; }

        public bool Find(int addressId)
        {
            //always return true
            return true;
        }
        //private data member for the address id property
        private Int32 mAddressId;
        //addressId public property
        public int AddressId
        {
            get
            {
                //this line of code sends data out of the property
                return mAddressId;
            }
            set
            {
                //this line of code allows data into the property
                mAddressId = value;
            }

        }

        //private data member for the date added property
        private DateTime mDateAdded;
        private DateTime mOrderDateFound;

        //date added public property
        public DateTime OrderDateFound
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDateFound;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
    }
    
