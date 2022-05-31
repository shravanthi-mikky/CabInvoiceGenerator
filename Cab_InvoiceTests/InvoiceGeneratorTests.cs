using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cab_Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice.Tests
{
    [TestClass()]
    public class InvoiceGeneratorTests
    {
        [TestMethod()]
        public void CalculateFareTest()
        {
            InvoiceGenerator uc1 = new();
            double fare1 = uc1.CalculateFare(10, 30);
            Assert.AreEqual(130,fare1);
        }
    }
}