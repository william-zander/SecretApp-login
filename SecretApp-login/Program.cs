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
                    }

                    else if (choice == 2)
                    {
                        AddUser();
                    }

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
        }
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
        }
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
        }
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
        }
        static void ChangePassword()
        {
            Console.WriteLine("enter name of the acount you want to change password on");

        }
        static void Menu()
        {
            Console.WriteLine(
            "\n\n***********************\n" +
            "1. logga in\n" +
            "2. lägg till användare\n" +
            "3. ändra lösenord\n" +
            "4. visa användar lista\n" +
            "5. visa deletUser\n" +
            "9. visa menyn\n" +
            "0. avsluta\n"
            );

        }
    }
}
