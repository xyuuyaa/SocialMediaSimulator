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

        void DeletePost(Post deletePost)
        {
            foreach (Answer answer in Comment.comments)
            {
                if (answer._sourcePost.PostId == deletePost.PostId)
                {
                    Comment.comments.Remove(answer);
                } 
            }
            foreach (Comment comment in Comment.comments)
            {
                if (comment._sourcePost.PostId == deletePost.PostId)
                {
                    Comment.comments.Remove(comment);
                }
            }
            Post.posts.Remove(deletePost);
        }

        void DeleteComment(Comment deleteComment)
        {
            foreach (Answer answer in Comment.comments)
            {
                if (deleteComment.CommentId == answer.CommentId) // TODO change answer.CommentId to answer._sourceComment.CommentId
                {
                    Comment.comments.Remove(answer);
                }
            }
            Comment.comments.Remove(deleteComment);
        }
    }
}
