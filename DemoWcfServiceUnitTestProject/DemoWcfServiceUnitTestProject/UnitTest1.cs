﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoWcfServiceUnitTestProject.WcfServiceReference;

namespace DemoWcfServiceUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        static private Service1Client client;
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new Service1Client();
        }

        [TestMethod]
        public void TestGetData()
        {
            // arrange

            // act
            String result = client.GetData(1);
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
            CompositeType result = client.GetDataUsingDataContract(c);
            // assert
            Assert.AreEqual(result.BoolValue, false);
            Assert.AreEqual(result.StringValue, "Hello!");
        }
    }
}
