using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal interface IUser
    {
        int accountId { get; set; }
        static int nextId;
        public static List<IUser> users = new List<IUser>();

        void DeletePost(Post deletePost);

        void DeleteComment(Comment deleteComment);
    }
}
