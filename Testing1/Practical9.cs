
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Core;


namespace Testing1
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void StaffName()
        {
            //create an instance of the class we want to create
            StaffName AName = new StaffName();
            //test to see that it exists
            Assert.IsNotNull(AName);
        }
        [TestMethod]
        public void StaffID()
        {
            //create an instance of the class we want to create
            StaffName AName = new StaffName();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AName.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AName.StaffId, TestData);
        }

        [TestMethod]
        public void StaffDOB()
        {
            // Create an instance of the class we want to create
            StaffName AName = new StaffName();

            // Create some test data to assign to the property
            DateTime TestData = DateTime.Today.AddYears(-70); // Example date 70 years in the past

            // Assign the data to the property
            AName.DOB = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(TestData, AName.DOB);
        }
        [TestMethod]
        public void StaffStreet()
        {
            //create an instance of the class we want to create
            StaffName AName = new StaffName();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AName.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AName.Street, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            // Create an instance of the class we want to create
            StaffName AName= new StaffName();

            // Create some test data to assign to the property
            bool TestData = true; // For example, true could represent Male

            // Assign the data to the property
            AName.Gender = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(TestData, AName.Gender);
        }

        [TestMethod]
        public void StaffRole()
        {
            // Create an instance of the class we want to create
            StaffName AName = new StaffName();

            // Create some test data to assign to the property
            string TestData = "Manager";

            // Assign the data to the property
            AName.Role = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(TestData, AName.Role);
        }
        [TestMethod]
        public void DateAdded()
        {
            StaffName AName = new StaffName();
            //create an instance of the class we want to create
            DateTime.Today.AddYears(-70);
            //create some test data to assign to the property
            DateTime TestData = DateTime.Today.AddYears(-5);
            //assign the data to the property
            AName.DatePlaced = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AName.DatePlaced, TestData);
        }

        [TestMethod]
        public void Attendance()
        {
            // Create an instance of the class we want to create
            StaffName AName = new StaffName();

            // Create some test data to assign to the property
            bool TestData = true;

            // Assign the data to the property
            AName.Attendance = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(TestData, AName.Attendance);


        }


        [TestMethod]
        public void FindMethodOK()
        {
            StaffName AName = new StaffName();
            Boolean Found = false;
            Int32 StaffID = 21;
            Found = AName.Find(StaffID);
            Assert.IsTrue(Found);   
        }

        [TestMethod]
        public void StaffAddress()
        {
            StaffName AName = new StaffName();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressID = 21;
            Found = AName.Find(AddressId);
            if (AName.DatePlaced != Convert.ToDateTime("23/12/2023"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffID()
        {
            StaffName AName = new StaffName();
            Boolean Found = false;  
            Boolean OK = true;
            Int32 StaffID = 21;
            Found = AName.Find(StaffID);
            if (AName.StaffID != "123")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void PostCode()
        {
            //create an instance of the class we want to create
            StaffName AName = new StaffName();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressId = 21;
            //invoke the method
            Found = AName.Find(AddressId);
            //check the post code property
            if (AName.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestDOB()
        {
            //create an instance of the class we want to create
            StaffName AName = new StaffName();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressId = 21;
            //invoke the method
            Found = AName.Find(AddressId);
            //check the date added property
            if (AName.DatePlaced != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsFalse(OK);
        }

        public void TestStaffName()
        {
            StaffName AName = new StaffName();
            Boolean Found = false;
            Boolean OK = true;
            Int32 NameStaff = 21;
            Found = AName.Find(NameStaff);
            if (AName.NameStaff != "123")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }


    }

}

