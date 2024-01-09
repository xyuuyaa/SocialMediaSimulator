using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator  
{
    internal class SysAdmin : IUser
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
            Program.users.Add(newUser);
        }

        public void DeleteAccount(int accountId)
        {
            // remove the user with the according accountId from the users List
        }

        public void DeletePost(int accountId, int postId)
        {
            // remove the Post with the according postId from the posts List
        }

        public void DeleteComment(int accountId, int postId, int commentId)
        {
            // remove the Comment with the according accountId from the Comments List
        }
    }
}
