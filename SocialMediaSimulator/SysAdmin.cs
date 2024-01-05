using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator  
{
    internal class SysAdmin : IUser
    {
        public string creationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string accountId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CreateAccount()
        {
            Account account = new Account();
        }
    }
}
