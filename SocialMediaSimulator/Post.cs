using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Post
    {
        string m_userName;
        string description;
        static int nextId;
        public int PostId { get; private set; }
        public static List<Post> posts = new List<Post>();

        public Post(UserAccount postingUser, string postContent)
        {
            PostId = Interlocked.Increment(ref nextId);
            // TODO
        }
    }
}
