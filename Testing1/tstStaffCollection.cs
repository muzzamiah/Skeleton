using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaffs);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an Item to the List
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "07479875589";
            TestItem.StaffEmail = "hello@yahoo.com";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
            
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.StaffList, TestList);

        }



        [TestMethod]
        public void ThisStaffsPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            
            TestStaff.StaffDOB = DateTime.Now;
            TestStaff.DateAdded = DateTime.Now;
            TestStaff.StaffPhone = "07479875589";
            TestStaff.StaffEmail = "hello@yahoo.com";
            TestStaff.StaffFirstName = "John";
            TestStaff.StaffLastName = "Appleseed";
            
            //assign the data to the property
            AllStaffs.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //Add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "07479875589";
            TestItem.StaffEmail = "hello@yahoo.com";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
        
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethod()
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
            TestItem.StaffEmail = "hello@yahoo.com";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
        
            //set ThisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

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
            TestItem.StaffEmail = "hello@yahoo.com";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
            
            //set thisStaff to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //modify the test record
            
            TestItem.StaffDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffPhone = "0785850332";
            TestItem.StaffEmail = "hola@hotmail.co.uk";
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

        [TestMethod]
        public void DeleteMethod()
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
            TestItem.StaffEmail = "hello@yahoo.com";
            TestItem.StaffFirstName = "John";
            TestItem.StaffLastName = "Appleseed";
            //set ThisAddress to the test data
            AllStaffs.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaffs.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaffs.Delete();
            //now find the record
            Boolean Found = AllStaffs.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string
            FilteredStaffs.ReportByEmail("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaffs.Count, FilteredStaffs.Count);
        }

        [TestMethod]
        public void ReportByEmailNoneFound()
        {

            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //apply a blank string
            FilteredStaffs.ReportByEmail("random@ya9h95665oo.com");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredStaffs.Count);
        }

        //errors [TestMethod]
        public void ReportbyEmailTestDataFound()
        {
            //create an instance of the class we want to create
            clsStaffCollection FilteredStaffs = new clsStaffCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredStaffs.ReportByEmail("hola@hotmail.co.uk");
            //check that the correct number of records are find
            if (FilteredStaffs.Count == 1)
            {

                //check to see that the first record is 25
                if (FilteredStaffs.StaffList[0].StaffId != 25)
                {
                    OK = false;
                }
                //check to see that the first record is 26
                if (FilteredStaffs.StaffList[1].StaffId != 26)
                {
                    OK = false;
                }
            }
            else
            { OK = false; }
            //test to see that there are no records
            Assert.IsTrue(OK);



        }
    }
}