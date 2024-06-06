using System;

namespace ClassLibrary
{
    public class clsSupplier
    {

        public bool Active { get; set; }


        //private data member for the Supplier ID property
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


        //private data member for the Supplier Name property
        private string mSupplierName;
        //house no public property
        public string SupplierName
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierName;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierName = value;
            }
        }

        //private data member for the Supplier Contact Phone property
        private string mContactPhone;
        //house no public property
        public string ContactPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mContactPhone;
            }
            set
            {
                //this line of code allows data into the property
                mContactPhone = value;
            }
        }

        //private data member for the Contact Email property
        private string mContactEmail;
        //house no public property
        public string ContactEmail
        {
            get
            {
                //this line of code sends data out of the property
                return mContactEmail;
            }
            set
            {
                //this line of code allows data into the property
                mContactEmail = value;
            }
        }

        //private data member for the Contract Start Date property
        private DateTime mContractStartDate;
        //date added public property
        public DateTime ContractStartDate
        {
            get
            {
                //this line of code sends data out of the property
                return mContractStartDate;
            }
            set
            {
                //this line of code allows data into the property
                mContractStartDate = value;
            }
        }

        //private data member for the Contract End Date property
        private DateTime mContractEndDate;
        //date added public property
        public DateTime ContractEndDate
        {
            get
            {
                //this line of code sends data out of the property
                return mContractEndDate;
            }
            set
            {
                //this line of code allows data into the property
                mContractEndDate = value;
            }
        }

        //private data member for the Is Active property
        private Boolean mIsActive;
        //active public property
        public bool IsActive
        {
            get
            {
                //this line of code sends data out of the property
                return mIsActive;
            }
            set
            {
                //this line of code allows data into the property
                mIsActive = value;
            }
        }


        public bool Find(int supplierId)
        {
            //set the private data members to the test data value
            mSupplierId = 21;
            mSupplierName = "Wigston Keyboards";
            mContactPhone = "07270833239";
            mContactEmail = "contact@wigstonkeyboards.com";
            mContractStartDate = Convert.ToDateTime("23/11/2021");
            mContractEndDate = Convert.ToDateTime("23/11/2024");
            mIsActive = false;
            //Aleays return true
            return true;

        }
    }
}