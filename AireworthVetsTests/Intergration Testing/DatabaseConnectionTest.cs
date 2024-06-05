using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace AireworthVetsTests.Intergration_Testing
{
    [TestClass]
    public class DatabaseConnectionTest
    {
        string dbDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Desktop\University\Second Year\Software Development\AireworthVets\AireworthVets\Data\UserShiftInfo.mdf;Integrated Security=True";
        [TestMethod]
        public void loginDBconnection_Test()
        {
            try
            {
                SqlConnection dbcon = new SqlConnection(dbDirectory);
                return;
            }
            catch
            {
                Assert.Fail("Database could not be located");
            }
        }
    }
}
