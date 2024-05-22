
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

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
            AName.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AName.DateAdded, TestData);
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

    }

}