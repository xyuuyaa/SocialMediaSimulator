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
            foreach (Answer answer in Comment.comments) 
            { 
                if (answer._answeringUser.accountId == deleteAcc.accountId)
                {
                    Comment.comments.Remove(answer);
                }
            }
            foreach (Comment comment in Comment.comments) 
            {
                if (comment._commentingUser.accountId == deleteAcc.accountId)
                {
                    Comment.comments.Remove(comment);
                }
            }
            foreach (Post post in Post.posts) 
            {
                if (post._postingUser.accountId == deleteAcc.accountId)
                {
                    Post.posts.Remove(post);
                }
            }
            IUser.users.Remove(deleteAcc);
        }

        public void DeletePost(Post deletePost) { }

        public void DeleteComment(Comment deleteComment) { }
    }
}
