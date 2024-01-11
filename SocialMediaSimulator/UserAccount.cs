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
        public int accountId { get; set; }
        public string accountName;

        public UserAccount(string accountName) 
        { 
            this.accountName = accountName; 
            accountId = Interlocked.Increment(ref IUser.nextId);
        }

        public override string ToString()
        {
            return $"Id: {accountId}, Name: {accountName}";
        }

        private void NewComment(UserAccount commentingUser,Post sourcePost, string commentContent)
        {
            Comment comment = new Comment(commentingUser, sourcePost, commentContent);
        }

        private void NewPost(UserAccount postingUser, string TextContent)
        {
            Post post = new Post(postingUser, TextContent);
        }

        private string getName(int postId) 
        {
            return this.accountName;
        }

        public void DeletePost(Post deletePost)
        {
            // TODO
            // delete every comment, answer with the same postId
        }

        public void DeleteComment(Comment deleteComment)
        {
            // TODO
            // delete every answer with the same postId
        }
    }
}
