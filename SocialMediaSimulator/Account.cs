using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Account : IUser
    {
        string userName;
        public string creationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        static int nextId;
        public int accountId { get; private set; }

        public Account() 
        { 
            accountId = Interlocked.Increment(ref nextId);
        }

        private void GiveLike(int postId)
        {
            // increment likeCount at Post object with given postId
        }

        private void Comment(int postId, string commentContent)
        {
            // Comments.Add(commentContent);
        }
    }
}
