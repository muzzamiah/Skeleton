using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //Create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }



        [TestMethod]
        public void ThisCustomersPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.AgeCheck = true;
            TestCustomer.CustomerDOB = DateTime.Now;
            TestCustomer.DateAdded = DateTime.Now;
            TestCustomer.CustomerPhone = "07479875589";
            TestCustomer.CustomerEmail = "hello@yahoo.com";
            TestCustomer.CustomerFirstName = "John";
            TestCustomer.CustomerLastName = "Appleseed";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //set thiscustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //modify the test record
            TestItem.AgeCheck = false;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "0785850332";
            TestItem.CustomerEmail = "hola@hotmail.co.uk";
            TestItem.CustomerFirstName = "Jennifer";
            TestItem.CustomerLastName = "Lopez";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethod()
        {

            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.AgeCheck = true;
            TestItem.CustomerDOB = DateTime.Now;
            TestItem.DateAdded = DateTime.Now;
            TestItem.CustomerPhone = "07479875589";
            TestItem.CustomerEmail = "hello@yahoo.com";
            TestItem.CustomerFirstName = "John";
            TestItem.CustomerLastName = "Appleseed";
            //set ThisAddress to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByEmailMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string
            FilteredCustomers.ReportByEmail("*************");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByEmailNoneFound()
        {
            
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string
            FilteredCustomers.ReportByEmail("hello@yahoo.com");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
    }
}

