using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary { }

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

        //private data member for the active property
        private Boolean mActive;
        //active attendance
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        public bool AgeCheck
        {
            get; set;
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

        //private data member for the town property
        private string mStreet;
        //town public property
        public string Street
        {
            get
            {
                //this line of code sends data out of the property
                return mStreet;
            }
            set
            {
                //this line of code allows data into the property
                mStreet = value;
            }
        }

        //private data member for the town property
        private string mRole;
        //town public property
        public string Role
        {
            get
            {
                //this line of code sends data out of the property
                return mRole;
            }
            set
            {
                //this line of code allows data into the property
                mRole = value;
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
        private DateTime mDatePlaced;

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

        //private data member for the active property
        private Boolean mAttendance;
        

        //active public property
        public bool Attendance
        {
            get
            {
                //this line of code sends data out of the property
                return mAttendance;
            }
            set
            {
                //this line of code allows data into the property
                mAttendance = value;
            }

        }

        public DateTime DOB { get; internal set; }
        public bool Gender { get; internal set; }

        /****** FIND METHOD ******/
        public bool Find(int StaffId)
        {

            StaffDataConnection DB = new StaffDataConnection();

            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilteredByStaffId");

            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mAddressId = Convert.ToInt32(DB.DataTable.Row[0]["AddressId"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Row[0]["StaffId"]);
                mNameStaff = Convert.ToString(DB.DataTable.Row[0]["FirstName"]);
                mNameStaff = Convert.ToString(DB.DataTable.Row[0]["LastName"]);
                mPostCode = Convert.ToInt32(DB.DataTable.Row[0]["PostCode"]);
                mDatePlaced = Convert.ToDateTime(DB.DataTable.Row[0]["DatePlaced"]);
                mRole = Convert.ToString(DB.DataTable.Row[0]["Staff Role"]);
                mAttendance = Convert.ToBoolean(DB.DataTable.Rows[0]["True"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}



