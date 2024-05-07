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
    }
}
