﻿
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
    }
}
