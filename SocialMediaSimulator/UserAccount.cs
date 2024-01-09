using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator
{
    internal class UserAccount : IUser
    {
        string userName;
        static int nextId;
        public int accountId { get; set; }
        private string accountName;

        public UserAccount(string accountName) 
        { 
            this.accountName = accountName; 
            accountId = Interlocked.Increment(ref IUser.nextId);
        }

        public override string ToString()
        {
            return $"Id: {accountId}, Name: {accountName}";
        }

        private void Comment(int postId, string commentContent)
        {
            // Comments.Add(commentContent);
        }

        private void Post(int postId, string TextContent)
        {
            Post post = new Post();
        }

        private string getName(int postId) 
        {
            return this.accountName;
        }

        public void DeletePost(int accountId, int postId)
        {

        }


        public void DeleteComment(int accountId, int postId, int commentId)
        {

        }

    }
}
