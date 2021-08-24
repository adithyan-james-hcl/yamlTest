using System;
using System.Windows.Forms;

namespace userActivityLog
{
    internal partial class loginPage : Form
    {
        public static string userNameToPass;
        
        public loginPage()
        {
            InitializeComponent();
        }



        private void login_Click(object sender, EventArgs e)
        {
            bool val = false;

            if (userName.Text != "" && password.Text != "")
            {
                connectionClass loginValidation = new connectionClass();
                val = loginValidation.checkLogin(userName.Text, password.Text);
                validLogin(val);
            }
            else
            {
                MessageBox.Show("please enter both credentials");
            }


        }

        public void validLogin(bool val)
        {
            if (val)
            {
                activityPage activityPage = new activityPage();
                activityPage.FormClosed += new FormClosedEventHandler(activityPageClosed);
                connectionClass obj = new connectionClass();
                userNameToPass = userName.Text;
                obj.writeActivity(userName.Text, "login");
                activityPage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("invalid ");
                connectionClass obj = new connectionClass();
                obj.writeActivity(userName.Text, "invalid login attempt");
                userName.Clear();
                password.Clear();
            }
        }



        private void activityPageClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            register registerPage = new register();

            registerPage.Show();
            this.Hide();
        }
    }
}