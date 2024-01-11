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

        public Answer(UserAccount commentingUser, Post sourcePost, string commentContent) : base(commentingUser, sourcePost, commentContent)
        {
            // TODO
        }
    }
}
