using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Core;
namespace ClassLibrary
{
    public class StaffName
    {
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


        //private data member for the town property
        private string mNameStaff;
        //town public property
        public string NameStaff
        {
            get
            {
                //this line of code sends data out of the property
                return mNameStaff;
            }
            set
            {
                //this line of code allows data into the property
                mNameStaff = value;
            }
        }
        //private data member for the post code property
        private string mPostCode;
        //post code public property
        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into the property
                mPostCode = value;
            }
        }

       
        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DatePlaced
        {
            get
            {
                //this line of code sends data out of the property
                return mDatePlaced;
            }
            set
            {
                //this line of code allows data into the property
                mDatePlaced = value;
            }
        }

        //private data member for the county no property
        private Int32 mStaffID;
        //county no public property
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the property
                mStaffID = value;
            }
        }

        [TestMethod]
        public void StaffName()
        {
            //create an instance of the class we want to create
            StaffName AName = new StaffName();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 NameStaff = 21;
            //invoke the method
            Found = AName.Find(NameStaff);
            //check the town property
            if (AName.NameStaff != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /****** FIND METHOD ******/
        public bool Find(int AddressId)
        {
            //set the private data members to the test data value
            mAddressId = 21;
            mStaffID = "123";
            mNameStaff = "Test Street";
            mPostCode = "XXX XXX";
            mDatePlaced = Convert.ToDateTime("23/12/2022");
            mActive = true;
            //always return true
            return true;
        }
    }
}



