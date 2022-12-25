namespace Ex2
{
    class Program
    {
        public static void Main()
        {
            string[] userInput = File.ReadAllLines("file.txt");
            FileReader fileReader = new();
            BankAccount account = fileReader.StructureData(userInput);
            Display display = new();
            try
            {
                display.BeginWork(account);
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
