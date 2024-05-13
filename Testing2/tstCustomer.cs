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
        public void PreferredColourPropertyOK()
        {
            // Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            // Create some test data for the property
            string TestData = "Blue";
            // Assign the data to the property
            AnCustomer.PreferredColour = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PreferredColour, TestData);
        }
    }
}
    
