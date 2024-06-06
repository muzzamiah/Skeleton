using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();

        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }

       public clsOrderCollection ThisAddress
        {
            get
            {
                //return the private data
                return mThisAddress
                    }
            set
            {
                //set the private data 
                mThisAddress = value;

                public int Add()
                    mThisAddress.AddressId=123
                    return mThisAddress.AddressId




        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //worrying about later
            }
        }

        public clsOrder ThisOrder { get; set; }

        //constructor for the class
        public clsOrderCollection()
        {
            //create the items of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
           TestItem.OrderAddress = "21 Jump Street" 
            TestItem.OrderDate = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = "2";
            TestItem.ProductName = "YellowXKeyboard";
            TestItem.OrderNo = "235567544";
            TestItem.Price = "£21";
            //add the test item to the test list
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.OrderDate = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = "2";
            TestItem.ProductName = "YellowXKeyboard";
            TestItem.OrderNo = "235567544";
            TestItem.Price = "£21";
            //add the item to the test list
            mOrderList.Add(TestItem);

            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnAddress = new clsCustomer();
                //read in the fields for the current record

                AnAddress.Quantity = Convert.ToString(DB.DataTable.Rows[Index]["Quantity"]);
                AnAddress.Product = Convert.ToString(DB.DataTable.Rows[Index]["Product Name"]);
                AnAddress.OrderNo = Convert.ToString(DB.DataTable.Rows[Index]["Order Number"]);
                AnAddress.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);

                mOrderList.Add(AnAddress);
                //point at the next record
                Index++;
            }
            public int Add()
            {
                //adds a record to the database based on the values of mThisCustomer
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@ProductName", mThisOrder.ProductName);
                DB.AddParameter("@Price", mThisOrder.Price);
                DB.AddParameter("@Quantity", mThisOrder.Quantity);
                DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
                DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
                DB.AddParameter("@CustomerDOB", mThisOrder.OrderDate);
                DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);



                //execute the query returning the primary key value
                return DB.Execute("sproc_tblOrder_Insert");
            }
            public void Update()
            {
                //update an existing record based on the values of thisCustomer
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the new stored procedure
                DB.AddParameter("@ProductName", mThisOrder.ProductName);
                DB.AddParameter("@Price", mThisOrder.Price);
                DB.AddParameter("@Quantity", mThisOrder.Quantity);
                DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
                DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
                DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
                DB.AddParameter("@OrderAddress", mThisOrder.OrderAddress);
                //execute the stored procedure
                DB.Execute("sproc_tblOrder_Update");
            }

            public void Delete()
            {
                //deletes the record pointed to by thisCustomer 
                //connect to database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("AddressId", mThisOrder.AddressId);
                //execute the stored procedure
                DB.Execute("sproc_tblOrder_Delete");
            }


        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllAddresses = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderAddress = "21 Jump Street"
            TestItem.OrderDate = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = "2";
            TestItem.ProductName = "YellowXKeyboard";
            TestItem.OrderNo = "235567544";
            TestItem.Price = "£21";
            //set thiscustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.OrderAddress = "22 Jump Street"
            TestItem.OrderDate = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.Quantity = "1";
            TestItem.ProductName = "LimeXKeyboard";
            TestItem.OrderNo = "2355675222";
            TestItem.Price = "£22";
            //set the record based on the new test data
            AllAddresses.ThisOrder = TestItem;
            //update the record
            AllAddresses.Update();
            //find the record
            AllAddresses.ThisOrder.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }



    }
}