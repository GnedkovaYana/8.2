namespace Ex2
{
    class Display
    {
        public void BeginWork(BankAccount account)
        {
            int balance0 = account.Balance;
            if (!account.CheckHistory())
                Console.WriteLine("Данные некоректны");
            else
            {
                Console.Write("Введите время ");
                string time = Console.ReadLine();
                DateTime dateTime = new DateTime();
                if (time == "")
                {
                    Console.WriteLine($"Остаток:{account.Balance}");
                    return;
                }

                else
                    dateTime = ParseStringToDateTime(time);

                for (int i = 1; i < account.OperationHistory.Length; i++)
                {
                    bool flag = false;
                    if (dateTime < account.OperationHistory[0].DateTime)
                    {
                        Console.WriteLine($"Остаток:{account.OperationHistory[0].CurrentBalance - account.OperationHistory[0].MoneyAmount}");
                        flag = true;
                    }

                    else if (dateTime < account.OperationHistory[i].DateTime)
                    {
                        Console.WriteLine($"Остаток:{account.OperationHistory[i - 1].CurrentBalance}");
                        flag = true;
                    }

                    else if (dateTime > account.OperationHistory[^1].DateTime)
                    {
                        Console.WriteLine($"Остаток: {account.OperationHistory[^1].CurrentBalance}");
                        flag = true;
                    }

                    if (flag == true)
                        break;

                }
            }
        }
        private static DateTime ParseStringToDateTime(string input)
        {
            string date = input.Split(' ')[0];
            int year = int.Parse(date.Split('-')[0]);
            int month = int.Parse(date.Split('-')[1]);
            int day = int.Parse(date.Split('-')[2]);
            string time = input.Split(' ')[1];
            int hours = int.Parse(time.Split(':')[0]);
            int minutes = int.Parse(time.Split(':')[1]);
            int second = int.Parse(time.Split(':')[2]);
            DateTime dateTime = new DateTime(year, month, day, hours, minutes, second);
            return dateTime;
        }
    }
}
