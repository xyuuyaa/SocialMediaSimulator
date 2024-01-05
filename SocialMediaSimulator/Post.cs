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
        public int likeCount;
        static int nextId;
        public int PostId { get; private set; }
        List<string> Comments = new List<string>();

        public Post()
        {
            PostId = Interlocked.Increment(ref nextId);
        }
    }
}
