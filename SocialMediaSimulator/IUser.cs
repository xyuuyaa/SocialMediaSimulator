using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal interface IUser
    {
        string creationDate { get; set; }

        void DeletePost(int postId)
        {

        }

        void DeleteAccount(int accountId)
        {

        }

        void DeleteComment(int commentId) 
        { 
        
        }
    }
}
