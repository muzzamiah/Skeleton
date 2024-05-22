
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
        public void ActivePropertyOK()
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
        public void OrderDatePropertyOK()
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
        public void PrdouctNamePropertyOK()
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
        public void QuantityPropertyOK()
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
        public void OrderNoPropertyOK()
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
        public void PricePropertyOK()
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
        public void NamePropertyOK()
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

    }
}
