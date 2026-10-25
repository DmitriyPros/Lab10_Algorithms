bool playAgain = true;

while (playAgain == true)
{
    Random rnd = new Random();
    int secretNumber = rnd.Next(1, 101);

    int attempts = 0;
    bool isGuessed = false;

    Console.WriteLine("\n=== Игра 'Угадай число' ===");
    Console.WriteLine("Компьютер загадал число от 1 до 100.");

    while (isGuessed == false)
    {
        Console.Write("Введите вашу попытку: ");
        string input = Console.ReadLine();

        bool isCorrectInput = true; 
        int userNumber = 0;  

        if (input == "")
        {
            isCorrectInput = false;
        }
        else
        {

            for (int i = 0; i < input.Length; i = i + 1)
            {

                if (input[i] < '0' || input[i] > '9')
                {
                    isCorrectInput = false;
                }
            }
        }

        if (isCorrectInput == true)
        {
            for (int i = 0; i < input.Length; i = i + 1)
            {
                int digit = input[i] - '0';
                userNumber = userNumber * 10 + digit;
            }
        }

        if (isCorrectInput == false)
        {
            Console.WriteLine("Ошибка! Вы ввели не число. Попробуйте снова.");
        }
        else
        {
            attempts = attempts + 1;

            if (userNumber == secretNumber)
            {
                Console.WriteLine("\nПоздравляем! Вы угадали число!");
                Console.WriteLine("Количество попыток: " + attempts);
                isGuessed = true;
            }
            else if (userNumber > secretNumber)
            {
                Console.WriteLine("Меньше!");
            }
            else
            {
                Console.WriteLine("Больше!");
            }
        }
    }

    Console.WriteLine("\n-------------------------");
    Console.Write("Хотите сыграть еще раз? (напишите 'да'): ");
    string answer = Console.ReadLine();

    if (answer != "да")
    {
        playAgain = false;
    }
}
