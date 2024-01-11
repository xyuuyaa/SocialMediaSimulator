using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Answer : Comment
    {
        string m_username;
        string initialContent;
        string content;
        public Comment _sourceComment;
        public Post _sourcePost; // ??
        public IUser _answeringUser;

        // TODO help, I need Parameter sourceComment
        public Answer(UserAccount commentingUser, Post sourcePost, string commentContent) : base(commentingUser, sourcePost, commentContent)
        {
            // _sourceComment = sourceComment;
            _sourcePost = sourcePost;
            _answeringUser = commentingUser;
        }
    }
}
