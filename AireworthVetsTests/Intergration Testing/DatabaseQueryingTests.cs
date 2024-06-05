using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;
using AireworthVets;
using System.IO;

namespace AireworthVetsTests.Intergration_Testing
{
    [TestClass]
    public class DatabaseQueryingTests
    {
        private static string dbDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Desktop\University\Second Year\Software Development\AireworthVets\AireworthVets\Data\UserShiftInfo.mdf;Integrated Security=True";
        public SqlConnection dbcon = new SqlConnection(dbDirectory);

        [TestMethod]
        public void DBQuery_DataFound_Test()
        {
            try
            {             
                string Query = "SELECT ID, username, startDateTime, endDateTime, role, comments FROM Shifts"; 
                SqlDataAdapter sda = new SqlDataAdapter(Query, dbcon); 
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 1) 
                {
                    return;
                }
            }
            catch
            {
                Assert.Fail("Could not gather data from database");
            }
        }
    }
}
