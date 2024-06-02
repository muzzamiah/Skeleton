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

    
    }
}

