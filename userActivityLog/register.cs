using System;
using System.Windows.Forms;

namespace userActivityLog
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            connectionClass obj = new connectionClass();
            /*
             * passwordcheck will check if the password matche specified requirement before a user can register with it
             * doesUser Exist will check if the user alredy exist in the database
             */
            if (!String.IsNullOrWhiteSpace(userName.Text)  && !String.IsNullOrWhiteSpace(employeeId.Text) && !String.IsNullOrWhiteSpace(type.Text))
            {
               

                if (obj.password(pwd.Text))
                {
                    if (!obj.doesUserExist(userName.Text))
                    {
                        obj.registerUser(userName.Text, employeeId.Text, pwd.Text, type.Text);
                        obj.writeActivity(userName.Text, "register");
                        MessageBox.Show("registration successfull");
                        loginPage login = new loginPage();
                        login.FormClosed += new FormClosedEventHandler(loginPageClosed);
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("user already exist in database");
                    }
                }
                else
                {
                    MessageBox.Show("password should contain letter digit and be of atleast 6 cahr");
                }
            }
            else
            {
                MessageBox.Show("all fields are mandatory");
            }

        }

        private void loginPageClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.FormClosed += new FormClosedEventHandler(loginPageClosed);
            login.Show();
            this.Hide();
        }
    }
}
