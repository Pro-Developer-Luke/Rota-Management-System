using System;
using System.Windows.Forms;

namespace AireworthVets
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
           
        }
        
        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Login button_click
        {
                Authorisation auth = new Authorisation(); //creates new authorisation class instance
                auth.authCheck(userNameTextBox.Text, userPassTextBox.Text); //Calls authCheck function using users inputs
            if (auth.isValid == true)
            {
                this.Hide();
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameClick(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "Username")
            {
                userNameTextBox.Text = "";
            }
        }

        private void passwordClick(object sender, EventArgs e)
        {
            if (userPassTextBox.Text == "Password")
            {
                userPassTextBox.Text = "";
            }
        }

        private void passChar(object sender, EventArgs e)
        {
            userPassTextBox.UseSystemPasswordChar = true;
        }
    }
}
