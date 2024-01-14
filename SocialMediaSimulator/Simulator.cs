using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialMediaSimulator
{
    internal class Simulator 
    {
        static SysAdmin adminUser;
        static UserAccount accountUser;
        static Post deletePost;
        static Comment deleteComment;
        public Simulator() 
        {
            SysAdmin admin1 = new SysAdmin();
            IUser.users.Add(admin1);
        }
        public void StartMenu()
        {
            Console.WriteLine("START MENU\nWelcome to the SocialMediaSimulator!\nWhich user do you want to use?\t If you want to exit, press 0");
            foreach (IUser user in IUser.users)
            {
                Console.WriteLine(user);
            }

            int chosenUserNr = int.Parse(Console.ReadLine());

            if (chosenUserNr == 0)
            {
                Environment.Exit(0);
            }

            foreach (var user in IUser.users)
            {
                if (user.accountId == chosenUserNr)
                {
                    IUser currentUser = user;
                    if (currentUser.accountId == 1)
                    {
                        adminUser = (SysAdmin)currentUser;
                        Console.Clear();
                        MainMenuAdmin();
                    }
                    else if (currentUser.accountId > 1)
                    {
                        accountUser = (UserAccount)currentUser;
                        Console.Clear();
                        UserAccount accUser = (UserAccount)currentUser;
                        MainMenuUserAcc(accUser);
                    }
                    
                }
            }
            Console.Clear();
            Console.WriteLine("Invalid Id Number\n\n");
            StartMenu(); 
        }

        private void MainMenuAdmin()
        {
            Console.WriteLine("MAIN MENU\n\nYou are now active as the admin !\nWhat do you want to do?\n1 Add new account.\t2 Delete account.\t3 Go back to Start Menu.");
            int chosenMainActivity = int.Parse(Console.ReadLine());
            Console.Clear();
            ActivityMenuAdmin(chosenMainActivity);
        }

        private void ActivityMenuAdmin(int chosenMainActivity)
        {
            switch (chosenMainActivity)
            {
                case 1:
                    Console.WriteLine("Type a name for the new account: ");
                    string accName = Console.ReadLine();
                    if (accName == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Account name can't be null.");
                        ActivityMenuAdmin(1);
                    }
                    adminUser.AddAccount(accName);
                    StartMenu();
                    break;
                case 2:
                    Console.WriteLine("Type the Id of the User you want to delete.\n");
                    foreach (IUser user in IUser.users)
                    {
                        Console.WriteLine(user);
                    }
                    int deleteUserId = int.Parse(Console.ReadLine());
                    if (deleteUserId > IUser.users.Count)
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Id Number\n\n");
                        StartMenu();
                    }
                    foreach (var d_user in IUser.users)
                    {
                        if (d_user.accountId == deleteUserId)
                        {
                            IUser deleteUser = d_user;
                            if (deleteUser.accountId == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("You can't delete the admin");
                                ActivityMenuAdmin(2);
                            }
                            else if (deleteUser.accountId > 1) 
                            {
                                adminUser.DeleteAccount(deleteUser);
                                Console.Clear();
                                StartMenu();
                            }
                        }   
                    }
                    StartMenu();
                    break;
                case 3:
                    StartMenu();
                    break;
            }
        }

        public void MainMenuUserAcc(UserAccount user)
        {
            Console.WriteLine($"MAIN MENU\n\nYou are now active as {user.accountName} !\nWhat do you want to do?\n1 Add new Post.\t2 Look at Posts.\t3 Go to start menu.");
            int chosenMainActivity = int.Parse(Console.ReadLine());
            Console.Clear();
            ActivityMenuUserAcc(chosenMainActivity);
        }

        private void ActivityMenuUserAcc(int chosenMainActivity)
        {
            switch (chosenMainActivity)
            {
                case 1:
                    Console.WriteLine("Type the Content for your Post. Submit with ENTER");
                    string postContent = Console.ReadLine();
                    accountUser.NewPost(accountUser, postContent);
                    StartMenu();
                    break;
                case 2:
                    UserAccPosts();
                    break;
                case 3:
                    StartMenu();
                    break;
            }
        }

        private void UserAccPosts() 
        {
            foreach (Post post in Post.posts) 
            {
                Console.WriteLine(post);
            }
            foreach (var comment in Comment.comments)
            {
                Console.WriteLine(comment);
            }
            /*foreach (Answer answer in Comment.comments)
            {
                Console.WriteLine(answer);
            }*/
            Console.WriteLine("What do you want to do?\n1 Add comment\t2 Return to start menu");
            int chosenSubActivity = int.Parse(Console.ReadLine());
            switch (chosenSubActivity)
            {
                case 1:
                    Console.WriteLine("1 Add comment to post.\t2 Add Answer to comment");
                    int commentTypeChoice = int.Parse(Console.ReadLine());
                    if (commentTypeChoice == 1)
                    {
                        Console.WriteLine("Type the Id of the Post where you want to add your comment.");
                        int commentPostId = int.Parse(Console.ReadLine());
                        foreach (Post post in Post.posts)
                        {
                            if (post.PostId == commentPostId)
                            {
                                Console.WriteLine("Type your comment content: ");
                                string commentContent = Console.ReadLine();
                                accountUser.NewComment(accountUser, post, commentContent);
                                Console.Clear();
                                StartMenu();
                            }
                            else if (commentPostId > post.PostId)
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Id Number\n\n");
                                UserAccPosts();
                            }
                        }
                        StartMenu();
                    }
                    else if (commentTypeChoice == 2)
                    {
                        Console.WriteLine("Type the Id of the Comment where you want to add your answer.");
                        int AnswerCommentId = int.Parse(Console.ReadLine());
                        foreach (Comment comment in Comment.comments)
                        {
                            if (comment.CommentId == AnswerCommentId)
                            {
                                Console.WriteLine("Type your answer content: ");
                                string answerContent = Console.ReadLine();
                                accountUser.NewAnswer(accountUser, comment._sourcePost, comment, answerContent);
                                Console.Clear();
                                StartMenu();
                            }
                            else if (AnswerCommentId > comment.CommentId)
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid Id Number\n\n");
                                UserAccPosts();
                            }
                        }
                        StartMenu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid choice.");
                        UserAccPosts();
                    }
                    break;
                case 2:
                    StartMenu();
                    break;
            }
        }
    }
}
