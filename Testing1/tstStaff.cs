using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        string StaffFirstName = "John";
        string StaffLastName = "Doe";
        string StaffDOB = DateTime.Now.ToShortDateString();
        string StaffRole = "Manager";
        string StaffPhone = "123-456-7890";
        string DateAdded = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

     

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }


        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create some test data for the property
            string TestData = "John";
            // Assign the data to the property
            AStaff.StaffFirstName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create some test data for the property
            string TestData = "Doe";
            // Assign the data to the property
            AStaff.StaffLastName = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }
        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create some test data for the property
            DateTime TestData = new DateTime(1990, 5, 13); // Example date of birth
            // Assign the data to the property
            AStaff.StaffDOB = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDOB, TestData);
        }

        [TestMethod]
        public void StaffRolePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create some test data for the property
            string TestData = "Manager";
            // Assign the data to the property
            AStaff.StaffRole = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffPhonePropertyOK()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // Create some test data for the property
            string TestData = "123-456-7890";
            // Assign the data to the property
            AStaff.StaffPhone = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPhone, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 6;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable t record if the data is OK
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 StaffId = 4;
            //invoke the method
            Found = AStaff.Find(StaffId);
            //check the address id
            if (AStaff.StaffId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff AStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.DateAdded != Convert.ToDateTime("23/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            clsStaff AStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.StaffFirstName != "Jordan")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            // Arrange
            clsStaff AStaff = new clsStaff();
            int testStaffId = 1; // Use a valid StaffId that exists in the test database

            // Act
            bool found = AStaff.Find(testStaffId);

            // Assert
            Assert.IsTrue(found, "The staff member was not found when expected.");

            // Check if StaffLastName is set
            Assert.IsNotNull(AStaff.StaffLastName, "StaffLastName was not set.");
        }


        [TestMethod]
        public void TestStaffDOBFound()
        {
            clsStaff AStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.StaffDOB != Convert.ToDateTime("02/09/2002"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRoleFound()
        {
            clsStaff AStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.StaffRole != "Manager")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneFound()
        {
            clsStaff AStaff = new clsStaff();
            bool Found = false;
            bool OK = true;
            int StaffId = 4;
            Found = AStaff.Find(StaffId);
            if (AStaff.StaffPhone != "07834572379")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid (StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "A"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "Aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaa"; //this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "aaaaaaa"; //this should trigger an error
                                                  //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(500, 'a'); //this should trigger an error
            //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
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
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffPhoneMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffPhone = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPhone = "a";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPhone = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void STaffPhoneMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPhone = "";
            StaffPhone = StaffPhone.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPhone = "";
            StaffPhone = StaffPhone.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPhoneMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffPhone = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffPhone = "";
            StaffPhone = StaffPhone.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffRole = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffRoleMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffRole = "a";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffRole = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(49, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffRoleMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(50, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRolePlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(51, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffRoleMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(25, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set the date totodays date
            TestDOB = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDOB = TestDOB.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set the date totodays date
            TestDOB = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDOB = TestDOB.AddDays(-1);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set the date totodays date
            TestDOB = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set the date totodays date
            TestDOB = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDOB = TestDOB.AddDays(1);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set the date totodays date
            TestDOB = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDOB = TestDOB.AddYears(100);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string StaffDOB = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffDOB, StaffPhone, StaffRole, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "07479875589";
            TestItem.StaffRole = "Manager";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
            //set thisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            TestItem.AgeCheck = false;
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "0785850332";
            TestItem.StaffRole = "Manager";
            TestItem.StaffFirstName = "Jennifer";
            TestItem.StaffLastName = "Lopez";
            //set the record based on the new test data
            AllStaffs.ThisStaff = TestItem;
            //update the record
            AllStaffs.Update();
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
    }
}


