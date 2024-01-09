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

        void DeletePost(int accountId, int postId);


        void DeleteComment(int accountId, int postId ,int commentId);
    }
}
