namespace SecretApp_login
{
    internal class Program
    {
        static string[] userNames = { "Pelle", "Stina", "Ali" };
        static string[] userPasswords = { "1234", "12345", "123456" };
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
            Console.WriteLine("Hello from AddUser()");
        }

        static void ShowUsers()
        {
            int i = 0;
            while (i < userNames.Length)
            {
                Console.WriteLine(userNames[i].ToUpper());
                i++;
            }
        }

        static void LoggIn()
        {
            Console.WriteLine("Inloggning");
            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Lösenord: ");
            string password = Console.ReadLine();

            int i = 0;
            while (i < userNames.Length)
            {
                if (userNames[i] == name)
                {
                    if (userPasswords[i] == password)
                    {
                        Console.WriteLine("Välkommen " + name);
                        //Thread.Sleep(3000);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Felaktigt lösenord");
                    }
                }
                i++;
            }

            if (Array.IndexOf(userNames, name) == -1)
            {
                Console.WriteLine("Inget sådant namn finns i listan. För att lägga till en avändare, välj i menyn.");
            }

            Menu();
        }

        static void ChangePassword()
        {
            Console.WriteLine("Hello från Change Password");
        }
        static void Menu()
        {
            Console.WriteLine(
                "\n\n***********************\n" +
                "1. logga in\n" +
                "2. lägg till användare\n" + 
                "3. ändra lösenord\n" +
                "4. visa användar lista\n" +
                "9. visa menyn\n" +
                "0. avsluta\n"
                );

        }
    }
}
