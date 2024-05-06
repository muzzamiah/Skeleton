using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOKc()
        //Create an instance of the class we want to create
        clsSupplier ASupplier = new clsSupplier();
        //Test to see that it exists 
        Assert.IsNotNull(ASupplier);
        
        }
    }
