using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tstAddress.cs
{
    [TestClass]

    public class tstAddress
    
    {
        [TestMethod]
    
        public void InstanceOK()
        
        {
        
            clsAddress AnAddress = new clsAddress();
            
            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]

        public void ActivePropertyOK()
        
            clsAddress AnAddress = new clsAddress();
        
            Boolean TestData = true;
            
            AnAddress.Active = TestData;
            
            Assert.AreEqual(AnAddress.Active, TestData);

    }
}

]
