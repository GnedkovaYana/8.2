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
            display.BeginWork(account);

            Console.ReadKey();
        }
    }
}
