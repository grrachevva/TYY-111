using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rabota1Gracheva
{

    class Program
    {
        static void Main(string[] vs)
        {
            int a;
            decimal b;
            double c;
            int d;
            int e;
            int f;
            double i;
            decimal j;
            object g, s;


            Console.WriteLine("Нажмите на любую кнопку, чтобы начать общую часть работы");

            Console.ReadKey(true);

            Console.WriteLine("Введите число, для получения его модуля");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Модуль данного числа равен" + " " + Math.Abs(a));


            Console.WriteLine("Введите число, чтобы получить наименьшее целое число, которое больше или равно указанному числу");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine(Math.Ceiling(b));


            Console.WriteLine("Введите число от -1 до 1, изучения тригонометрических функций");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Угол, косинус которого равен указанному числу равен" + " " + Math.Acos((c * Math.PI) / 180));
            Console.WriteLine("Угол, синус которого равен указанному числу равен" + " " + Math.Asin((c * Math.PI) / 180));
            Console.WriteLine("Угол, тангенс которого равен указанному числу равен " + " " + Math.Atan((c * Math.PI) / 180));


            Console.WriteLine("Введите угол, измеряемый в градусах, для получение его косинуса, синуса и тангенса");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("косинус:" + " " + Math.Cos((d * Math.PI) / 180));
            Console.WriteLine("синус:" + " " + Math.Sin((d * Math.PI) / 180));
            Console.WriteLine("тангенс:" + " " + Math.Tan((d * Math.PI) / 180));


            Console.WriteLine("Введите угол, измеряемый в радианах, для получения гиперболического косинуса, синуса и тангенса");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("гиперболический косинус:" + " " + Math.Cosh(e));
            Console.WriteLine("гиперболический синус:" + " " + Math.Sinh(e));
            Console.WriteLine("гиперболический тангенс:" + " " + Math.Tanh(e));


            Console.WriteLine("Введите два числа, чтобы получить максимальное и минимальное из них");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("максимальное число:" + " " + Math.Max(a, b));
            Console.WriteLine("минимальное число:" + " " + Math.Min(a, b));


            Console.WriteLine("Нажмите любую клавишу, для получения математических констант");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Экспонента:" + " " + Math.E);
            Console.WriteLine("Число ПИ:" + " " + Math.PI);


            Console.WriteLine("Введите два числа, чтобы узнать остаток от их частного");
            a = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Остаток от частного двух чисел:" + " " + Math.DivRem(a, d, out int result));

            Console.WriteLine("Введите два числа, чтобы проверить их равность");
            g = Convert.ToInt32(Console.ReadLine());
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine(Math.Equals(g, s));

            Console.WriteLine("Введите число, для возведения числа 'e' в эту степень");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Результат возведения числа 'e' в эту степень:" + " " + Math.Exp(i));

            Console.WriteLine("Введите аргумент и основание для логарифма");
            i = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ответ на логарифм:" + " " + Math.Log(c, i));

            Console.WriteLine("Введите аргумент, для десятичного логарифма");
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ответ на логарифм:" + " " + Math.Log10(f));

            Console.WriteLine("Введите число и степнь, в которую его нужно возвести");
            c = Convert.ToInt32(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Число в степени:" + " " + Math.Pow(c, i));

            Console.WriteLine("Введите число, для его округления");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Округленное число:" + " " + Math.Round(c));

            Console.WriteLine("Введите число. Если оно отрицательное, то программа вернет '-1', если положительное, то '1', если число равно 0, '0'");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine(Math.Sign(a));

            Console.WriteLine("Введите число, чтобы узнать его корень");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Корень этого числа:" + " " + Math.Sqrt(i));

            Console.WriteLine("Введите десятичное число, чтобы получить его целую часть");
            j = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Целая часть этого числа:" + " " + Math.Truncate(j));

            Console.WriteLine("Введите число, чтобы получить наибольшее целое число, которое меньше или равно указанному числу");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Наибольшее целое число, которое меньше или равно указанному числу:" + " " + Math.Floor(b));

            double x;
            double y;

            Console.WriteLine("Введите значение x и y:");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Угол, тангенс которого равен отношению двух указанных чисел:" + " " + Math.Atan2(x, y));

            Console.WriteLine("Введите два целых числа для их произведения:");
            a = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Нажмите любую кнопку, для начала расчетов");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Произведение данных чисел равно" + " " + Math.BigMul(a, d));





            Console.WriteLine("Нажмите любую кнопку, чтобы начать вторую часть работы");
            Console.ReadKey(true);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.WriteLine("Вариант 5");
            int u = int.MinValue;

            Console.WriteLine("Введите 1-е число:");
            u = Math.Max(u, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 2-е число:");
            u = Math.Max(u, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 3-е число:");
            u = Math.Max(u, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 4-е число:");
            u = Math.Max(u, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 5-е число:");
            u = Math.Max(u, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Максимальное среди введённых: " + u);
            Console.ReadKey(true);

        }
    }
}