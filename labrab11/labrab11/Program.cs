using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = { "January", "February", "March", "April", "May", "June", "July", "August", "September",
            "October","November","December"};
            Console.WriteLine("12 месяцев:");
            foreach (object m in mes)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            Console.WriteLine("Последовательность месяцев с длиной строки равной n");
            Console.WriteLine("Введите количество символов n:");
            int n = int.Parse(Console.ReadLine());
            var zaprosN = from m in mes
                          where m.Length == n
                          select m;
            foreach (string mesz in zaprosN)
            {
                Console.WriteLine(mesz);
            }
            Console.WriteLine();

            Console.WriteLine("Вывод только летних и зимних месяцев");
            var zaprosLZ = from m in mes
                           where (m == "June" || m == "July" || m == "August" || m == "December" || m == "January" || m == "February")
                           select m;
            foreach (string mesz in zaprosLZ)
            {
                Console.WriteLine(mesz);
            }
            Console.WriteLine();

            Console.WriteLine("Месяцы в алфавитном порядке");
            var zaprosA = from m in mes
                          orderby m
                          select m;
            foreach (string mesz in zaprosA)
            {
                Console.WriteLine(mesz);
            }
            Console.WriteLine();

            Console.WriteLine("Посчет месяцев, содержащие букву «u» и длиной имени не менее 4");
            int i = 0;
            var zaprosU = from m in mes
                          where (m.Contains('u') && m.Length >= 4)
                          select m;
            foreach (string mesz in zaprosU)
            {
                i++;
            }
            Console.WriteLine($"{i} месяцев подходящих под запрос");
            foreach (string mesz in zaprosU)
            {
                Console.WriteLine(mesz);
            }
            Console.WriteLine();

            ////////////////2
            List<Set> set = new List<Set>();

            Set set1 = new Set();
            set.Add(set1);
            set[0].Add(5);
            set[0].Add(1);
            set[0].Add(-8);
            set[0].Add(7);
            set[0].Show();
            Console.WriteLine( set[0].max());
            Console.WriteLine();
            
            Set set2 = new Set();
            set.Add(set2);
            set[1].Add(-5);
            set[1].Add(6);
            set[1].Add(5);
            set[1].Add(9);
            set[1].Show();
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int maxx = 0;
            if(set[0].max()>set[1].max())
            {
                maxx = (int)set[0].max();
            }
            else
            {
                maxx = (int)set[1].max();
            }
            var max = from v in set
                      where ((v.massif.Contains(maxx)))
                      select v;

            foreach (object v in max)
            {
                if (v.Equals(set1)) 
                {
                    Console.WriteLine("Множество с максимльным элементом set1");
                }
                if(v.Equals(set2))
                {
                    Console.WriteLine("Множество с максимльным элементом set2");
                }
            }
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int min = 0;
            if (set[0].min() < set[1].min())
            {
                min = (int)set[0].min();
            }
            else
            {
                min = (int)set[1].min();
            }
            var minn = from v in set
                      where ((v.massif.Contains(min)))
                      select v;

            foreach (object v in minn)
            {
                if (v.Equals(set1))
                {
                    Console.WriteLine("Множество с минимальным элементом set1");
                }
                if (v.Equals(set2))
                {
                    Console.WriteLine("Множество с минимальным элементом set2");
                }
            }
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int j = 0;
            var otrM = from v in set
                       where (v.otr())
                       select v;
            foreach (object v in otrM)
            {
                if (v.Equals(set2))
                {
                    Console.WriteLine("Множество с отрицательным элементом set2");
                }
                if (v.Equals(set1))
                {
                    Console.WriteLine("Множество с отрицательным элементом set1");
                }
            }

            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Введите значение");
            int z = int.Parse(Console.ReadLine());
            var kolM1 = from v in set
                       where (v.massif.Contains(z))
                       select v;
            Console.WriteLine($"Первое множество которе содержит элемент {z}");
            foreach (object v in kolM1)
            {
            
             
                if ((v.Equals(set1)))
                { Console.Write($"Множество set1 содержит элемент {z}"); break; }
                else
                {
                    if (v.Equals(set2))
                    {
                        Console.Write($"Множество set2 содержит элемент {z}"); break;
                    }
                }
            }

            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Количество множеств, содержащих заданное значение");
            int amount = 0;
            Console.WriteLine("Введите значение");
            int zn = int.Parse(Console.ReadLine());
            var res = from m in set
                      where (m.massif.Contains(zn))
                      select m;
            foreach (Set sett in res)
            {
                amount++;
            }
            Console.WriteLine($"{amount} множество, содержащих значение {zn}");

            foreach (object bb in res)
            {
                if (bb.Equals(set1))
                {
                    Console.WriteLine("Множество 1 содержит значение");
                    set[0].Show();
                }
                else
                {
                    Console.WriteLine("Множество 2 содержит значение");
                    set[1].Show();
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////


        }
    }
}
