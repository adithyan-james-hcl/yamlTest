using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace userActivityLog
{
    public class connectionClass
    {
        private string cnnString;

        public connectionClass()
        {

            cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["MyCnn"].ConnectionString;

        }

        public connectionClass(string cnn)
        {

            cnnString = cnn;

        }


        public bool checkLogin(string userName, string password)
        {
            string sqlQuerry = $"select count (*) as cnt from [Login] where [LON_Login_Name]='{userName}' and [LON_Login_Password]='{hash(password)}'";

            return (fetchFromTable(sqlQuerry));
        }
        public bool doesUserExist(string userName)
        {
            string sqlQuerry = $"select count (*) as cnt from [Login] where [LON_Login_Name]='{userName}'";

            return (fetchFromTable(sqlQuerry));
        }


        public void registerUser(string name, string empNo, string password, string type)
        {
            string sql = $"insert into [Login] VALUES ('{name}','{empNo}','{hash(password)}','{type}','active')";
            insertToTable(sql);
        }
        public void deleteUser(string name)
        {

            string sql = $" DELETE FROM [Login]WHERE  [LON_Login_Name]=('{name}')";
            insertToTable(sql);
        }

        public void writeActivity(string userName, string activty)
        {
            string sql = $"insert into [User_Activity_Log] VALUES ('{userName}','{activty}','{getIP()}')";

            insertToTable(sql);
        }

        public bool checkAdmin(string userName)
        {
            return false;
        }

        public bool insertToTable(string querry)
        {
            bool insertedStatus = false;

            try
            {
                using (SqlConnection cnn = new SqlConnection(cnnString))
                {
                    cnn.Open();

                    string sql = querry;

                    SqlCommand command;
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    insertedStatus = true;
                    command.Dispose();
                    cnn.Close();

                    return insertedStatus;
                }
            }
            catch
            {

                return insertedStatus;
            }
        }

        public bool fetchFromTable(string querry)
        {
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                string sqlQuerry = querry;

                SqlCommand scmd = new SqlCommand(sqlQuerry, cnn);
                scmd.Parameters.Clear();
                cnn.Open();
                try
                {
                    if (scmd.ExecuteScalar().ToString() == "1")
                    {
                        return true;
                    }
                }
                catch
                {
                    throw new Exception();
                }
            }

            return false;
        }

        public string getIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public bool password(string pwd)
        {
            if (pwd.Length < 5)
            {
                return false;
            }
            if (!pwd.Any(c => Char.IsDigit(c)))
            {
                return false;
            }
            if (!pwd.Any(c => Char.IsLetter(c)))
            {
                return false;
            }
            return true;
        }

        public static string hash(string message)
        {

            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(message);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToUpper();
        }




    }
}
