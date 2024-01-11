using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            admin1.AddAccount("test");
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
                        MainMenuUser(accUser);
                    } 
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Id Number\n\n");
                    StartMenu();
                }
            }
        }

        private void MainMenuAdmin()
        {
            Console.WriteLine("MAIN MENU\n\nYou are now active as the admin !\nWhat do you want to do?\n1 Add new account.\t2 Delete account.\t3 Delete Post.\t4 Delete Comment.\t5 Go back to Start Menu.");
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
                    UserAccount newUser = new UserAccount(accName);
                    IUser.users.Add(newUser);
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
                    foreach (Post post in Post.posts)
                    {
                        Console.WriteLine(post);
                    }
                    int postId = int.Parse(Console.ReadLine());
                    foreach (Post post in Post.posts)
                    {
                        if (post.PostId == postId)
                        {
                            deletePost = post;
                            adminUser.DeletePost(deletePost);
                            StartMenu();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Id Number\n\n");
                            ActivityMenuAdmin(3);
                        }
                    }
                    break;
                case 4:
                    foreach (Comment comment in Comment.comments)
                    {
                        Console.WriteLine(comment);
                    }
                    int commentId = int.Parse(Console.ReadLine());
                    foreach (Comment comment in Comment.comments)
                    {
                        if (comment.CommentId == commentId)
                        {
                            deleteComment = comment;
                            adminUser.DeleteComment(deleteComment);
                            StartMenu();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Id Number\n\n");
                            ActivityMenuAdmin(3);
                        }
                    }
                    StartMenu();
                    break;
                case 5:
                    StartMenu();
                    break;
            }
        }

        public void MainMenuUser(UserAccount user)
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
            // TODO Display the Contens of Post List with PostID, comments(+commentId) and answers if available
            Console.WriteLine("What do you want to do?\n1 Delete Post.\t2 Delete Comment.\t3 Add comment\t4 Return to start menu");
            int chosenSubActivity = int.Parse(Console.ReadLine());
            switch (chosenSubActivity)
            {
                case 1:
                    Console.WriteLine("Type the Id of the Post you want to delete: ");
                    int deletePostId = int.Parse(Console.ReadLine());
                    // TODO delete post
                    // foreach (post in PostList) { if (deletePostId == post.PostId) { Remove Item from list}} if (deletePostId > PostList.Count) { ConsoleWriteLine("no Post has this Id.") Console.Clear(); return to main menu}
                    StartMenu();
                    break;
                case 2:
                    Console.WriteLine("Type the Id of the Comment you want to delete: ");
                    int deleteCommentId = int.Parse(Console.ReadLine());
                    // TODO delete comment
                    StartMenu();
                    break;
                case 3:
                    Console.WriteLine("1 Add comment to post.\t2 Add Answer to comment");
                    int commentTypeChoice = int.Parse(Console.ReadLine());
                    if (commentTypeChoice == 1)
                    {
                        Console.WriteLine("Type the Id of the Post where you want to add your comment.");
                        int commentPostId = int.Parse(Console.ReadLine());
                        // TODO add comment to post
                        // if (commentPostId <= PostList.Count)
                        StartMenu();
                    }
                    else if (commentTypeChoice == 2)
                    {
                        // TODO add answer
                        StartMenu();
                    }
                    break;
                case 4:
                    StartMenu();
                    break;
            }
        }
    }
}
