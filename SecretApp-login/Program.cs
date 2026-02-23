using System.Diagnostics;

namespace SecretApp_login
{
    internal class Program
    {
        static string[] userNamesList = { "pelle", "stina", "ali" };
        static string[] userPasswordsList = { "1234", "12345", "123456" };
        static bool loggedIn = false;
        static void Main(string[] args)
        {
            Console.WriteLine("välkommen");
            Menu();
            bool runProgram = true;
            while (runProgram)
            {
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 1)
                    {
                        LoggIn();
                    } //loggin

                    else if (choice == 2) 
                    {
                        AddUser();
                    }//add user

                    else if (choice == 3)
                    {
                        ChangePassword();
                    }

                    else if (choice == 4)
                    {
                        ShowUsers();
                    }

                    else if (choice == 5)
                    {
                        deleteUser();

                    }

                    else if (choice == 6) 
                    {
                        LoggOut();
                    }

                    else if (choice == 9)
                    {
                        Menu();
                    }

                    else if (choice == 0)
                    {
                        runProgram = false;
                    }
                }
                else
                {
                    Console.WriteLine("Något blev fel. Välj i menyn (Skriv 9 för att visa menyn).");
                }
            }
            Console.WriteLine("Hej då");
            Thread.Sleep(3000);
        }
        static void AddUser()
        {
            if (loggedIn)
            {
                Console.WriteLine("Hello you can add users hear");

                string[] tempNameList = new string[userNamesList.Length + 1];
                string[] tempPasswordList = new string[userPasswordsList.Length + 1];

                Console.WriteLine("Skriv namnet på den du vill lägga till");
                string name = Console.ReadLine();
                Console.WriteLine("välj ett lösenord");
                string password = Console.ReadLine();

                int i = 0;
                while (i < tempNameList.Length - 1)
                {
                    tempNameList[i] = userNamesList[i];
                    i++;
                }
                tempNameList[tempNameList.Length - 1] = name;

                userNamesList = tempNameList;
                int j = 0;
                while (j < userPasswordsList.Length - 1)
                {
                    tempPasswordList[j] = userPasswordsList[j];
                    j++;
                }
                tempPasswordList[tempPasswordList.Length - 1] = password;

                userPasswordsList = tempPasswordList;

                foreach (var post in userNamesList)
                {
                    Console.WriteLine(post);
                }
                foreach (var post in userPasswordsList)
                {
                    Console.WriteLine(post);
                }
            }
            else 
            {
                Console.WriteLine("you are not a user that");

            }
            Console.Clear();
            Menu();
        }  //funkar
        static void ShowUsers()
        {
            Console.WriteLine("Status: " + loggedIn);
            int i = 0;
            if (loggedIn)
            {
                while (i < userNamesList.Length)
                {
                    Console.WriteLine(userNamesList[i].ToUpper() + " " + userPasswordsList[i]);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("du får inte se deta");
            }
            Menu();
        } //funkar
        static void deleteUser()
        {
            string[] tempNamelist = new string[userNamesList.Length - 1];
            string[] tempPasswordList = new string[userPasswordsList.Length - 1];

            Console.WriteLine("Skriv namnet på den du vill ta bort");
            string name = Console.ReadLine();

            int hit = Array.IndexOf(userNamesList, name);
            if (hit == 0)
            {
                Console.WriteLine("Namnet finns inte i listan");
                return;
            }
            int i = 0;
            int j = 0;

            while (i < userNamesList.Length)
            {
                if (hit == i)
                {
                    i++;
                    continue;
                }
                tempNamelist[j] = userNamesList[i];
                i++;
                j++;

            }
            i = 0;
            j = 0;

            while (i < userPasswordsList.Length)
            {
                Console.WriteLine(userPasswordsList);
            }
        } // funkar inte
        static void LoggIn()
        {
            Console.WriteLine("Inloggning");
            Console.Write("Namn: ");
            string name = Console.ReadLine().ToLower();
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            int i = 0;
            while (i < userNamesList.Length)
            {
                if (userNamesList[i] == name)
                {
                    if (userPasswordsList[i] == password)
                    {
                        Console.WriteLine("Välkommen " + name);
                        loggedIn = true;
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Felaktigt lösenord");
                    }
            
                }  
             i++;  
            }
            if (Array.IndexOf(userNamesList, name) == -1)
            {
                Console.WriteLine("Inget sådant namn finns i listan. För att lägga till en avändare, välj i menyn.");
            }
            Menu();
        } // funkar
        static void ChangePassword()
        {
            string[] tempNames = new string[userNamesList.Length - 1];
            string[] tempPassword = new string[userPasswordsList.Length - 1];
            Console.WriteLine("Skriv namnet vars lösenord du vill ändra: ");
            string password = Console.ReadLine();
            int changePassword = Array.IndexOf(userNamesList, password);

            Console.WriteLine("Skriv det nuvarande lösenordet");
            string oldPassword = Console.ReadLine();

            int oldPasswordIndex = Array.IndexOf(userPasswordsList, oldPassword);

            if (!loggedIn)
            {
                Console.WriteLine("Du måste logga in för att ändra lösenordet");
                return;
            }
            else if (changePassword == -1)
            {
                Console.WriteLine("lösenordet finns inte.");
                return;
            }
            else if (oldPasswordIndex == -1)
            {
                Console.WriteLine("lösenordet finns inte.");
                return;
            }

            if (oldPasswordIndex == changePassword)
            {
                Console.WriteLine("skriv det nya lösenordet");
                string newPassword = Console.ReadLine();
                userPasswordsList[changePassword] = newPassword;
            }
            Console.Clear();
            Menu();

        }// funkar
        static void LoggOut() 
        {
            Console.WriteLine("you ar now loggd out");
            loggedIn=false;
            Menu();
        } // funkar
        static void Menu()
        {
            Console.WriteLine(
            "\n\n***********************\n" +
            "1. logga in\n" +
            "2. lägg till användare\n" +
            "3. ändra lösenord\n" +
            "4. visa användar lista\n" +
            "5. visa deletUser\n" +
            "6. visa Logg a Out\n "+
            "9. visa menyn\n" +
            "0. avsluta\n"
            );

        }
    }
}
