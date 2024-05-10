using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class I want to create 
            clsSupplier  ASupplier = new clsSupplier();
            //Testing to see if it exists
            Assert.IsNotNull(ASupplier);
        }
    }
}
