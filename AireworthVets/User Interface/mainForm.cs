using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace AireworthVets
{
    public partial class mainForm : Form
    {
        BindingSource userBindingSource = new BindingSource();
        BindingSource shiftBindingSource = new BindingSource();

        public mainForm()
        {
            InitializeComponent();
        }

        public string user;
        public string motdPath = Environment.CurrentDirectory + "/" + "MOTDdata.txt";
        DatabaseDAO dao = new DatabaseDAO();

        public bool isAdmin;
        private void mainForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(motdPath)) //Creates the MOTD file if it does not already exist
            {
                File.CreateText(motdPath);
                setMotd("First initiation of MOTD");
            }
            else
            {
                getMotd();
            }
            checkMsgTimer.Start(); //Starts timer that refreshes MOTD message
            if (isAdmin == true)
            {
                infoLabel.Text = "Employee: " + user + "\nAccess type: Admin";               
                FillComboBox(); //Fills username combobox for adding new shift (Quick Search)
            }
            else
            {
                infoLabel.Text = "Employee: " + user + "\nAccess type: Default";
                dataTab.TabPages.Remove(userTab); //Removes user tab (Admin access only)
                addShiftBox.Enabled = false; //Disables access to add new shifts (Admin access only)
                shiftDataView.ReadOnly = true; //Makes table read-only
                motdRichTextBox.ReadOnly = true;
                setMsgBtn.Enabled = false;
                motdClearBtn.Enabled = false;
                refreshChk.Enabled = false;
            }
        }

        private void FillComboBox()
        {
            dao.dbcon.Open();
            SqlCommand cmdusers = new SqlCommand("SELECT username FROM USERS", dao.dbcon);
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmdusers;
            DataTable dtblusers = new DataTable();
            sda.Fill(dtblusers);
            shiftUserCombo.DataSource = dtblusers;
            shiftUserCombo.DisplayMember = "username";
            dao.dbcon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = dao.GetAllUserInfo();
            userDataView.DataSource = userBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shiftBindingSource.DataSource = dao.GetAllShiftInfo();
            shiftDataView.DataSource = shiftBindingSource;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dao.searchPhrase = user;
            shiftBindingSource.DataSource = dao.GetUserShiftInfo();
            shiftDataView.DataSource = shiftBindingSource;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            shiftBindingSource.DataSource = dao.SearchShiftInfo(shiftSearchBox.Text);
            shiftDataView.DataSource = shiftBindingSource;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userBindingSource.DataSource = dao.SearchUserInfo(userSearchBox.Text);
            userDataView.DataSource = userBindingSource;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Shifts shift = new Shifts
            {
                username = shiftUserCombo.Text,
                role = shiftRoleCombo.Text,            
                startDateTime = startDate.Value,
                endDateTime = endDate.Value,
                comments = commentsBox.Text
            };
            int result = dao.addShift(shift);
            MessageBox.Show("Shifts have been updated.\n[1] new shift added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            shiftBindingSource.DataSource = dao.GetAllShiftInfo();
            shiftDataView.DataSource = shiftBindingSource;
        }

        private void shiftSearchBox_Click(object sender, EventArgs e)
        {
            if (shiftSearchBox.Text == "Search by name")
            {
                shiftSearchBox.Text = "";
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (defChck.Checked == true)
            {
                adminChck.Checked = false;
            }
        }

        private void adminCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (adminChck.Checked == true)
            {
                defChck.Checked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                username = nameTextBox.Text,
                password = passTextBox.Text,
                isAdmin = adminChck.Checked
            };
            int result = dao.addUser(user);
            MessageBox.Show("Users have been updated.\nNew user: " + nameTextBox.Text + " Has been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userBindingSource.DataSource = dao.GetAllUserInfo();
            userDataView.DataSource = userBindingSource;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = Int32.Parse(userIDTextBox.Text);
                dao.deleteUser(userID);
                userBindingSource.DataSource = dao.GetAllUserInfo();
                userDataView.DataSource = userBindingSource;
                MessageBox.Show("Users have been updated.\n[1] user removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("erroe");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        public void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int shiftID = Int32.Parse(shiftIDTextBox.Text);
                dao.deleteShift(shiftID);
                shiftBindingSource.DataSource = dao.GetAllShiftInfo();
                shiftDataView.DataSource = shiftBindingSource;
                MessageBox.Show("Shifts have been updated.\n[1] shift removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("erroe");
            }
        }

        private void userSearchBox_Click(object sender, EventArgs e)
        {
            if (userSearchBox.Text == "Search by name")
            {
                userSearchBox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void setMotd(string setMotdText)
        {
            using (StreamWriter sw = new StreamWriter(motdPath))
            {
                sw.WriteLine(setMotdText);
            }
        }

        public void getMotd()
        {
            using (StreamReader sr = new StreamReader(motdPath))
            {
                string newMotd = sr.ReadLine();
                motdRichTextBox.Text = newMotd;
            }
        }

        private void motdClear_Click(object sender, EventArgs e)
        {
            motdRichTextBox.Text = "";
            setMotd("");
            MessageBox.Show("All announcements have being cleared", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newMsgBtn_Click(object sender, EventArgs e)
        {
            setMotd(user + ": " + motdRichTextBox.Text + " (" + DateTime.Now + ")");
            MessageBox.Show("Your announcement has been added for all employees. Previous announcement has been cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkMsgTimer_Tick(object sender, EventArgs e)
        {
            getMotd();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (refreshChk.Checked == true)
            {
                checkMsgTimer.Start();
            }
            else 
            {
                checkMsgTimer.Stop(); 
            }
        }
    }
}
