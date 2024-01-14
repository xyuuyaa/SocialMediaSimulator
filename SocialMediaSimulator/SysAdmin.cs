using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator  
{
    public class SysAdmin : IUser
    {
        public int accountId { get; set; }

        public SysAdmin()
        {
            accountId = Interlocked.Increment(ref IUser.nextId);
        }

        public override string ToString()
        {
            return $"Id: {accountId}, Name: Admin";
        }

        public void AddAccount(string userName)
        {
            UserAccount newUser = new UserAccount(userName);
            IUser.users.Add(newUser);
        }

        public void DeleteAccount(IUser deleteAcc)
        {
            IUser.users.Remove(deleteAcc);
        }
    }
}
