//Задание 1.Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double e = Math.E;
            Console.WriteLine(Math.Round(e, 1));
        }
    }
}

//Задание 2.Вывести на экран числа 50 и 10 одно под другим.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(50);
            Console.WriteLine(10);
        }
    }
}

//Задание 3.Составить программу вывода на экран «столбиком» четырех любых чисел.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа:");
            double n1 = Convert.ToDouble(Console.ReadLine());  
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            double n4 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine($"\n{n1}\n{n2}\n{n3}\n{n4}");
        }
    }
}

//Задание 4.Пользователь вводит число. Выведите на экран число, которое больше введенного на 10
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = num1 + 10;
            Console.WriteLine($"Число на 10 больше введёенного = {num2}");
        }
    }
}

//Задание 5.Дана сторона квадрата. Найти его периметр.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону квадрата: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int P = 4 * a;
            Console.WriteLine($"Периметр квадрата: {P}.");
        }
    }
}

//Задание 6.Дан радиус окружности. Найти длину окружности и площадь круга.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double PI = Math.PI;
            double L = 2 * PI * r;
            double S = PI * r * r;
            Console.WriteLine($"Длина окружности: {L}.");
            Console.WriteLine($"Площадь круга: {S}.");
        }
    }
}

//Задание 7.Найти значение y=cos(x)
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите аргумент: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine($"Значение y=cos({x}) равно {y}.");
        }
    }
}

//Задание 8.Даны основания и высота равнобедренной трапеции. Найти ее периметр.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Верхнее основание: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Нижнее основание: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота трапеции: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double x = (b - a) / 2;       //маленький отрезок из нижнего основания
            double c = Math.Sqrt(x * x + h * h);  //боковая сторона
            double P = a + b + 2 * c;
            Console.WriteLine($"Периметр трапеции: {P}.");
        }
    }
}

//Задание 9.Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,если купили x кг конфет, у кг печенья и z кг яблок.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Стоимость 1 кг конфет: ");
            double a = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Стоимость 1 кг печенья: ");
            double b = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Стоимость 1 кг яблок: ");
            double c = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Вес конфет: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вес печенья: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вес яблок: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double sum = (a * x) + (b * y) + (c * z);
            Console.WriteLine($"Стоимость покупки: {sum}.");
        }
    }
}

//Задание 10.Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("   Труд");
            Console.WriteLine("        Май");
        }
    }
}

//Задание 11.Программа просит пользователя ввести 2 числовые переменные. А после она
//меняет их местами и выводит результат на экран. Но, так как пользователь может
//ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
//например, букву или строку, а так же учесть, что число может быть дробным, и для
//выделения её дробной части одни используют точку, другие – запятую.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.Write("Введите первое число: ");
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out n1)) //проверка на число
            {
                Console.Write("Введено некоректное значение. Пожалуйста, введите первое число: ");
            }

            Console.Write("Введите второе число: ");
            while (!double.TryParse(Console.ReadLine().Replace('.', ','), out n2))
            {
                Console.Write("Введено некоректное значение. Пожалуйста, введите второе число: ");
            }

            double x = n1;
            n1 = n2;
            n2 = x;

            Console.WriteLine($"После обмена: Первое число = {n1}, Второе число = {n2}");
        }
    }
}

//Задание 12.Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг).
//Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру:\n1 - Треугольник;\n2 - Прямоугольник;\n3 - Круг.");
            Console.Write("Введите номер фигуры: ");
            int f = Convert.ToInt32(Console.ReadLine());

            if (f == 1)
            {
                Console.WriteLine("Что ищем?:\n1 - Периметр;\n2 - Площадь.");
                Console.Write("Введите номер искомой величины: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Основание треугольника = ");
                double a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Первая сторона треугольника = ");
                double b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Вторая сторона треугольника = ");
                double c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Высота треугольника = ");
                double h = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    double P = a + b + c;
                    Console.WriteLine($"Периметр треугольника = {P}.");
                }
                else if (s == 2)
                {
                    double S = (a * h) / 2;
                    Console.WriteLine($"Площадь треугольника = {S}.");
                }
            }
            else if (f == 2)
            {
                Console.WriteLine("Что ищем?:\n1 - Периметр;\n2 - Площадь.");
                Console.Write("Введите номер искомой величины: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Длина прямоугольника = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ширина прямоугольника = ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    double P = (a + b) * 2;
                    Console.WriteLine($"Периметр треугольника = {P}.");
                }
                else if (s == 2)
                {
                    double S = a * b;
                    Console.WriteLine($"Площадь треугольника = {S}.");
                }
            }
            else if (f == 3)
            {
                Console.WriteLine("Что ищем?:\n1 - Длина окружности;\n2 - Площадь.");
                Console.Write("Введите номер искомой величины: ");
                int s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Радиус окружности = ");
                int r = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    double С = 2 * Math.PI * r;
                    Console.WriteLine($"Длина окружности = {С}.");
                }
                else if (s == 2)
                {
                    double S = Math.PI * r * r;
                    Console.WriteLine($"Площадь треугольника = {S}.");
                }
            }
        }
    }
}

