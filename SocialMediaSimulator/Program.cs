using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Program
    {
        public static List<IUser> users = new List<IUser>();
        public static IUser currentUser; // User der zurzeit verwendet wird
        static void Main(string[] args)
        {

            SysAdmin admin1 = new SysAdmin();
            users.Add(admin1);
            admin1.AddAccount("test");
            Console.WriteLine("Welcome to the SocialMediaSimulator! \nWhich user do you want to use?" );
            foreach(IUser user in users)
            {
                Console.WriteLine(user);
            }
            int chosenUserNr = int.Parse(Console.ReadLine()); 
            foreach(var user in users)
            {
                if (user.accountId == chosenUserNr)
                {
                    IUser currentUser = user; 
                }
            }
            Console.Clear();
            // Main Menu of the chosen User (if UserAccount)
            Console.WriteLine($"MAIN MENU\n\nYou are now active as {currentUser}!\nWhat do you want to do?\n1 Add new Post. \t 2 Look at your Posts. \t 3 Look at other Posts."); 
            int chosenMainActivity = int.Parse(Console.ReadLine());
            Console.Clear();

            // sub menu
            switch (chosenMainActivity) 
            {
                case 1:
                    Console.WriteLine("Type the Content for your Post. Submit with ENTER");
                    string PostContent = Console.ReadLine();
                    // create new Post object here and add to Post List
                    // return to main menu (automatic)
                    break;
                case 2:
                    // Display the Contens of Post List with PostID, comments(+commentId) and answers if available
                    Console.WriteLine("What do you want to do?\n1 Delete Post.\t2 Delete Comment.\t3 Return to main menu");
                    int chosenSubActivity = int.Parse(Console.ReadLine());
                    switch (chosenSubActivity)
                    {
                        case 1:
                            Console.WriteLine("Type the Id of the Post you want to delete: ");
                            int deletePostId = int.Parse(Console.ReadLine());
                            // foreach (post in PostList) { if (deletePostId == post.PostId) { Remove Item from list}} if (deletePostId > PostList.Count) { ConsoleWriteLine("no Post has this Id.") Console.Clear(); return to main menu}
                            break;
                        case 2:
                            Console.WriteLine("Type the Id of the Comment you want to delete: ");
                            int deleteCommentId = int.Parse(Console.ReadLine());
                            break;
                    }
                    break;
                case 3:
                    //
                    break;
            }
            /*switch (input) {
                case 1: // delete Account
                    if (users is SysAdmin)
                    {
                        admin1.DeleteAccount(chosenAccountId);
                    }
                    else if (users is UserAccount)
                    {
                        this.DeleteAccount(userAccount.accountId);
                    }
                    break;
                case 2: // delete Post
                    if (users is SysAdmin)
                    {
                        admin1.DeletePost(chosenPostId);
                    }
                    else if (users is UserAccount)
                    {
                        allPosts = userAccount.getPosts(); // Liste der Posts von dem User zurückgeben
                        if (allPosts.Any(obj => obj.Id == chosenPostId)) ;
                        {
                            DeletePost(chosenPostId);
                        }
                        else
                        {
                            System.Console.WriteLine("This is not ur Post!");
                        }
                    }
                    break;
                case 3: // delete Comments(+Answers)
                    if (users is SysAdmin)
                    {
                        admin1.DeleteComment(CommentId);
                    }
                    else if (users is UserAccount)
                    {
                        allPosts = userAccount.getPosts(); // Liste der Posts von dem User zurückgeben
                        if (allPosts.Any(obj => obj.Id == chosenPostId)) ;
                        {
                            DeleteComment(chosenCommentId);
                        }
                        else
                        {
                            System.Console.WriteLine("This is not ur Post!");
                        }
                    }
                    break;
            } */
            Console.ReadKey();
        } 
    }
}