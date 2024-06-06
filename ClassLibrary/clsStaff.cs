using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;

namespace ClassLibrary
{
    public class clsStaff
    {
       
        public DateTime DateAdded { get; set; }
        public string StaffFirstName { get; set; }
        public string StaffLastName { get; set; }
        public DateTime StaffDOB { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPhone { get; set; }
        public bool Attendance {  get; set; }



        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found (there should either be one or zero
            if (DB.Count == 1)

            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
               
                DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                StaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                StaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                StaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                StaffPhone = Convert.ToString(DB.DataTable.Rows[0]["StaffPhone"]);
                //return that everything worked OK
                return true;
                //if no record was found
            }
            else
            {

                //return false indicating there is a problem
                return false;

            }
            
        }
        public string Valid(string StaffFirstName, string StaffLastName, string StaffDOB, string StaffPhone, string StaffEmail, string DateAdded)

        {
            //create a string variable to store the error
            String Error = "";

            //if the customer firstname is blank
            if (StaffFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The firstname no may not be blank : ";
            }
            //if the customer firstname is greater than 6 characters
            if (StaffFirstName.Length > 6)
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
                DateTemp = Convert.ToDateTime(DateAdded);

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

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(StaffDOB);

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
            if (StaffLastName.Length == 0)
            {
                //record the error
                Error = Error + "The lastname may not be blank : ";
            }
            //if the customer lastname is too long
            if (StaffLastName.Length > 9)
            {
                //record the error
                Error = Error + "The lastname must be less than 9 characters : ";
            }

            //is the customer phone blank
            if (StaffPhone.Length == 0)
            {
                //record the error
                Error = Error + "The phone may not be blank : ";
            }
            //if the customer phone is too long
            if (StaffPhone.Length > 50)
            {
                //record the error
                Error = Error + "The phone must be less than 50 characters : ";
            }

            //is the town blank
            if (StaffEmail.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            //if the town is too long
            if (StaffEmail.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }


            return Error;
        }



        //private data member for the customer id property
        private Int32 mStaffId;
        

        //CustomerId public property
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        public string StaffRole { get; internal set; }
    }
}
