using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Active = TestData;
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now;
            AStaff.DateAdded = TestData;
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestData = 1;
            AStaff.StaffId = TestData;
            Assert.AreEqual(AStaff.StaffId, TestData);
        }
        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.CountyCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.CountyCode, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStaff.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.HouseNo, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PostCode, TestData);
        }
        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            AStaff.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AStaff.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Town, TestData);
        }
        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        /******************PROPERTY DATA TESTS******************/
        [TestMethod]
        public void TestAddressIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address id property
            if (AStaff.StaffId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the house no property
            if (AStaff.HouseNo != "123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the street property
            if (AStaff.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the town property
            if (AStaff.Town != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the post code property
            if (AStaff.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountyCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the county code property
            if (AStaff.CountyCode != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the date added property
            if (AStaff.DateAdded != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the active property
            if (AStaff.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()

        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 6;
            Found = AStaff.Find(StaffId);
            if (AStaff.StaffId != 6)
            {
                OK = false;
            }
        }

        [TestMethod]
        public void TestStreetFoundID()

        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 6;
            Found = AStaff.Find(StaffId);
            if (AStaff.Street != "Eewrewr rwerewr")
            {
                OK = false;
            }

            Assert.IsFalse(OK);
        }
    }
}



