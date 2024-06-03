
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstAddress


    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class want to create 
            clsOrder AnAddress = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]
        public void ActivePropertyOK()
        //Create an instance of the class we want to create
        {
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnAddress.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Active, TestData);
        }
        [TestMethod]
        public void OrderDate()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAddress.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.OrderDate, TestData);
        }
        [TestMethod]
        public void ProductName()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Keyboard";
            //assign the data to the property
            AnAddress.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.ProductName, TestData);
        }

        [TestMethod]
        public void Quantity()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Quantity, TestData);
        }
        [TestMethod]
        public void OrderNo()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.OrderNo, TestData);
        }
        [TestMethod]
        public void Price()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            decimal TestData = 19.99m;
            //assign the data to the property
            AnAddress.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Price, TestData);
        }
        [TestMethod]
        public void OrderAddress()
        {
            //create an instance of the class we want to create
            clsOrder AnAddress = new clsOrder();
            //create some test data to assign to the property
            string TestData = "John Doe";
            //assign the data to the property
            AnAddress.OrderAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.OrderAddress, TestData);
        }
    }
    [TestMethod]
    public void Quantityfound()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //create a Boolean variable to store the results of the validation
        Boolean Found = false;
        //create some test data to use with the method
        Int32 AddressId = 21;
        //invoke the method
        Found = AnAddress.Find(AddressId);
        //test to see if the result is true
        Assert.IsTrue(Found);
    }
    [TestMethod]
    public void OrderDateFound()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //create a Boolean variable to store the result of the search
        Boolean Found = false;
        //create Boolean variable to record if the data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 AddressId = 21;
        //invoke the method
        Found = AnAddress.Find(AddressId);
        //check the date added property
        if (AnAddress.OrderDate != Convert.ToDateTime("23/01/2024"))
        {
            OK = false;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);


    }
    [TestMethod]
    public void PriceFound()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //create a Boolean variable to store the result of the search
        Boolean Found = false;
        //create Boolean variable to record if the data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 AddressId = 21;
        //invoke the method
        Found = AnAddress.Find(AddressId);
        //check the date added property
        if (AnAddress.Price != Convert.int32("22"))
        {
            OK = false;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);


    }

    public void OrderNoFound()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //create a boolean variable to store the result of the search
        Boolean Found = false;
        //create a boolean variable to record if data is OK (assume it is)
        Boolean OK = true;
        //create some test data to use with the method
        Int32 AddressId = 21;
        //invoke the method
        Found = AnAddress.Find(AddressId);
        //check the post code property
        if (AnAddress.OrderNo != "XXX XXX")
        {
            OK = false;
        }
        //test to see that the result is correct
        Assert.IsTrue(OK);
    }
    [TestMethod]
    public void ValidMethodOK()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //invoke the method
        Error = AnCustomer.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct        
        Assert.AreEqual(Error, "");
    }
    [TestMethod]
    public void ValidMethodOK()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //invoke the method
        Error = AnCustomer.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct        
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void ProuductNameMinLessOne()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string Product = ""; //this should trigger an error
                             //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");
    }

    [TestMethod]
    public void ProuductNameNoMin()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "A";//this should be okay
                                 //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameMin()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "Aa";  //this should  be okay
                                    //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameMinPlusOne()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "aa"; //This should be okay
                                   //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameMaxLessOne()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "aaaaa"; // This should be okay
                                      //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameMax()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "aaaaa"; // This should be okay
                                      //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameMid()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "aaa"; //This should be okay
                                    //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameMaxPlusOne()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "aaaaaaa"; //This should be okay
                                        //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void ProuductNameExtremeMax()
    {
        //create an instance of the class we want to create
        clsOrder anAddress = new clsOrder();
        //string c=variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string ProductName = "";
        ProductName = ProductName.PadRight(500, 'a'); ; //This should trigger an error
                                                        //invoke the method
        Error = anOrder.valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

    }

    [TestMethod]
    public void OrderDateExtremeMin()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is less 100 years
        TestDate = TestDate.AddYears(-100);
        //convert the date variable to a string variable
        string OrderDate = TestDate.ToString();
        //invoke the method
        Error = AnOrder.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");
    }
    [TestMethod]
    public void OrderDateMinLessOne()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is less 100 years
        TestDate = TestDate.AddYears(-1);
        //convert the date variable to a string variable
        string OrderDate = TestDate.ToString();
        //invoke the method
        Error = AnOrder.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");
    }
    [TestMethod]
    public void OrderDateMin()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //convert the date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnOrder.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreEqual(Error, "");
    }

    [TestMethod]
    public void DateAddedExtremeMax()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //create a variable to store the test date data
        DateTime TestDate;
        //set the date totodays date
        TestDate = DateTime.Now.Date;
        //change the date to whatever the date is plus 100 years
        TestDate = TestDate.AddYears(100);
        //convert the date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = AnOrder.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");
    }

    [TestMethod]
    public void OrderDateInvalidData()
    {
        //create an instance of the class we want to create
        clsOrder AnAddress = new clsOrder();
        //string variable to store any error message
        String Error = "";
        //set the DateAdded to a non date value
        string DateAdded = "this is not a date!";
        //invoke the method
        Error = AnOrder.Valid(ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");
    }
}