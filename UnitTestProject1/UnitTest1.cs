using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormUI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b", "1")]
        [DataRow("e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", "")]
        [DataRow("fa6d88e412718dec4aed25fcf2c96b32488eaab9ceeb1b8e5bfa07b375022147", "cool string bro")]
        [DataRow("899c20e2b6b7239ca49501979aa0cc1709d9048a66bfcff27badc845d44ea31f", "Cool string bro")]
        public void TestHashEncoding(string expectedHashCode, string stringToHashCode)
        {
            var c = PasswordEncrypter.Encrypt(stringToHashCode);
            Assert.AreEqual(expectedHashCode, c);
        }

        [TestMethod]
        public void Test_Helper_CnnValMethod()
        {
            var c = Helper.CnnVal("BlogAppDB");
            Assert.AreEqual(@"Server=(localdb)\MSSQLLocalDB;Database=MainDB;Trusted_Connection=True;", c);
        }

        [TestMethod]
        public void Test_DataAccess_GetBlogPostsMethod()
        {
            DataAccess db = new DataAccess();
            var list = db.GetBlogPosts();
            var c = new BlogPost
            {
                Id = 1,
                UserId = 1,
                PostTitle = "title",
                PostContents = "nothing"
            };
            Assert.AreEqual(c, list[0]);
        }

        [DataTestMethod]
        [DataRow("bla", "ok", true)]
        [DataRow("no username", "no password", false)]
        [DataRow("NULL", "NULL", false)]
        [DataRow(null, null, false)]
        public void Test_DataAccess_LogInMethod(string username, string password, bool anticipatedResult)
        {
            var result = DataAccess.LogIn(username, password);
            Assert.AreEqual(anticipatedResult, result);
        }
    }
}
