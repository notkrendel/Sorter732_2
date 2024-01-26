using _732_2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sort sorter = new Sort();
            string input = "����Ĩ��";
            string KeyWord = "����";
            string Output2 = "��ɨ����";
            string c = sorter.Encrypt(input, KeyWord);
            Assert.AreEqual(c, Output2);
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            Sort sorter = new Sort();
            string input = "��ɨ����";
            string KeyWord = "����";
            string Output2 = "����Ĩ��";
            string c = sorter.Decrypt(input, KeyWord);
            Assert.AreEqual(c, Output2);
        }
    }

    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            bool Auth = true;
            string AuthLogin = "user1234";
            string AuthPwd = "12341234";
            DBManager DBmanager = new DBManager("D:\\1234\\DB Kursach\\users.db");
            Assert.AreEqual(Auth, DBmanager.CheckUser(AuthLogin, AuthPwd));
        }
    }

    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            bool Auth = false;
            string AuthLogin = "user1234";
            string AuthPwd = "12341235";
            DBManager DBmanager = new DBManager("D:\\1234\\DB Kursach\\users.db");
            Assert.AreEqual(Auth, DBmanager.CheckUser(AuthLogin, AuthPwd));
        }
    }
}