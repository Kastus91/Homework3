using System;

namespace Home3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача №1

            // Пользователь вводит два числа (A и B).
            // Если A > B, подсчитать A+B, если A == B, подсчитать A*B, если A < B, подсчитать A-B.
            //Сделать лесенкой из двух if'ов.

            /*Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b) Console.WriteLine(a + b);
            else if (a == b) Console.WriteLine(a * b);
            else Console.WriteLine(a - b);*/
            #endregion


            #region Задача №2

            //Пользователь вводит два числа (X и Y).
            //Определить какой четверти координатной плоскости принадлежит точка с координатами (X,Y).
            //Примечание.Нумерацию четвертей принять такую:
            // 4 | 1
            //--------
            // 3 | 2


            /*Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0) Console.WriteLine("Точна находтся в первой четверти");

            else if (x > 0 && 0 > y) Console.WriteLine("Точка находится во второй четверти");

            else if (0 > x && 0 > y) Console.WriteLine("Точка находится в третьей четверти");

            else if (0 > x && y > 0) Console.WriteLine("Точка находится в четвертой четверти");

            else if (x == 0 && y == 0) Console.WriteLine("Центр, четверть не определена");*/
            #endregion


            #region Задача №3

            //Пользователь вводит три числа(A, B и С).
            //Выведите их в консоль в порядке возрастания.

            /*Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && b > c) Console.WriteLine($"{c} {b} {a}");
            else if (a > b && a > c && c > b) Console.WriteLine($"{b} {c} {a}");
            else if (b > a && a > c) Console.WriteLine($"{c} {a} {b}");
            else if (b > c && c > a) Console.WriteLine($"{a} {c} {b}");
            else if (c > a && a > b) Console.WriteLine($"{b} {a} {c}");
            else if (c > b && b > a) Console.WriteLine($"{a} {b} {c}");*/
            #endregion


            #region Задача №4

            /*Console.WriteLine($"Введите коэффициенты квадратного уравнения ax^2 + bx + c = 0 ");
            
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            
            double d = b * b - 4 * a * c;
           
            Console.WriteLine($"Дискриминант = {d}");
            
            double x1 = (-b - Math.Sqrt(d)) / 2 * a;
            double x2 = (-b - Math.Sqrt(d)) / 2 * a;
            
            Console.WriteLine($"Корни уравнения x1 = {x1}, x2 = {x2}");*/
            #endregion


            #region Задача №5
            //Пользователь вводит двузначное число.
            //Выведите в консоль прописную запись этого числа.

            /*static void Function_2()
            {
                Console.WriteLine("Введите число от 0 до 99");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Ваше число это " + NumberToString(number));
            }
            static string NumberToString(int number)
            {
                string[] units = { "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
                string[] tens = { "десять", "давдцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
                string[] tentotwenty = { "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

                string result = "";
                int n = number;
                int[] value = new int[2];
                value[0] = n % 10;
                value[1] = (n / 10) % 10;

                if (value[1] > 0)
                {
                    if (value[1] == 1 && value[0] != 0)
                    {
                        result += (tentotwenty[value[0] - 1] + " ");
                        return result;
                    }
                    else
                        result += (tens[value[1] - 1] + " ");
                }
                if (value[0] > 0)
                    result += (units[value[0] - 1] + " ");

                return result;
            }

            Function_2();*/
            #endregion


            #region Задача №6

            //Даны вещественные положительные числа a, b, c.
            //Выяснить, существует ли треугольник со сторонами a, b, c.


            /*Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double c = double.Parse(Console.ReadLine());

            if (a < b + c && c < a + b && b < a + c) Console.WriteLine("Треугольник существует");
            else Console.WriteLine("Треугольник не существует");*/
            #endregion


            #region Задача повышенной сложности №2

            //Ввести с клавиатуры вещественное число R и две точки(координаты) x и y.
            //Определить, принадлежит ли точка с координатами[x; y] заштрихованной фигуре.

            /*Console.Write("Введите число R: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Введите координату х: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите координату у: ");
            double y = double.Parse(Console.ReadLine());

            if (y >= r && 2 * r >= y && x >= r && 2 * r >= x) Console.WriteLine("Точка принадлежит заштрихованной фигуре");
            else if (0 > y && (y >= -2 * r) && 0 > x && (x >= -2 * r) ) Console.WriteLine("Точка принадлежит заштрихованной фигуре");
            else Console.WriteLine("Точка не принадлежит заштрихованной фигуре");*/
            #endregion
        }
    }
}
