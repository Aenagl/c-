//2.1 Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени.

using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте,{name}!");
        }
    }
}
//2.2 Написать программу, которой на вход подается два
//целых числа, на выходе – результат деления одного числа на другое.
//Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль.

using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Нельзя делить на ноль.");
            }
        }
    }
}

//Домашнее задание 2.1 Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите букву: ");
            char letter = Console.ReadKey().KeyChar; //KeyChar - свойство,которое хранит один символ,нажатый с клавиатуры. Char  исп для хранения одного символа юникода.
            char next_letter = (char)(letter + 1);
            Console.WriteLine();
            if (letter == 'z')
                Console.WriteLine('a');
            else if (letter == 'Z')
                Console.WriteLine("A");
            else
                Console.WriteLine($"Следующая буква после {letter}: {next_letter}");
        }
    }
}

//Домашнее задание 2.2 Написать программу, которая решает квадратноеуравнение.Входные данные – коэффициенты уравнения, выходные – найденные корни.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Корень уравнения x={root}");
            }
            else if (D > 0)
            {
                double root1 = (-b + Math.Sqrt(D)) / (2 * a);
                double root2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Корень уравнения x1={root1}");
                Console.WriteLine($"Корень уравнения x2={root2}");
            }
            else
                Console.WriteLine("Вещественных корней нет");
        }
    }
}