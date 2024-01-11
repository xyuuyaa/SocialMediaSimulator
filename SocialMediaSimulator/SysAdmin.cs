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
            IUser.users.Add(newUser);
        }

        public void DeleteAccount(IUser deleteAcc)
        {
            IUser.users.Remove(deleteAcc);
            // TODO delete every answer, comment, post with the same accountId
        }

        public void DeletePost(Post deletePost)
        {
            // TODO remove the Post with the according postId from the posts List
        }

        public void DeleteComment(Comment deleteComment)
        {
            // TODO remove the Comment with the according accountId from the Comments List
        }
    }
}
