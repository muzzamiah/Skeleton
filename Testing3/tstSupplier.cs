﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class I want to create 
            clsSupplier  ASupplier = new clsSupplier();
            //Testing to see if it exists
            Assert.IsNotNull(ASupplier);

        }

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


    }
}
