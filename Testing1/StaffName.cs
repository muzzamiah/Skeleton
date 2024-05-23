using System;

namespace Testing1
{
    public  class StaffName
    {
        private Int32 mAddressID;
        public int StaffId { get; internal set; }
        public DateTime DOB { get; internal set; }
        public string Street { get; internal set; }
        public string PostCode { get; internal set; }
        public string Role { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public bool Attendance { get; internal set; }
        public bool Gender { get; internal set; }
        public Int32 AddressID
        {
            get
            {
                return mAddressID;
            }
            set
            {
                mAddressID = value;

            }
        }

        
        private DateTime mDatePlaced;

        public DateTime DatePlaced
        {
            get 
            {
                return mDatePlaced;
            }
            set
            {
                mDatePlaced = value;
            }
        }

        public string StaffID { get; internal set; }

        public bool Find(int AddressID)
        {
            mAddressID = 21;
            mDatePlaced = Convert.ToDateTime("23/12/2023");
            return true;
        }






    }
}