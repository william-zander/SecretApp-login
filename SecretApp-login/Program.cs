namespace SecretApp_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("välkommen");
            Menu();
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
