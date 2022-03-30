using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var Login = "admin";
            var password = "admin";

            var LoginService = LoginService.Login(Login, password);

            Assert.Equals(LoginService, false);
        }
    }
}
