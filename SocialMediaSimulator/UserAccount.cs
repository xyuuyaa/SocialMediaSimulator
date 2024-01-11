using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator
{
    internal class UserAccount : IUser
    {
        public int accountId { get; set; }
        public string accountName;

        public UserAccount(string accountName) 
        { 
            this.accountName = accountName; 
            accountId = Interlocked.Increment(ref IUser.nextId);
        }

        public override string ToString()
        {
            return $"Id: {accountId}, Name: {accountName}";
        }

        public void NewPost(UserAccount postingUser, string TextContent)
        {
            Post post = new Post(postingUser, TextContent);
        }

        public void NewComment(UserAccount commentingUser,Post sourcePost, string commentContent)
        {
            Comment comment = new Comment(commentingUser, sourcePost, commentContent);
        }

        public void NewAnswer(UserAccount answeringUser, Post sourcePost, Comment sourceComment, string answerContent) 
        {
            Answer answer = new Answer(answeringUser, sourcePost, answerContent);    // TODO use sourceComment
        }

        public string getName(int postId) 
        {
            return this.accountName;
        }

        public void DeletePost(Post deletePost)
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

        public void DeleteComment(Comment deleteComment)
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