//Задание 13.Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
//числу должно предшествовать сообщение «Вы ввели число».
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Вы ввели число {num}");
        }
    }
}

//Задание 14.Составить программу вывода на экран следующей информации:
//2 кг
//13 17
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "2 кг";
            int num2 = 13;
            int num3 = 17;
            Console.WriteLine(str1);
            Console.WriteLine($"{num2} {num3}");
        }
    }
}

//Задание 15.Составить программу вывода на экран «столбиком» четырех случайных чисел.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {   //класс Random
            Random rnd = new Random(); //Создание объекта для генерации чисел

            int num1 = rnd.Next();
            int num2 = rnd.Next();
            int num3 = rnd.Next();
            int num4 = rnd.Next();

            Console.WriteLine($"{num1}\n{num2}\n{num3}\n{num4}");
        }
    }
}

//Задание 16.Найти корни квадратного уравнения(коэффициенты задаются пользователем с клавиатуры)
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
                Console.WriteLine("Вещественных корней нет.");
        }
    }
}

//Задание 17.Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int average = ((num1 + num2) / 2);
            Console.WriteLine($"Среднее арифметическое чисел: {average}");
            double geom = Math.Sqrt(num1 * num2);
            Console.WriteLine($"Среднее геометрическое чисел: {geom}");
        }
    }
}

//Задание 18.Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Абцисса точки А = ");
            double xa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ордината точки А = ");
            double ya = Convert.ToDouble(Console.ReadLine());
            Console.Write("Абцисса точки B  = ");
            double xb = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ордината точки B = ");
            double yb = Convert.ToDouble(Console.ReadLine());
            double x = xb - xa;
            double y = yb - ya;
            double d = Math.Sqrt(x * x + y * y);
            Console.WriteLine($"Расстояние между точками A и B равно {d}");
        }
    }
}

//Задание 19.Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:
//а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            int num = a;
            a = b;
            b = c;
            c = num;
            Console.WriteLine($"a: {a},b: {b},c: {c}");
        }
    }
}

//Задание 19.Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:
//б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;
            int num = b;
            b = a;
            a = c;
            c = num;
            Console.WriteLine($"a: {a},b: {b},c: {c}");
        }
    }
}

//Задание 20.С начала суток прошло n секунд. Определить:
//а) сколько полных часов прошло с начала суток;
//б) сколько полных минут прошло с начала очередного часа;
//в) сколько полных секунд прошло с начала очередной минуты.

using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Сколько секунд прошло с начала суток: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int hours = n / 3600;
            Console.WriteLine($"Полных часов с начала суток прошло: {hours}.");
            int minutes = (n - hours * 3600) / 60;
            Console.WriteLine($"Полных минут с начала очередного часа прошло: {minutes}.");
            int seconds = (n - hours * 3600) - 60 * minutes;
            Console.WriteLine($"Полных секунд с начала очередной минуты прошло: {seconds}.");
        }
    }
}

//Задание 21.Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 543;
            int B = 130;
            int S = A * B;
            int a = 130;
            int s = a * a;
            int n = S / s;
            Console.WriteLine($"Можно отрезать квадратов: {n}.");
        }
    }
} 

//Задание 22.Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int last_digit = num % 10;
            int new_num = last_digit * 100 + num / 10;
            Console.WriteLine($"Новое число: {new_num}.");
        }
    }
}
    
//Задание 23.Дано натуральное число n (n > 999). Найти:
//а) число сотен в нем;
//б) число тысяч в нем.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n (n > 999):");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = (n / 100) % 10;
            int t = (n / 1000);
            if (n > 999)
            {
                Console.WriteLine($"а)Число сотен в числе: {s}");
                Console.WriteLine($"б)Число тысяч в числе: {t}");
            }
            else
                Console.WriteLine("Число должно быть больше 999.");
        }
    }
}

