using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaSimulator
{
    internal class Simulator
    {
        public Simulator() 
        {
            SysAdmin admin1 = new SysAdmin();
            Program.users.Add(admin1);
            admin1.AddAccount("test");
        }
        public void StartMenu()
        {
            Console.WriteLine("START MENU\nWelcome to the SocialMediaSimulator! \nWhich user do you want to use?\t If you want to exit press ESC");
            foreach (IUser user in Program.users)
            {
                Console.WriteLine(user);
            }
            // if esc is pressed then close program
            int chosenUserNr = int.Parse(Console.ReadLine());
            foreach (var user in Program.users)
            {
                if (user.accountId == chosenUserNr)
                {
                    IUser currentUser = user;
                    // if User == admin {MainMenuAdmin();} else if (User == useraccount){MainMenuUser}
                }
            }
            Console.Clear();
            MainMenuUser(chosenUserNr);
        }

        private void MainMenuAdmin()
        {

        }

        private void ActivityMenuAdmin()
        {

        }

        public void MainMenuUser(int UserNr)
        {
            // Main Menu of the chosen User (if UserAccount)
            Console.WriteLine($"MAIN MENU\n\nYou are now active as ... !\nWhat do you want to do?\n1 Add new Post.\t2 Look at Posts.\t3 Go to start menu.");
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
                    string PostContent = Console.ReadLine();
                    // create new Post object here and add to Post List
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

        private void UserAccPosts() // Display the Contens of Post List with PostID, comments(+commentId) and answers if available
        {
            Console.WriteLine("What do you want to do?\n1 Delete Post.\t2 Delete Comment.\t3 Add comment\t4 Return to main menu");
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
                case 3:
                    Console.WriteLine("1 Add comment to post.\t2 Add Answer to comment");
                    int commentTypeChoice = int.Parse(Console.ReadLine());
                    if (commentTypeChoice == 1)
                    {
                        Console.WriteLine("Type the Id of the Post where you want to add your comment.");
                        int commentPostId = int.Parse(Console.ReadLine());
                        // if (commentPostId <= PostList.Count)
                    }
                    else if (commentTypeChoice == 2)
                    {

                    }
                    break;
                case 4:
                    StartMenu();
                    break;
            }
        }
    }
}
