using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) 
            Console.WriteLine("1)Задание");
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(a+"  "+b+"  "+c+"  ");
            
            //2)
            Console.WriteLine("2)Задание");
            int number1 = 5, number2 = 10, number3 = 21;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            

            //3)
            Console.WriteLine("3)Задание");
            int meter = 100;
            Console.WriteLine("Введите расстояние в метрах");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine(distance / meter);

            //4)
            Console.WriteLine("4)Задание");
            int days = 234,week=7;
            Console.WriteLine("Полных недель: " + (days / week));
            


            //5)
            Console.WriteLine("5)Задание");
            int ten = 10, one = 1 ;
            Console.WriteLine("Введите любое двузначное число");
            int doubleNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество десятков: "+(doubleNumber/ten));
            Console.WriteLine("Количество единиц: " + (doubleNumber / one));
            Console.WriteLine("Сумма цифр: " + ((doubleNumber / ten)+(doubleNumber%ten)));
            Console.WriteLine("Произведение цифр: " + ((doubleNumber / ten) * (doubleNumber % ten)));
            

            //6)
            Console.WriteLine("6)Задание");
            bool A = true;
            bool B = false;
            bool C = false;

            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);


            

            //7)
            Console.WriteLine("7)Задание");
            double pi = 3.14,circle,quadrate;
            Console.WriteLine("Введите радиус круга");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга равен: "+(circle=pi*radius*radius));
            Console.WriteLine("Введите сторону квадрата");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь квадрата равна: " + (quadrate = side * side));
            if (circle>quadrate)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше");
            }
            

            //8)
            Console.WriteLine("8)Задание");
            double density1, density2;
            Console.WriteLine("Введите объем первого тела");
            double V = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу первого тела");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Плотность первого тела равна: "+(density1=weight/V));
            Console.WriteLine("Введите объем второго тела");
            double V2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела");
            double weight2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Плотность второго тела равна: " + (density2 = weight2 / V2));

            if(density1>density2)
            {
                Console.WriteLine("Плотность первого тела больше");
            }
            else if (density1 == density2)
            {
                Console.WriteLine("Одинаковы");
            }
            else
            {
                Console.WriteLine("Плотность второго тела больше");

            }
           
            //9)
            Console.WriteLine("9)Задание");
            double amperage1, amperage2;
            Console.WriteLine("Введите сопротивление первого участка");
            double resistance1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение первого участка");
            double voltage1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сила тока первого участка равна "+(amperage1=voltage1/resistance1));
            Console.WriteLine("Введите сопротивление второго участка");
            double resistance2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение второго участка");
            double voltage2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сила тока второго участка равна " + (amperage2 = voltage2 / resistance2));
            if (amperage1<amperage2)
            {
                Console.WriteLine("Меньшкий ток протекает по первому участку");
            }
            else if(amperage1 == amperage2)
            {
                Console.WriteLine("Одинаковы");
            }

            else
            {
                Console.WriteLine("Меньшкий ток протекает по второму участку");
            }
            

            //10)
            Console.WriteLine("10)Задание");
            for (int i=20;i<=35;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Введите до какого числа идет цикл, число должно быть больше 10");
            int lastNumber = int.Parse(Console.ReadLine());
            for (int i=10;i<=lastNumber;i++)
            {
                Console.WriteLine(i*i);
            }

            Console.WriteLine("Введите с какого числа  начинать цикл, число должно быть меньше 50");
            int StartNumber = int.Parse(Console.ReadLine());
            for (int i = StartNumber; i <= 50; i++)
            {
                Console.WriteLine(i * i*i);
            }

            Console.WriteLine("Введите с какого числа  начинать цикл");
            int BeginNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите на каком числе закончить цикл");
            int EndNumber = int.Parse(Console.ReadLine());
            for (int i = BeginNumber; i <=EndNumber; i++)
            {
                Console.WriteLine(i);
            }





            Console.ReadLine();





















        }
    }
}
