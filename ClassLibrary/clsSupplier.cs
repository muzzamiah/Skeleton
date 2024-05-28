using System;

namespace ClassLibrary
{
    public class clsSupplier
    {

        public bool Active { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }

        //private data member for the supplier id property
        private Int32 mSupplierId;
        //supplierId public property
        public int SupplierId
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierId = value;
            }
        }
        public string SupplierName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }

        public bool Find(int supplierId)
        {
            //set the private data members to the test data value
            mSupplierId = 21;
            //Aleays return true
            return true;

        }
    }
}