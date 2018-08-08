using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            bool myBool = true;
            byte myByte = 255;
            sbyte mySbyte = -128;
            short myShort = -32768;
            ushort myUshort = 65535;
            int myInt = -24756;
            uint myUint = 3647;
            long myLong = 447684;
            ulong myUlong = 123456;
            float myFloat = 3.54f;
            double myDouble = 6.47851d;
            decimal myDecimal = 9.99m;
            char myChar = 'a';
            string myString = "my String";
            object myObject = 7; //Переменным типа object можно назначать значения любых типов

            short a = myByte;
            int b = myShort;
            long c = myInt;
            ulong d = myUint;
            double e = myFloat;

            byte aa = (byte)b;
            int bb = (int)myFloat;
            short cc = (short)myLong;
            float dd = (float)myDecimal;
            ushort ee = (ushort)myDouble;

            int myBoxing = 160298; //процесс преобразов типа знач в тип object
            object newObject = myBoxing;
            int myUnboxing = (int)newObject; //получение указателя на исх значимый тип

            var sum = 3;
            int res = sum + 4;
            Console.WriteLine("3 + 4: " + res);
            var txt = "hello ";
            string text = txt + "world";
            Console.WriteLine("hello + world: " + text);

            int? myNullable = 10; //упрощенная форма использования структуры System.Nullable<T>, котоая позволяет null значения
            if (myNullable.HasValue)
            {
                Console.WriteLine("Значение nullable переменной: " + myNullable.Value);
            }
            else
            {
                Console.WriteLine("Значение nullable переменной: " + "Null");
            }

            //задание 2
            string first = "hello";
            string second = "hallo";
            Console.WriteLine("Сравнение строк: " + (first == second));

            string one = "Hello ";
            string two = "World ";
            string three = "!!!"; 
            string ResultOne = String.Concat(one, two, three);
            Console.WriteLine("Сцепление: " + ResultOne);
            string ResultTwo = String.Copy(one);
            Console.WriteLine("Копирование: " + ResultTwo);
            string ResultThree = ResultOne.Substring(6, 5);
            Console.WriteLine("Выделение подстроки: " + ResultThree);
            string[] ResultFour = ResultOne.Split(' ');
            Console.WriteLine("Разделение строки: ");
            foreach (var str in ResultFour)
            {
                Console.WriteLine(str);
            }
            string ResultFive = ResultOne.Insert(5, ",");
            Console.WriteLine("Вставка подстроки: " + ResultFive);
            string ResultSix = ResultOne.Remove(11);
            Console.WriteLine("Удаление подстроки: " + ResultSix);

            string empty = ""; //могут исп строковые методы
            string emptynull = null; // строки NULL только в операциях объединения и сравнения с другими строками
            string z = "ghggkuj";
            Console.WriteLine("Сцепление строк: " + (z + emptynull));
            Console.WriteLine("Равенство строк: " + (empty == emptynull));
            Console.WriteLine("Вставка подстроки: " + empty.Insert(0, "ggjhj"));


            StringBuilder myStr = new StringBuilder("Hello World", 50);
            myStr.Remove(6, 5);
            Console.WriteLine("Удаление: " + myStr);
            myStr.Append("!!!");
            Console.WriteLine("Вставка назад: " + myStr);
            myStr.Insert(0, "World, ");
            Console.WriteLine("Вставка вперед: " + myStr);

            //задание 3 
            const int m = 3, n = 3;
            int[,] arrone = new int[m, n] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9} 
             };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                    Console.Write("\t" + arrone[i, j]);
                Console.WriteLine();
            }

            string[] arrtwo = new string[] { "one", "two", "three" };
            foreach (string st in arrtwo) Console.WriteLine(st);
            Console.WriteLine(arrtwo.Length);
            Console.WriteLine("Введите номер позиции: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое значение: ");
            string value = Console.ReadLine();
            arrtwo[position-1] = value;
            if (position > arrtwo.Length)
            {
                Console.WriteLine("заданной позиции не существует");
            }
            foreach (string str in arrtwo) Console.WriteLine(str);

            float[][] arrthree = new float[3][];
            arrthree[0] = new float[2];
            arrthree[1] = new float[3];
            arrthree[2] = new float[4];
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < 2; i++)
            {
                arrthree[0][i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                arrthree[1][i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                arrthree[2][i] = float.Parse(Console.ReadLine());
            }
            foreach (float[] row in arrthree)
            {
                foreach (float col in row)
                {
                    Console.Write("\t" + col);
                }
                Console.WriteLine();
            }

                var mass = new int[] { 1, 2, 3 };
                var strin = "hello";

            //задание 4
            var myTuple = new Tuple<int, string, char, string, ulong>(2, "abc", 'i', "def", 9); 
            Console.WriteLine("Кортеж: {0}, {1}, {2}, {3}, {4}", myTuple.Item1, myTuple.Item2, myTuple.Item3, myTuple.Item4, myTuple.Item5);
            Console.WriteLine("Первый элемент: {0}", myTuple.Item1);
            Console.WriteLine("Третий элемент: {0}", myTuple.Item3);
            Console.WriteLine("Четвертый элемент: {0}", myTuple.Item4);

            var myTuplee = new Tuple<int, string, char, string, ulong>(2, "abc", 'i', "def", 8);
            Console.WriteLine("Сравнение кортежей: " + myTuple.Equals(myTuplee));
            int frst = myTuple.Item1;
            string scnd = myTuple.Item2;
            char thrd = myTuple.Item3;
            string fourth = myTuple.Item4;
            ulong fifth = myTuple.Item5;
            
            //(frst, scnd, thrd, fourth, fifth) = (myTuple);

        }
    }
}
