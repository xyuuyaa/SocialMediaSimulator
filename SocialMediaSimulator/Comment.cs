using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Comment
    {
        string m_userName;
        string content;
        static int nextId;
        public int CommentId { get; private set; }
        public static List<Comment> comments = new List<Comment>();

        public Comment(UserAccount commentingUser, Post sourcePost, string commentContent)
        {
            CommentId = Interlocked.Increment(ref nextId);
            // TODO
        }
    }
}
