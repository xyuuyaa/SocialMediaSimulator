﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator
{
    public class UserAccount : IUser
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
            Answer answer = new Answer(answeringUser, sourcePost, answerContent, sourceComment);  
        }

        public string getName(int postId) 
        {
            return this.accountName;
        }
    }
}
