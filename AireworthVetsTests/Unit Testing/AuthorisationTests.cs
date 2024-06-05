using Microsoft.VisualStudio.TestTools.UnitTesting;
using AireworthVets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AireworthVets.Tests
{
    [TestClass()]
    public class AuthorisationTests
    {
        [TestMethod()]
        public void authCheck_Exists_True()
        {
            string username = "admin"; 
            string password = "Password";
            Authorisation authorisation = new Authorisation();
            try
            {
                authorisation.authCheck(username, password);
            }
            catch (Exception ex)
            {
                Assert.Fail("Could not handle");
            } // Attempts login with correct given credentials
        }

        [TestMethod()]
        public void authCheck_Exists_False()
        {
            string username = "This Is";
            string password = "Wrong";
            Authorisation authorisation = new Authorisation();
            try
            {
                authorisation.authCheck(username, password);
            }
            catch (Exception ex)
            {
                Assert.Fail("Could not handle");
            }// Attempts login with incorrect given credentials
        }
    }
}