using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoWcfService;

namespace DemoWcfServiceUnitTestDirect
{
    [TestClass]
    public class UnitTest1
    {
        Service1 service;

        [TestInitialize()]
        public void Initialize()
        {
            service = new Service1();
        }

        [TestMethod]
        public void TestGetData()
        {
            // arrange

            // test act
            String result = service.GetData(1);
            // assert
            Assert.AreEqual(result, "You entered: 1");
        }

        [TestMethod]
        public void TestGetDataWithComposite()
        {
            // arrange
            CompositeType c = new CompositeType();
            c.BoolValue = false;
            c.StringValue = "Hello!";
            // act
            CompositeType result = service.GetDataUsingDataContract(c);
            // assert
            Assert.AreEqual(result.BoolValue, false);
            Assert.AreEqual(result.StringValue, "Hello!");
        }
    }
}
