using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AireworthVets
{
    public class Authorisation
    {
        public bool isValid;
        public void authCheck(String userNameInput, String userPassInput) //Login function
        {
            try
            {
                DatabaseDAO dao = new DatabaseDAO(); //First initiation of the database Handler (Data Access Object)
                string loginQuery = "Select * from [Users] where username= '" + userNameInput + "' and password= '" + userPassInput + "'"; //Credentials query
                SqlDataAdapter sda = new SqlDataAdapter(loginQuery, dao.dbcon); //requests login query from connected database 
                DataTable dtbl = new DataTable(); 
                sda.Fill(dtbl); //Fills data table with results of query
                if (dtbl.Rows.Count == 1) //checks if a record exists with given credentials 
                {
                    mainForm mainFrm = new mainForm();
                    string isAdminQuery = "Select * from [Users] where username= '" + userNameInput + "' and isAdmin=1";
                    SqlDataAdapter sda1 = new SqlDataAdapter(isAdminQuery, dao.dbcon); 
                    DataTable dtbl1 = new DataTable();
                    sda1.Fill(dtbl1);
                    if (dtbl1.Rows.Count == 1)
                    {
                        mainFrm.isAdmin = true; //Sets isAdmin bool based on query result
                        mainFrm.user = userNameInput; //Sets username for following query searches

                    }            
                    else
                    {
                        mainFrm.isAdmin = false;
                        mainFrm.user = userNameInput;
                    }                   
                    mainFrm.Show();
                    loginForm logFrm = new loginForm();
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("User not found!\nPlease make sure you are using the correct credentials.\n\nAlternativley, please contact an administrator.", "Unsuccessful attempt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
                }
            
            }
            catch(Exception ex)
            {
                string errorMsg = ex.Message; 
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error); //Displays exception message
            }
        }
    }
}
