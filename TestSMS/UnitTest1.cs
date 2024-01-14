using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using SocialMediaSimulator;

namespace TestSMS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddAccount()
        {
            // Arrange 
            SysAdmin admin = new SysAdmin();
            IUser.users.Add(admin);
            string expectedToString = "Id: 2, Name: user2"; 
            string actualToString;

            // Act and Assert
            admin.AddAccount("user2");
            foreach (var user in IUser.users)
            {
                if (user.accountId == 2)
                {
                    actualToString = user.ToString();
                    Assert.AreEqual(expectedToString, actualToString);  
                }
            } 
        }
    }
}