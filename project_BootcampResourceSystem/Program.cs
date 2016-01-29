using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_BootcampResourceSystem
{
    [System.Runtime.InteropServices.Guid("4E578171-0B00-4972-8A87-6BFD531587A1")]
    class Program
    {

        static void Main(string[] args)
        {
            

            string[] studentNames = new string[5];
            string[] studentNamesLower = new string[5];
            string[] students1stBook = new string[5];
            string[] students2ndBook = new string[5];
            string[] students3rdBook = new string[5];


            studentNames[0] = "Bennett, Quinn";
            studentNamesLower[0] = "bennett, quinn";
            students1stBook[0] = null;
            students2ndBook[0] = null;
            students3rdBook[0] = null;

            studentNames[1] = "Butler, Sirahn";
            studentNamesLower[1] = "butler, sirahn";
            students1stBook[1] = null;
            students2ndBook[1] = null;
            students3rdBook[1] = null;

            studentNames[2] = "Childress, Imari";
            studentNamesLower[2] = "childress, imari";
            students1stBook[2] = null;
            students2ndBook[2] = null;
            students3rdBook[2] = null;

            studentNames[3] = "Evans, Jennifer";
            studentNamesLower[3] = "evans, jennifer";
            students1stBook[3] = null;
            students2ndBook[3] = null;
            students3rdBook[3] = null;

            studentNames[4] = "Winkelman, Mary";
            studentNamesLower[4] = "winkelman, mary";
            students1stBook[4] = null;
            students2ndBook[4] = null;
            students3rdBook[4] = null;


            string[] bookTitles = new string[10];
            string[] bookTitlesLower = new string[10];
            bool[] bookAvailable = new bool[10];


            bookTitles[0] = "ASP.NET MVC 5";
            bookTitlesLower[0] = "asp.net mvc 5";
            bookAvailable[0] = true;
            bookTitles[1] = "Assembly Language Tutor";
            bookTitlesLower[1] = "assembly language tutor";
            bookAvailable[1] = true;
            bookTitles[2] = "A Smarter Way to Learn JavaScript";
            bookTitlesLower[2] = "a smarter way to learn javascript";
            bookAvailable[2] = true;
            bookTitles[3] = "C# 5.0 All-In-One For Dummies";
            bookTitlesLower[3] = "c# 5.0 all-in-one for dummies";
            bookAvailable[3] = true;
            bookTitles[4] = "Eloquent JavaScript";
            bookTitlesLower[4] = "eloquent javascript";
            bookAvailable[4] = true;
            bookTitles[5] = "Essential C# 6.0";
            bookTitlesLower[5] = "essential c# 6.0";
            bookAvailable[5] = true;
            bookTitles[6] = "Implementing Responsive Design";
            bookTitlesLower[6] = "implementing responsive design";
            bookAvailable[6] = true;
            bookTitles[7] = "JavaScript for Kids";
            bookTitlesLower[7] = "javascript for kids";
            bookAvailable[7] = true;
            bookTitles[8] = "Killer Game Programming in Java";
            bookTitlesLower[8] = "killer game programming in java";
            bookAvailable[8] = true;
            bookTitles[9] = "Programming Interviews Exposed";
            bookTitlesLower[9] = "programming interviews exposed";
            bookAvailable[9] = true;
            
            do
            {
                ReprintMenu();

                int menuChoice;
                int.TryParse(Console.ReadLine(), out menuChoice);
                if (menuChoice == 0 || menuChoice < 0 || menuChoice > 6)
                {
                    Console.WriteLine("\nPlease enter the number of an item on the menu.\n");
                    Console.WriteLine("\nPress any key to go back to the Main Menu.");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
                else if(menuChoice==6)
                {
                    Console.WriteLine("\nGoodbye.");
                    return;
                }
                else if (menuChoice > 0 && menuChoice < 6)
                {
                    switch (menuChoice)
                    {
///////VIEW STUDENTS////////////////////////////////////////////////////////////////////////////////////////////////////
                        case 1: //user chooses: 1. View Students, Display "ViewStudents" Screen
                            Console.WriteLine("\nSTUDENTS\n");
                            foreach (string student in studentNames)
                            {
                                Console.WriteLine(student);
                            }
                            Console.WriteLine("\nPress any key to go back to the Main Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
///////VIEW AVAILABLE RESOURCES//////////////////////////////////////////////////////////////////////////////////////////////
                        case 2: //user chooses: 2. View Available Resources, Display "ViewAvailableResources" Screen
                            Console.WriteLine("\nAVAILABLE RESOURCES:\n");
                            int atLeastOneLeft=Array.IndexOf(bookAvailable, true);
                            if(atLeastOneLeft==-1)
                            {
                                Console.WriteLine("All resources are checked out.");
                            }
                            else
                            {
                                for (int i = 0; i < bookTitles.Length; i++)
                                {
                                    if (bookAvailable[i] == false)
                                    {
                                        continue;
                                    }
                                    Console.WriteLine(bookTitles[i]);
                                }   
                            }
                            Console.WriteLine("\nPress any key to go back to the Main Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
///////VIEW STUDENT ACCOUNTS//////////////////////////////////////////////////////////////////////////////////////////////////
                        case 3: //user chooses: 3. View Student Accounts, Display "ViewStudentAccounts" Screen
                            string studentNameAnswer;
                            string studentAccount = null;
                            int validStudentName;
                            Console.WriteLine("Enter a Student Name from the list below: ");
                            Console.WriteLine("\nSTUDENTS\n");
                            foreach (string student in studentNames)
                            {
                                Console.WriteLine(student);
                            }
                            do
                            {
                                Console.WriteLine("\nEnter student name (Last name, First name):");
                                studentNameAnswer = Console.ReadLine();
                                studentNameAnswer = studentNameAnswer.ToLower();

                                validStudentName = Array.IndexOf(studentNamesLower, studentNameAnswer);
                                
                                if (validStudentName==-1)
                                {                                       
                                     Console.WriteLine("\nError1: Request Unavailable \n(Student name not recognized)");                                        
                                }
                                else
                                {                                 
                                     studentAccount = studentNames[validStudentName];
                                     Console.WriteLine("\nDisplaying account for student {0}:\n", studentAccount);
                                     if (students1stBook[validStudentName] == null && students2ndBook[validStudentName] == null && students3rdBook[validStudentName] == null)
                                     {
                                         Console.WriteLine("Nothing is checked out...");
                                     }
                                     else
                                     {
                                         Console.WriteLine($"\n\t{students1stBook[validStudentName]}\n\t{students2ndBook[validStudentName]}\n\t{students3rdBook[validStudentName]}");
                                     }
                                }
                            }
                            while (studentAccount == null);
                            Console.WriteLine("\nPress any key to go back to the Main Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
//////////CHECKOUT ITEM//////////////////////////////////////////////////////////////////////////////////////////////////////
                        case 4: //user chooses: 4. Checkout Item, Display "CheckoutItem" Screen
 
                            string checkoutNameInput;
                            string checkoutName = null;
                            string checkoutTitleInput;
                            string checkoutTitle = null;
                            int validBookTitle;
                            atLeastOneLeft = Array.IndexOf(bookAvailable, true);

                            if (atLeastOneLeft == -1)
                            {
                                Console.WriteLine("\nAll resources are checked out.");
                            }
                            else
                            {
                                do //ask for name:
                                {

                                    Console.WriteLine("Enter your name (Last name, First name): ");
                                    checkoutNameInput = Console.ReadLine();
                                    checkoutNameInput = checkoutNameInput.ToLower();

                                    validStudentName = Array.IndexOf(studentNamesLower, checkoutNameInput);

                                    if (validStudentName == -1)
                                    {
                                        Console.WriteLine("\nError: Request Unavailable \n(Unknown Student)");
                                    }
                                    else
                                    {
                                        checkoutName = studentNames[validStudentName];
                                        if (students1stBook[validStudentName] != null && students2ndBook[validStudentName] != null && students3rdBook[validStudentName] != null)
                                        {
                                            //if student has three books checked out already
                                            Console.WriteLine("\nYou have checked out the maximum number of books allowed. \nPlease return one or more and try again.");
                                        }
                                        else
                                        {
                                            do //ask for title:
                                            {
                                                Console.WriteLine("\nEnter the title of the item you would like to check out \nfrom the list of available resources: ");

                                                Console.WriteLine("\nAVAILABLE RESOURCES:\n");
                                                for (int a = 0; a < bookTitles.Length; a++)
                                                {
                                                    if (bookAvailable[a] == false)
                                                    {
                                                        continue;
                                                    }
                                                    Console.WriteLine(bookTitles[a]);
                                                }
                                                Console.WriteLine("\nEnter a title:");
                                                checkoutTitleInput = Console.ReadLine();
                                                checkoutTitleInput = checkoutTitleInput.ToLower();

                                                validBookTitle = Array.IndexOf(bookTitlesLower, checkoutTitleInput);
                                                if (validBookTitle == -1)
                                                {
                                                    Console.WriteLine("\nError: Request Unavailable \n(unknown title)");
                                                }
                                                else
                                                {
                                                    checkoutTitle = bookTitles[validBookTitle];

                                                    bookAvailable[validBookTitle] = false;
                                                    if (students1stBook[validStudentName] == null)
                                                    {
                                                        students1stBook[validStudentName] = bookTitles[validBookTitle];
                                                        Console.WriteLine($"\n{studentNames[validStudentName]} has checked out \"{bookTitles[validBookTitle]}\"");
                                                        break;
                                                    }
                                                    else if (students2ndBook[validStudentName] == null)
                                                    {
                                                        students2ndBook[validStudentName] = bookTitles[validBookTitle];
                                                        Console.WriteLine(($"\n{studentNames[validStudentName]} has checked out \"{bookTitles[validBookTitle]}\""));
                                                        break;
                                                    }
                                                    else if (students3rdBook[validStudentName] == null)
                                                    {
                                                        students3rdBook[validStudentName] = bookTitles[validBookTitle];
                                                        Console.WriteLine(($"\n{studentNames[validStudentName]} has checked out \"{bookTitles[validBookTitle]}\""));
                                                        break;
                                                    }
                                                }
                                            }
                                            while (checkoutTitle == null); // do(ask for title) while(title is null)                        
                                        }
                                    }
                                }
                                while (checkoutName == null);
                            }
                            Console.WriteLine("\nPress any key to go back to the Main Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
   ////////RETURN ITEM/////////////////////////////////////////////////////////////////////////////////////////////////////////////                         
                        case 5: //user chooses: 5. Return Item, Display "ReturnItem" Screen

                            string returnNameInput;
                            string returnName = null;
                            string returnTitleInput;
                            string returnTitle = null;

                            do
                            {
                                Console.WriteLine("Enter your name (Last name, First name)");
                                returnNameInput = Console.ReadLine();
                                returnNameInput = returnNameInput.ToLower();

                                validStudentName = Array.IndexOf(studentNamesLower, returnNameInput);

                                if (validStudentName == -1)
                                {
                                    Console.WriteLine("\nError: Request Unavailable \n(no student by that name)");
                                }
                                else
                                {
                                    returnName = studentNames[validStudentName];
                                    if (students1stBook[validStudentName] == null && students2ndBook[validStudentName] == null && students3rdBook[validStudentName] == null)
                                    {
                                        Console.WriteLine("\nYou have nothing checked out at this time.");
                                    }
                                    else
                                    {
                                        do
                                        {
                                            Console.WriteLine("\nEnter the title of the book you are returning:");
                                            returnTitleInput = Console.ReadLine();
                                            returnTitleInput = returnTitleInput.ToLower();

                                            validBookTitle = Array.IndexOf(bookTitlesLower, returnTitleInput);

                                            if (validBookTitle>-1)
                                                {
                                                    returnTitle = bookTitles[validBookTitle];
                                                    if (students1stBook[validStudentName] == bookTitles[validBookTitle])
                                                    {
                                                        bookAvailable[validBookTitle] = true;
                                                        students1stBook[validStudentName] = null;
                                                        Console.WriteLine($"\n{studentNames[validStudentName]} successfully returned \"{bookTitles[validBookTitle]}\"");
                                                        break;
                                                    }
                                                    else if (students2ndBook[validStudentName] == bookTitles[validBookTitle])
                                                    {
                                                        bookAvailable[validBookTitle] = true;
                                                        students2ndBook[validStudentName] = null;
                                                        Console.WriteLine($"\n{studentNames[validStudentName]} successfully returned \"{bookTitles[validBookTitle]}\"");
                                                        break;
                                                    }
                                                    else if (students3rdBook[validStudentName] == bookTitles[validBookTitle])
                                                    {
                                                        bookAvailable[validBookTitle] = true;
                                                        students3rdBook[validStudentName] = null;
                                                        Console.WriteLine($"\n{studentNames[validStudentName]} successfully returned \"{bookTitles[validBookTitle]}\"");
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nError: Request unavailable\n(Our records show that you do not currently have that title checked out.)");
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                 Console.WriteLine("Error: Request Unavailable \n(unknown title)");
                                                }                                            
                                        }
                                        while (returnTitle == null);
                                    }
                                }                                                               
                            }
                            while (returnName == null);
                            Console.WriteLine("\nPress any key to go back to the Main Menu.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
            }
            while (true);
        }
        
        static void ReprintMenu()
        {
            Console.WriteLine("BOOTCAMP RESOURCES CHECKOUT SYSTEM");
            Console.WriteLine("__________________________________\n");
            string[] menuItems = new string[6];
            menuItems[0] = "1. View Students";
            menuItems[1] = "2. View Available Resources";
            menuItems[2] = "3. View Student Accounts";
            menuItems[3] = "4. Checkout Item";
            menuItems[4] = "5. Return Item";
            menuItems[5] = "6. Exit";

            Console.WriteLine("Choose a menu option from the list below:\n");
            Console.WriteLine(">-----------MENU-----------<");
            foreach (string action in menuItems)
                Console.WriteLine(action);
        }
    }
}
