using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace userActivityLog
{
    public partial class activityPage : Form
    {
        public activityPage()
        {
            InitializeComponent();

        }

        public void button_Click(object sender, EventArgs e)
        {
            connectionClass connectionObj = new connectionClass();
            string buttonName = (sender as Button).Text;
            string userName = loginPage.userNameToPass;
            connectionObj.writeActivity(userName, buttonName);

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            button_Click(sender, e);
            this.Close();
        }

        private void activityPage_Load(object sender, EventArgs e)
        {
            if (loginPage.userNameToPass != "lorem")
                deleteButton.Visible = false;

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            connectionClass connectionObj = new connectionClass();
            string userName = loginPage.userNameToPass;
            string deleteUser = Interaction.InputBox("eneter userName for deletion?", "delete user", "");
            if (deleteUser == "lorem")
            {
                MessageBox.Show("cannot delete admin ");
                connectionObj.writeActivity(userName, "delete attempt");
            }
            else
            {
                if (connectionObj.doesUserExist(deleteUser))
                {
                    connectionObj.deleteUser(deleteUser);
                    connectionObj.writeActivity(userName, "user deleted");
                    MessageBox.Show("user Deleted ");
                }
                else
                {
                    MessageBox.Show("user does not exist ");
                }
            }


        }
    }
}
