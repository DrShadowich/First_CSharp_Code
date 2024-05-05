using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BigC_HW
{

    public class FirstTask
    {
        protected int personalNumber;

        public void Compare()
        {
            if (personalNumber % 3 == 0 && personalNumber % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (personalNumber % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (personalNumber % 3 != 0 && personalNumber % 5 != 0)
            {
                Console.WriteLine(personalNumber);
            }
            else
            {
                Console.WriteLine("Число кратно пяти, но не тройке");
            }
        }
        public FirstTask()
        {
            do
            {
                Console.WriteLine("Введите число от 1 до 100");
                personalNumber = int.Parse(Console.ReadLine());
            } while (personalNumber > 100 || personalNumber < 1);

        }
    }

    public class SecondTask
    {
        protected int number;
        protected int percent;

        public decimal PercentOfNumber()
        {
            return (decimal)number / percent;
        }

        public SecondTask()
        {
            Console.WriteLine("Введите число");
            number = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Введите процент");
                percent = int.Parse(Console.ReadLine());
            } while (percent > 100 || percent < 1);
        }
    }

    public class ThirdTask
    {
        protected int quanity;
        protected int[] numbers;
        private Int64 makedNumber;

        public Int64 ConvertNumbersToMakedNumber()
        {

            string tempMakedNumber = numbers[0].ToString();

            for (int i = 1; i < numbers.Length; i++)
            {
                tempMakedNumber += numbers[i].ToString();
            }

            makedNumber = Convert.ToInt64(tempMakedNumber);

            return makedNumber;

        }

        public ThirdTask()
        {

            Console.WriteLine("Введите, какое должно быть количество символов");
            quanity = int.Parse(Console.ReadLine());

            numbers = new int[quanity];

            for (int i = 0; i < quanity; i++) {

                do
                {
                    Console.WriteLine($"Введите цифру номер {i + 1}");
                    numbers[i] = int.Parse(Console.ReadLine());
                } while (numbers[i] > 9);

            }
        }
    }


    public class FourthTask
    {
        protected char[] sectionNumbers = new char[6];
        protected int number;
        protected int firstPos;
        protected int secondPos;
        protected int swappedNumber;

        private void SetIndexes()
        {
            Console.Write($"Число: {number}");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Введите первый индекс от 1");
                firstPos = int.Parse(Console.ReadLine());
            } while (firstPos > 7 && firstPos != 0);
            firstPos--;
            do
            {
                Console.WriteLine("Введите второй индекс");
                secondPos = int.Parse(Console.ReadLine());
            } while (secondPos > 7 && secondPos != 0);
            secondPos--;

            if(firstPos > secondPos)
            {
                (firstPos, secondPos) = (secondPos, firstPos);
            }

        }
        private void SwapNumber()
        {
            string tempNumber = number.ToString();
            sectionNumbers = tempNumber.ToCharArray();
            // Удобная реализация, предложенная компилятором.
            (sectionNumbers[secondPos], sectionNumbers[firstPos]) = (sectionNumbers[firstPos], sectionNumbers[secondPos]);
            tempNumber = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                tempNumber += sectionNumbers[i];
            }
            swappedNumber = int.Parse(tempNumber);

        }

        public int ConvertToSwappedNumber()
        {
            return swappedNumber;
        }

        public FourthTask()
        {
            Console.WriteLine("Введите шестизначное число");
            number = int.Parse(Console.ReadLine());
            SetIndexes();
            SwapNumber();
        }
    }


    public class FifthTask
    {
        string date;

        public string GetDay()
        {
            return "Day";
        }

        public string GetSeason()
        {
            return "Season";
        }

        public FifthTask()
        {
            Console.Write("Впышите дату (например 30.04.2009): ");
            date = Console.ReadLine();
        }
    }


    public class SixthTask
    {
        protected decimal temperatureF;
        protected decimal temperatureC;
        protected int choise;

        public decimal ConvertToC()
        {

            if (choise == 1)
            {
                return temperatureC;
            }

            else if (choise == 2)
            {
                temperatureC = temperatureF - 32 * 5 / 9;
            }

            else
            {
                return 1;
            }

            return temperatureC;
        }

        public decimal ConvertToF()
        {
            if (choise == 2)
            {
                return temperatureF;
            }

            else if (choise == 1)
            {
                temperatureF = temperatureC * 9 / 5 + 32;
            }
            else
            {
                return 1;
            }
            return temperatureF;
        }

        public SixthTask()
        {
            Console.WriteLine("\nЧто вы хотите ввести?\n\n1 - Цельсий.\n2 - Фаренгейт");
            choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                Console.WriteLine("Введите температуру по цельсию");
                temperatureC = int.Parse(Console.ReadLine());
            }
            else if (choise == 2)
            {
                Console.WriteLine("Введите температуру по фаренгейту");
                temperatureF = int.Parse(Console.ReadLine());
            }
        }
    }

    public class SeventhTask
    {
        int firstPos;
        int secondPos;

        public void ShowNumbers()
        {
            Console.WriteLine("Все четные числа: ");
            for(int i = firstPos; i < secondPos; i++)
            {
                if(i == 0)
                {
                    continue;
                }
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public SeventhTask()
        {
            Console.WriteLine("Начнём с диапозона.");
            
            Console.WriteLine("Введите начало диапазона.");
            firstPos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите конец диапазона.");
            secondPos = int.Parse(Console.ReadLine());

            if(firstPos > secondPos)
            {
                (firstPos, secondPos) = (secondPos, firstPos);
            }
        }
            
    }
    
    internal class App
    {
        static void Main()
        {
            int choise;
            do
            {
                Console.WriteLine("Выберите задание.\n\n1 - FirstTask.\n2 - SecondTask." +
                    "\n3 - ThirdTask.\n4 - FourthTask.\n5 - FifthTask (не справился).\n6 - SixthTask" +
                    "\n7 - SeventhTask.\n8 - Exit.");
                choise = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choise)
                {

                    case 1:
                        FirstTask firstTask = new FirstTask();
                        firstTask.Compare();
                        break;

                    case 2:
                        SecondTask secondTask = new SecondTask();
                        Console.WriteLine(secondTask.PercentOfNumber());
                        break;

                    case 3:
                        ThirdTask thirdTask = new ThirdTask();
                        Console.WriteLine($"Отформатированое число: {thirdTask.ConvertNumbersToMakedNumber()}");
                        break;

                    case 4:
                        FourthTask fourthTask = new FourthTask();
                        Console.WriteLine($"Цифры были перевернуты: {fourthTask.ConvertToSwappedNumber()}");
                        break;
                    case 5:
                        FifthTask fifthTask = new FifthTask();
                        break;
                    case 6:
                        SixthTask sixthTask = new SixthTask();
                        sixthTask.ConvertToC();
                        sixthTask.ConvertToF();
                        Console.WriteLine($"Цельсий: {sixthTask.ConvertToC()}\nФаренгейт: {sixthTask.ConvertToF()}");
                        break;
                    case 7:
                        SeventhTask seventhTask = new SeventhTask();
                        seventhTask.ShowNumbers();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Вы вышли из приложения.");
                        break;
                    default:
                        Console.WriteLine("Такого пункта нету");
                        break;
                }
            } while (choise != 8);
        }
    }
}
