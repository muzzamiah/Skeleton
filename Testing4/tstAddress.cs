
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class want to create 
            clsAddress AnAddress = new clsAddress();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]
        public void ProductAvailibity()
        //Create an instance of the class we want to create
        {
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnAddress.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnAddress.Active, TestData);
        }
        [TestMethod]
        public void OrderDate()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnAddress.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.OrderDate, TestData);
        }
        [TestMethod]
        public void ProductName()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "Keyboard";
            //assign the data to the property
            AnAddress.ProductName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.ProductName, TestData);
        }

        [TestMethod]
        public void Quantity()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Quantity, TestData);
        }
        [TestMethod]
        public void OrderNo()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.OrderNo, TestData);
        }
        [TestMethod]
        public void Price()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            decimal TestData = 19.99m;
            //assign the data to the property
            AnAddress.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Price, TestData);
        }
        [TestMethod]
        public void OrderAddress()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create some test data to assign to the property
            string TestData = "John Doe";
            //assign the data to the property
            AnAddress.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Name, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            // create a instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 Address = 21;
            //invoke the method
            Found = AnAddress.Find(AddressId);
            //test to see if the result is true
            Assert.IsTrue(Found);

            public bool Find(int AddressId)
            {
                //Always return true
                return true;

            }
        }
                [TestMethod]
                public void TestAddressIdFound()
                {
                    //create an instance of the class we want to create
                    clsAddress AnAddress = new clsAddress();
                    //create a Boolean variable to store the result of the search
                    Boolean Found = false;
                    //create a Boolean variable to record if the data is OK (assume it is)
                    Boolean OK = true;
                    //create some test data to use with the method
                    Int32 AddressId = 21;
                    //invoke the method
                    Found = AnAddress.Find(AddressId);
                    //check the address id property
                    if (AnAddress.AddressId != 21)
                    {
                        OK = false;
                    }
                    //test to see that the result is correct
                    Assert.IsTrue(OK);
                }
              
               


            }
        }
    

    

