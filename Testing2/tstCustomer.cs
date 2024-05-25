using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        string CustomerFirstName = "John";
        string CustomerLastName = "Doe";
        string CustomerDOB = DateTime.Now.ToShortDateString();
        string CustomerEmail = "john.doe@example.com";
        string CustomerPhone = "123-456-7890";
        string DateAdded = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void AgeCheckPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.AgeCheck = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.AgeCheck, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }


        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // Create some test data for the property
            string TestData = "John";
            // Assign the data to the property
            AnCustomer.CustomerFirstName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // Create some test data for the property
            string TestData = "Doe";
            // Assign the data to the property
            AnCustomer.CustomerLastName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerLastName, TestData);
        }
        [TestMethod]
        public void CustomerDOBPropertyOK()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // Create some test data for the property
            DateTime TestData = new DateTime(1990, 5, 13); // Example date of birth
            // Assign the data to the property
            AnCustomer.CustomerDOB = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // Create some test data for the property
            string TestData = "john.doe@example.com";
            // Assign the data to the property
            AnCustomer.CustomerEmail = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPhonePropertyOK()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // Create some test data for the property
            string TestData = "123-456-7890";
            // Assign the data to the property
            AnCustomer.CustomerPhone = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerPhone, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable t record if the data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 CustomerId = 4;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.CustomerId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAgeCheckFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.AgeCheck != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateAdded != Convert.ToDateTime("23/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerFirstName != "Jordan")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerLastName != "Riley")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerDOB != Convert.ToDateTime("02/09/2002"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerEmail != "jordanriley@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPhoneFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            bool Found = false;
            bool OK = true;
            int CustomerId = 4;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerPhone != "07834572379")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = ""; //this should trigger an error
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "A"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "Aa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaa"; //this should be ok
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "aaaaaaa"; //this should trigger an error
                                                  //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "";
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a'); //this should trigger an error
            //this should trigger an error
            //invoke the method
            Error = anCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
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
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerLastName = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerLastName = "a";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerLastName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerLastName = "aaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerLastName = "aaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerLastName = "aaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerLastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerLastName = "aaaa";
            //invoke the method
            Error = AnCustomer.Valid(CustomerFirstName, CustomerLastName, CustomerDOB, CustomerPhone, CustomerEmail, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





    }

}



   