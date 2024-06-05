using AireworthVets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace AireworthVetsTests
{
    [TestClass]
    public class isAdminTests
    {
        [TestMethod]
        public void isAdmin_True_Test()
        {
            mainForm mainFrm = new mainForm();
            mainFrm.isAdmin = true;
            mainFrm.Show();
            if (mainFrm.addShiftBox.Enabled == true)
            {
                return;
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void isAdmin_False_Test()
        {
            mainForm mainFrm = new mainForm();
            mainFrm.isAdmin = false;
            mainFrm.Show();
            if (mainFrm.addShiftBox.Enabled == false)
            {
                return;
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
