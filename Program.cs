using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] wallet = new int[0];
        string userInput;
        int number;
        int sum = 0;
        Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу\nДля завершения программы введите exit");

        while (Console.ReadLine() != "exit")
        {
            Console.WriteLine("добавить числа: 1\nCложить всё что было введено - sum");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Введите число: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    int[] extensionWallet = new int[wallet.Length + 1];

                    for (int i = 0; i < wallet.Length; i++)
                    {
                        extensionWallet[i] = wallet[i];
                    }

                    extensionWallet[extensionWallet.Length - 1] = number;
                    wallet = extensionWallet;
                    Console.Clear();
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения программы введите exit");
                    break;

                case "sum":

                    for (int i = 0; i < wallet.Length; i++)
                    {
                        sum += wallet[i];
                    }

                    Console.Clear();
                    Console.WriteLine("Сумма всех чисел равна: " + sum);
                    Console.WriteLine("Для входа в меню - нажмите нажмите любую клавишу, для завершения программы введите exit");
                    break;
            }
        }
    }
}