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
        public IUser currentUser; // User der zurzeit verwendet wird
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
            foreach(IUser user in users)
            {
                if (user.accountId == chosenUserNr)
                {
                    // currentUser = user; // Error ??!
                }
            }
            Console.Clear();
            


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