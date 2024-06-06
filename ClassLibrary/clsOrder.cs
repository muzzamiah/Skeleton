using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int OrderNo { get; set; }
        public decimal Price { get; set; }
        public string OrderAddress { get; set; }


        public string Valid(string ProductName, string Quantity, string OrderNo, string Price, string OrderDate, string OrderAddress)

        {
            //create a string variable to store the error
            String Error = "";

            //if the Product Name is blank
            if (ProductName.Length == 0)
            {
                //record the error
                Error = Error + "The Product Name must not be blank : ";
            }
            //if the Product Name is greater than 6 characters
            if (ProductName.Length > 6)
            {
                //record the error
                Error = Error + "The Product Name  must not be less than 6 characters : ";
            }

            //create a temporary variable to store date values
            DateTime DateTemp;
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the Order Date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(OrderDate);

                if (DateTemp < DateComp) //compare dateAdded with Date
                {

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



            //is the Order Address blank
            if (OrderAddress.Length == 0)
            {
                //record the error
                Error = Error + "The Order Address must not be blank : ";
            }
            //if the Order Address is too long
            if (OrderAddress.Length > 50)
            {
                //record the error
                Error = Error + "The Order Address must be less than 50 characters : ";
            }

            //is the Order Number blank
            if (OrderNo.Length == 0)
            {
                //record the error
                Error = Error + "The Order Number must not be blank : ";
            }
            //if the Order Number is too long
            if (OrderNo.Length > 50)
            {
                //record the error
                Error = Error + "The Order Number must be less than 50 characters : ";
            }

            //is the quantity blank
            if (Quantity.Length == 0)
            {
                //record the error
                Error = Error + "The Quantity must not be blank : ";
            }
            //if the quantity is too long
            if (Quantity.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }


            return Error;
        }

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
        //private data member for the county no property
        private Int32 mQuantity;
        //county no public property
        public int QuantityFound
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }

        //private data member for the county no property
        private Int32 mOrderNo;
        //county no public property
        public int OrderNoFound
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }

        //private data member for the date added property
        private DateTime mOrderDate;
        //date added public property
        public DateTime OrderDateFound
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderDate;
            }
            set
            {
                //this line of code allows data into the property
                mOrderDate = value;
            }

        //private data member for the county no property
        private Int32 mPrice;
        //county no public property
        public int PriceFound
        {
            get
            {
                //this line of code sends data out of the property
                return mPrice;
            }
            set
            {
                //this line of code allows data into the property
                mPrice = value;
            }



        //Find Method

        public bool Find(int addressId)
        {
            //Create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection
                //add the parameter for the address id to search for 
DB.AddParameter("@AddressId", AddressId)
                //Execute the stored procedure 
                DB.Execute("dbo.sproc_order_selectAll")
                //If one record is found (there should be either one or zero)
                if (DB.Count == 1)
            {
                mAddressId = Convert.ToInt32(DB.DataTable.Rows[0]["AddressID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order Date"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mAddressId = Convert.ToInt32(DB.DataTable.Rows[0]["AddressID"]);
                mAddressId = Convert.ToInt32(DB.DataTable.Rows[0]["AddressID"]);
                mAddressId = Convert.ToInt32(DB.DataTable.Rows[0]["AddressID"]);

            }
            