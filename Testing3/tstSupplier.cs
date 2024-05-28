using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        /***Instance of the Class Test ***/
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class I want to create 
            clsSupplier  ASupplier = new clsSupplier();
            //Testing to see if it exists
            Assert.IsNotNull(ASupplier);

        }

        /***OK Property Tests ***/
        [TestMethod]
        public void ActivePropertyOK()
        {
            //Creating an instance of the class I want to create
            clsSupplier ASupplier = new clsSupplier();
            //Creating some test data to assign to this property
            Boolean TestData = true;
            //Assigning the data to this property
            ASupplier.Active = TestData;
            //Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.Active, TestData);

        /***Contract Start Date Property Test ***/
        }
        [TestMethod]
        public void ContractStartDatePropertyOK()
        {
            //Creating an instance of the class I want to create
            clsSupplier ASupplier = new clsSupplier();
            //Creating some test data to assign to this property
            DateTime TestData = DateTime.Now.Date;
            //Assigning the data to this property
            ASupplier.ContractStartDate = TestData;
            //Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.ContractStartDate, TestData);
        }

        /***Contract End Date Property Test ***/
        [TestMethod]
        public void ContractEndDatePropertyOK()
        {
            //Creating an instance of the class I want to create
            clsSupplier ASupplier = new clsSupplier();
            //Creating some test data to assign to this property
            DateTime TestData = DateTime.Now.Date;
            //Assigning the data to this property
            ASupplier.ContractEndDate = TestData;
            //Testing to see that both these values are the same
            Assert.AreEqual(ASupplier.ContractEndDate, TestData);

        /***Supplier ID Property Test ***/
        }
        [TestMethod]
        public void SupplierIdPropertyOK()
        {
            //Creating an instance of the class I want to create
            clsSupplier ASupplier = new clsSupplier();
            //Creating some test data to assign to this property
            Int32 TestData = 1;
            //Assigning the data to this property
            ASupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }

        /***Supplier Name Property Test ***/
        [TestMethod]
        public void SupplierNamePropertyOK()
        {
            //Creating an instance of the class I want to create
            clsSupplier ASupplier = new clsSupplier();
            //Creating some test data to assign to this property
            string TestData = "Birmingham Tech Ltd";
            //Assigning the data to this property
            ASupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }

        /***Contact Phone Property Test ***/
        [TestMethod]
        public void ContactPhonePropertyOK()
        {
            // Creating an instance of the class I want to test
            clsSupplier ASupplier = new clsSupplier();
            // Creating some test data to assign to this property
            string TestData = "01133468290";
            // Assigning the data to this property
            ASupplier.ContactPhone = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(ASupplier.ContactPhone, TestData);
        }

        /***Contact Email Property Tests ***/
        [TestMethod]
        public void ContactEmailPropertyOK()
        {
            // Creating an instance of the class I want to test
            clsSupplier ASupplier = new clsSupplier();
            // Creating some test data to assign to this property
            string TestData = "example@example.com";
            // Assigning the data to this property
            ASupplier.ContactEmail = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(ASupplier.ContactEmail, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class I want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the address id property
            if (ASupplier.SupplierId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the street property
            if (ASupplier.SupplierName != "Test Supplier Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the house no property
            if (ASupplier.ContactPhone != "123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestContactEmailAddressFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the house no property
            if (ASupplier.ContactEmail != "123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractStartDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the date added property
            if (ASupplier.ContractStartDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractEndDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the date added property
            if (ASupplier.ContractEndDate != Convert.ToDateTime("23/12/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = ASupplier.Find(SupplierId);
            //check the active property
            if (ASupplier.IsActive != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }













    }
}
