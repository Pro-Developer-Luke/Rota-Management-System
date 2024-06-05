using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Data;

namespace AireworthVetsTests.Unit_Testing
{
    [TestClass]
    public class RemovingShiftTests
    {
        private static string dbDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Desktop\University\Second Year\Software Development\AireworthVets\AireworthVets\Data\UserShiftInfo.mdf;Integrated Security=True";
        public SqlConnection dbcon = new SqlConnection(dbDirectory);
        SqlCommand cmd = new SqlCommand();

        [TestMethod]
        public void removingShifts_ID2_Test()
        {
            try
            {
                int removedID = 2;
                cmd.Connection = dbcon;
                cmd.CommandText = "DELETE FROM Shifts WHERE Shifts.ID = @shiftID";
                cmd.Parameters.AddWithValue("@shiftID", removedID);

                string loginQuery = "Select * from [Shifts] where ID= '" + removedID + "'"; //Credentials query
                SqlDataAdapter sda = new SqlDataAdapter(loginQuery, dbcon); //requests login query from connected database 
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl); //Fills data table with results of query
                if (dtbl.Rows.Count > 0) //checks if a record exists with given credentials 
                {
                    Assert.Fail("Shift with ID still exists");
                }
                else
                {
                    return;
                }
            }
            catch
            {
                return;
            }
        }
    }
}
