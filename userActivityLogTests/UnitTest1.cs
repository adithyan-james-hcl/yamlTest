using Microsoft.VisualStudio.TestTools.UnitTesting;
using userActivityLog;




namespace userActivityLogTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testCheckLoginWithWrongCrednatials()
        {
            connectionClass testObj = new connectionClass (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsFalse(testObj.checkLogin("adithyan", "password"));

        }

        [TestMethod]
        public void testCheckLoginWithCorrectCrednatials()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsTrue(testObj.checkLogin("lorem", "12345"));

        }

        [TestMethod]
        public void testIfSystemIpmatch()
        {
            connectionClass testObj = new connectionClass (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.AreEqual(testObj.getIP(), "192.168.0.32");
        }

        [TestMethod]
        public void passwordCheckWithProperPassword()
        {
            connectionClass testObj = new connectionClass (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsTrue(testObj.password("qwe123"));
        }

        [TestMethod]
        public void passwordCheckWithOnlyLetters()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsFalse(testObj.password("qwewertt"));
        }
        [TestMethod]
        public void passwordCheckWithOnlynumbers()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsFalse(testObj.password("123456"));
        }
        [TestMethod]
        public void passwordCheckWithLessThanSixChar()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsFalse(testObj.password("12345"));
        }

        [TestMethod]
        public void checkInsertToTableInvalidQuerryToDatabase()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsFalse(testObj.insertToTable("insert to table v"));
        }
        [TestMethod]
        public void checkDoesUserExistWithExistingUer()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsTrue(testObj.doesUserExist("lorem"));
        }

        [TestMethod]
        public void checkDoesUserExist()
        {
            connectionClass testObj = new connectionClass(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\FIRSTPROJECT\DATA\SAMPLEDB.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Assert.IsFalse(testObj.doesUserExist("charles"));
        }


    }
}
