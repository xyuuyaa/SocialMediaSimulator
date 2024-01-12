using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Answer : Comment
    {
        public IUser _answeringUser;

        public Answer(UserAccount commentingUser, Post sourcePost, string commentContent, Comment sourceComment = null) : base(commentingUser, sourcePost, commentContent, sourceComment)
        {
            _answeringUser = commentingUser;
        }

        public override string ToString()
        {
            return $"\nAnswer under the Comment {_sourceComment} from {_answeringUser}: {_commentContent}";
        }
    }
}