//Задание 24.Дано четырехзначное число. Найти:
//а) число, полученное при прочтении его цифр справа налево;
//б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
//заданного числа.Например, из числа 5434 получить 4543, из числа 7048 — 784;
//в) число, образуемое при перестановке второй и третьей цифр заданного числа.
//Например, из числа 5084 получить 5804;
//г) число, образуемое при перестановке двух первых и двух последних цифр
//заданного числа.Например, из числа 4566 получить 6645, из числа 7304 — 473.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырёхзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int e = num % 10;
            int d = (num / 10) % 10;
            int s = (num / 100) % 10;
            int t = num / 1000;

            if (s == 0 && d == 0 && e == 0)
            {
                Console.WriteLine($"а) {t}");
            }
            else if (d == 0 && e == 0)
            {
                Console.WriteLine($"а) {s}{t}");
            }
            else if (e == 0)
            {
                Console.WriteLine($"а) {d}{s}{t}");
            }
            else
            {
                Console.WriteLine($"а) {e}{d}{s}{t}");
            }

            if (s == 0)
            {
                Console.WriteLine($"б) {t}{e}{d}");
            }
            else
            {
                Console.WriteLine($"б) {s}{t}{e}{d}");
            }

            Console.WriteLine($"в) {t}{d}{s}{e}");

            if (d == 0 && e == 0)
            {
                Console.WriteLine($"г) {t}{s}");
            }
            else if (d == 0)
            {
                Console.WriteLine($"г) {e}{t}{s}");
            }
            else
            {
                Console.WriteLine($"г) {d}{e}{t}{s}");
            }
        }
    }
}

//Задание 25.Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x, то получилось число n.
//Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом число десятков в n не равно нулю.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n в диапозоне '100 ≤ n ≤ 999' (причём так, чтобы число десятков в нём не было равно 0): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int e = n % 10;
            int d = (n / 10) % 10;
            int s = (n / 100);
            Console.WriteLine($"Искомое число х = {d}{e}{s}.");
        }
    }
}

//Задание 28.Создать программу, которая будет выводить на экран меньшее по модулю из трёх введённых пользователем вещественных чисел
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое число = ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число = ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третье число = ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double minAbs = Math.Min(Math.Abs(n1), Math.Min(Math.Abs(n2), Math.Abs(n3)));
            Console.WriteLine($"Меньшее по модулю число: {minAbs}.");
        }
    }
}

//Задание 29.Найти сумму большего и меньшего из трёх заданных чисел
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Первое число = ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Второе число = ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Третье число = ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double min = Math.Min(n1, Math.Min(n2, n3));
            double max = Math.Max(n1, Math.Max(n2, n3));
            double sum = min + max;
            Console.WriteLine($"Сумма меньшего и большего из заданных чисел: {sum}.");
        }
    }
}

//Задание 32.Заданы первый и второй элементы арифметической прогрессии. Требуется написать программу, которая вычислит элемент прогрессии по ее номеру.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый член арифметической прогресии: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второй член арифметической прогресии: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите номер элемента прогрессии: ");
            double n = Convert.ToDouble(Console.ReadLine());
            double d = a2 - a1;
            double nth_element = a1 + (n - 1) * d;
            Console.WriteLine($"Элемент прогрессии под номером {n} равен {nth_element}.");
        }
    }
}

//Задание 33.Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если трудоустроен не получаю кредит. Ну а если я, и пенсионер и студент, (трудоустройство тут не имеет значения) то не должен получить.
//Необходимо вводить строки, содержащие информацию о том, студент, пенсионер или кто-то ещё. Вывести информацию: дадут кредит или нет.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы студент:\n1 - Да;\n2 - Нет.");
            Console.Write("Введите номер ответа: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы пенсионер:\n1 - Да;\n2 - Нет.");
            Console.Write("Введите номер ответа: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы трудоустроены:\n1 - Да;\n2 - Нет.");
            Console.Write("Введите номер ответа: ");
            int t = Convert.ToInt32(Console.ReadLine());

            if (s == 1 && p == 1)
            {
                Console.WriteLine("В кредите отказано!");
            }
            else if ((s == 1 || p == 1) && t == 2)
            {
                Console.WriteLine("Кредит одобрен, хоть это и не логично!");
            }
        }
    }
}

//Задание 34.Составить программу, которая:
//а) запрашивает имя человека и повторяет его на экране;
//б) запрашивает имя человека и повторяет его на экране с приветствием.
using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"a){name}.");
            Console.WriteLine($"б)Здравствуйте, {name}.");
        }
    }
}