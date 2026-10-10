using System;

class Program
{
    static void Main(string[] args)
    {
        // for(int i = 1; i<=5; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int n = 1;
        // while (n <= 5)
        // {
        //     Console.WriteLine(n);
        //     n++;
        // }

        // int answer;
        // do
        // {
        //     Console.WriteLine("Введите число больше 0");
        //     answer = Convert.ToInt32(Console.ReadLine());
        // }
        // while (answer <= 0);

        // for (int i = 1; i<=10; i++)
        // {
        //     if (i == 3) continue;
        //     if (i == 7) break;
        //     Console.WriteLine(i);
        // }
        // for(int i = 10; i>=1; i--)
        // {
        //     Console.WriteLine(i);
        // }

        // for (int i = 0; i <= 50; i += 2)
        // {
        //     Console.WriteLine(i);

        // }





        // int krat3 = 0;
        // int krat7 = 0;
        // for (int i = 1; i <= 100; i++)
        // {
        //     if (i % 3 == 0)
        //     {
        //         krat3 += i;
        //     }
        //     if (i % 7 == 0)
        //     {
        //         krat7++;
        //     }
        // }
        // Console.WriteLine($"Количество чисел кратных 3: {krat3}");
        // Console.WriteLine($"Количество чисел кратных 7: {krat7}");






        // Console.WriteLine("Введите числа, для выхода введите 0");
        // int num = Convert.ToInt32(Console.ReadLine());
        // int a = 0;
        // int b =0;

        // while (num != 0)
        // {
        //     if (num >0 )
        //     {
        //         a++;
        //     }
        //     else
        //     {
        //         b++;
        //     }
        //     num = Convert.ToInt32(Console.ReadLine());
        // }


        // Console.WriteLine($"Количество положительных чисел: {a}");
        // Console.WriteLine($"Количество отрицательных чисел: {b}");





        // string passwond;
        // int attempts = 0;
        // string correctPassword = "12345a";

        // do
        // {
        //     Console.WriteLine("Введите пароль");
        //     passwond = Console.ReadLine()!;
        //     if (passwond == correctPassword)
        //     {
        //         Console.WriteLine("Пароль введен верно");
        //         break;
        //     }
        //     else
        //     {
        //         attempts++;
        //         Console.WriteLine("Пароль введен неверно");
        //         Console.WriteLine($"Осталось попыток: {3 - attempts}");
        //     }
        // }
        // while (attempts < 3);





        // Console.Write("Введите число для построения таблицы умножения: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"{number} * {i} = {number * i}");
        // }


        



        // int secretCode = 1337;
        // int attempts = 0;
        // int maxAttempts = 5;

        // do
        // {
        //     Console.Write("Введите число:");
        //     int guess = Convert.ToInt32(Console.ReadLine());
        //     if (guess == secretCode)
        //     {
        //         Console.WriteLine("Поздравляем! Вы угадали число.");
        //         break;
        //     }
        //     if (guess < secretCode)
        //     {
        //         attempts++;
        //         Console.WriteLine($"Слишком маленькое число. Осталось попыток: {maxAttempts - attempts}");
        //     }
        //     else if (guess > secretCode)
        //     {
        //         attempts++;
        //         Console.WriteLine($"Слишком большое число. Осталось попыток: {maxAttempts - attempts}");
        //     }

        // }
        // while (attempts < maxAttempts);




        for (int i = 1; i <=30; i++)
        {
            if (i % 3 ==0) continue;
            if (i % 10 == 0 && i > 30) break;
            Console.WriteLine(i);
        }
    }
}