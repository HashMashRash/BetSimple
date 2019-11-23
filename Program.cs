using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBet
{
    class Program
    {
        static void Main(string[] args)
        {
            BetRun();
        }

        static void BetRun()
        {
            int bank = 100;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random random = new Random();
            Console.WriteLine($"У Вас в банке {bank}  рублей! Нажмите любую клавишу, чтобы начать игру");
            Console.ReadKey();
            Console.WriteLine("Правила игры: Вам нужно сделать ставку и угадать число от 1 до 5.");
            Console.WriteLine("Если угадаете Ваш банк увеличится на эту ставку.");
            Console.WriteLine("В случае неверного ответа, ставка вычтется из банка.\n");
            Console.ReadKey();

            while (bank > 0 || bank < 1000)
            {
                Console.WriteLine("Ваша ставка:  ");
                int sum = Convert.ToInt32(Console.ReadLine());

                if (sum < 0 || sum > bank)
                {
                    Console.WriteLine("Ваша ставка не доложна превышать сумму банка (и не должна быть отрицательной)");
                    continue;
                }

                Console.WriteLine("Ваше число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 1 || number > 5)
                {
                    Console.WriteLine("Ваше число должно быть в интервале: [1; 5]");
                    continue;
                }

                int numberRandom = random.Next(1, 5);

                if (number == numberRandom)
                {
                    bank += sum;
                    Console.WriteLine($"Поздравляем, Вы угадали! Ваш банк {bank} рублей!");
                }
                else
                {
                    bank -= sum;
                    Console.WriteLine($"Вы были близко! Правильный ответ {numberRandom}. Ваш банк {bank} рублей");
                }

                Console.WriteLine($"Нажмите любую кнопку для продолжения");
                Console.ReadKey();
            }

            if (bank > 1000)
            {
                Console.WriteLine($"Вы выйграли! Попробуйте еще раз!\n");
            }
            else
            {
                Console.WriteLine($"Вы проиграли! Попробуйте еще раз!\n");
            }
        }
    }
}
