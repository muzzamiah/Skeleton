using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
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
            Int32 CustomerId = 21;
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
            Int32 CustomerId = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //check the address id
            if (AnCustomer.CustomerId != 21)
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
            int CustomerId = 21;
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
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateAdded != DateTime.Now.Date)
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
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerFirstName != "John")
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
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerLastName != "Doe")
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
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerDOB != new DateTime(1990, 5, 13))
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
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerEmail != "john.doe@example.com")
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
            int CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerPhone != "123-456-7890")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }

    }

    
