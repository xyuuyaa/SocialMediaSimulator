using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    public class Comment
    {
        static int nextId;
        public int CommentId { get; private set; }
        public static List<Comment> comments = new List<Comment>();
        public Post _sourcePost;
        public IUser _commentingUser;
        public Comment _sourceComment;
        public string _commentContent;

        public Comment(UserAccount commentingUser, Post sourcePost, string commentContent, Comment sourceComment = null)
        {
            CommentId = Interlocked.Increment(ref nextId);
            comments.Add(this);
            _sourcePost = sourcePost;
            _commentingUser = commentingUser;
            _sourceComment = sourceComment;
            _commentContent = commentContent;
        }

        public override string ToString()
        {
            return $"\nComment under the Post {_sourcePost} from {_commentingUser}: {_commentContent}";
        }
    }
}
