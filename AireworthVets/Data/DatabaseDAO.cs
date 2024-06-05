using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace AireworthVets
{
    class DatabaseDAO
    {

        private static string dbDirectory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + @"C:\Users\Admin\OneDrive\Desktop\University\Second Year\Software Development\Wood_Luke_Software_Development_Project_T2\AireworthVets\Data\UserShiftInfo.mdf" + @";Integrated Security=True"; //Must be changed when debugging and building. Doesn't need chnaging when running compiled release version given to client.

        public string searchPhrase;
        public SqlConnection dbcon = new SqlConnection(dbDirectory);   
        SqlDataReader reader;
      
        public List<Users> GetAllUserInfo()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            List<Users> returnThese = new List<Users>();
            dbcon.Open(); //Open connection to databse

            cmd.Connection = dbcon;
            cmd.CommandText = "SELECT ID, isAdmin, username FROM USERS";
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users all = new Users
                    {
                        ID = reader.GetInt32(0),
                        isAdmin = reader.GetBoolean(1),
                        username = reader.GetString(2)

                    };
                    returnThese.Add(all);
                }
            }
            dbcon.Close();

            return returnThese;
        }

        public List<Shifts> GetAllShiftInfo()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            List<Shifts> returnThese = new List<Shifts>();
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            cmd.CommandText = "SELECT ID, username, startDateTime, endDateTime, role, comments FROM Shifts";

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Shifts all = new Shifts
                    {
                        ID = reader.GetInt32(0),
                        username = reader.GetString(1),
                        startDateTime = reader.GetDateTime(2),
                        endDateTime = reader.GetDateTime(3),
                        role = reader.GetString(4),
                        comments = reader.GetString(5)

                    };
                    returnThese.Add(all);
                }
            }
            dbcon.Close();

            return returnThese;
        }

        public List<Shifts> GetUserShiftInfo()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory); //Database path to connect
            List<Shifts> returnThese = new List<Shifts>(); //Creates list object
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon; //Opens database connection
            cmd.CommandText = "SELECT ID, username, startDateTime, endDateTime, role, comments FROM Shifts Where username LIKE @search"; //Create query for records similar to username
            cmd.Parameters.AddWithValue("@search", searchPhrase);


            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Shifts all = new Shifts //Creates new shift object with query results
                    {
                        ID = reader.GetInt32(0),
                        username = reader.GetString(1),
                        startDateTime = reader.GetDateTime(2),
                        endDateTime = reader.GetDateTime(3),
                        role = reader.GetString(4),
                        comments = reader.GetString(5)

                    };
                    returnThese.Add(all); //Return all results
                }
            }
            dbcon.Close(); //Closes database connection

            return returnThese;
        }

        public List<Shifts> SearchShiftInfo(String searchUser)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            List<Shifts> returnThese = new List<Shifts>();
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            String searchPhrase = "%" + searchUser + "%";
            cmd.CommandText = "SELECT ID, username, startDateTime, endDateTime, role, comments FROM Shifts Where username LIKE @search";
            cmd.Parameters.AddWithValue("@search", searchPhrase);


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Shifts all = new Shifts
                    {
                        ID = reader.GetInt32(0),
                        username = reader.GetString(1),
                        startDateTime = reader.GetDateTime(2),
                        endDateTime = reader.GetDateTime(3),
                        role = reader.GetString(4),
                        comments = reader.GetString(5)

                    };
                    returnThese.Add(all);
                }
            }
            dbcon.Close();

            return returnThese;
        }

        public List<Shifts> SearchDateShiftInfo(DateTime D1, DateTime D2)
        {
            mainForm mainFrm = new mainForm();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            List<Shifts> returnThese = new List<Shifts>();
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            cmd.Parameters.AddWithValue("@d1", D1);
            cmd.Parameters.AddWithValue("@d2", D2);
            cmd.CommandText = "SELECT ID, username, startDateTime, endDateTime, role, comments FROM Shifts Where startDateTime between @d1 and @d2";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            mainFrm.shiftDataView.DataSource = dt;
            return returnThese;
        }

        public List<Users> SearchUserInfo(String searchUser)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            List<Users> returnThese = new List<Users>();
            dbcon.Open(); //Open connection to databse

            String searchPhrase = "%" + searchUser + "%";
            cmd.CommandText = "SELECT ID, isAdmin, username FROM Users Where username LIKE @search";
            cmd.Parameters.AddWithValue("@search", searchPhrase);
            cmd.Connection = dbcon;


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Users result = new Users
                    {
                        ID = reader.GetInt32(0),
                        isAdmin = reader.GetBoolean(1),
                        username = reader.GetString(2),

                    };
                    returnThese.Add(result);
                }
            }
            dbcon.Close();

            return returnThese;
        }

        internal int addShift(Shifts shift)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            cmd.CommandText = "INSERT INTO Shifts (username, startDateTime, endDateTime, role, comments) VALUES (@username, @startdate, @enddate, @role, @comments)";
            cmd.Parameters.AddWithValue("@username", shift.username);
            cmd.Parameters.AddWithValue("@startdate", shift.startDateTime);
            cmd.Parameters.AddWithValue("@enddate", shift.endDateTime);
            cmd.Parameters.AddWithValue("@role", shift.role);
            cmd.Parameters.AddWithValue("@comments", shift.comments);
            int newRows = cmd.ExecuteNonQuery();
            dbcon.Close();
            return newRows;
        }

        internal int addUser(Users user)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            cmd.CommandText = "INSERT INTO Users (username, password, isAdmin) VALUES (@username, @password, @isAdmin)";
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@isAdmin", user.isAdmin);
            int newRows = cmd.ExecuteNonQuery();
            dbcon.Close();
            return newRows;
        }

        public void deleteUser(int userID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            cmd.CommandText = "DELETE FROM Users WHERE Users.ID = @userID";
            cmd.Parameters.AddWithValue("@userID", userID);

            int result = cmd.ExecuteNonQuery();
            dbcon.Close();
        }

        public void deleteShift(int shiftID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection dbcon = new SqlConnection(dbDirectory);
            dbcon.Open(); //Open connection to databse
            cmd.Connection = dbcon;
            cmd.CommandText = "DELETE FROM Shifts WHERE Shifts.ID = @shiftID";
            cmd.Parameters.AddWithValue("@shiftID", shiftID);

            int result = cmd.ExecuteNonQuery();
            dbcon.Close();
        }

    }
}
