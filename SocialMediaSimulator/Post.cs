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
        public IUser _postingUser;
        public string _postContent;

        public Post(UserAccount postingUser, string postContent)
        {
            PostId = Interlocked.Increment(ref nextId);
            posts.Add(new Post(postingUser, postContent));
            _postingUser = postingUser;
            _postContent = postContent;
        }

        public override string ToString()
        {
            return $"\nPost {PostId} from {_postingUser}, PostContent: {_postContent}";
        }
    }
}
