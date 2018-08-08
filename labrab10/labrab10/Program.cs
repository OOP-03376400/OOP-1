using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace labrab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            ///////////////////////////////////////////////////////////////////////////////
            ArrayList list = new ArrayList();
            Random цифра = new Random();
            int[] a = new int[6];
            for (int i = 0; i < 5; i++)
            {
                a[i] = цифра.Next(0, 100);
            }
            for (int i = 0; i < 5; i++)
            {
                list.Add(a[i]);
            }
            foreach (object ind in list)
            {
                Console.WriteLine(ind);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            list.AddRange(new string[] { "hello wrold !!!" });
            foreach (object ind in list)
            {
                Console.WriteLine(ind);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            list.RemoveAt(3);
            foreach (object ind in list)
            {
                Console.WriteLine(ind);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine(list.Count);
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine(list.Contains("hello wrold !!!"));
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////

            //Задание 2
            ///////////////////////////////////////////////////////////////////////////////
            HashSet<long> Q = new HashSet<long>();
            Console.WriteLine("Введите количество элементов.");
            int per = int.Parse(Console.ReadLine());
            Q.Add(1);
            for (int i = 0; i < per; i++)
            {
                Console.WriteLine("Введите элемент.");
                long ch = long.Parse(Console.ReadLine());
                Q.Add(ch);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("HashSet: ");
            foreach (object b in Q)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Введите количество эдементов для удаления ");
            int col = int.Parse(Console.ReadLine());
            long[] arr = new long[col];
            if (col > Q.Count())
            {
                Console.WriteLine("Превышение размера множества ");
            }
            else
            {

                Console.WriteLine("Введите эдементы для удаления ");
                for (int i=0; i < col; i++)
                {
                    arr[i] = long.Parse(Console.ReadLine());
                }
                for (int i = 0; i < col; i++)
                {
                   Q.Remove(arr[i]);
                }
            }
            Console.WriteLine();
            foreach (object b in Q)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Введите элемент.");
            long che = long.Parse(Console.ReadLine());
            Q.Add(che);
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            int size = Q.Count();
            LinkedList<long> d = new LinkedList<long>();
            long[] buf = new long[size];
            Q.CopyTo(buf);
            d.AddFirst(buf[0]);
            for (int i = 1; i < size; i++)
            {
                d.AddLast(buf[i]);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            foreach (object dd in d)
            {
                Console.WriteLine(dd);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Введите значения для поиска.");
            long cc = long.Parse(Console.ReadLine());
            if (d.Contains(cc))
            {
                Console.WriteLine("Элемент найден. ");
            }
            else { Console.WriteLine("Элемент не найден. "); }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////


            //Задание 3
            ///////////////////////////////////////////////////////////////////////////////
            HashSet<Товар> okr = new HashSet<Товар>();
            ///////////////////////////////////////////////////////////////////////////////
            Товар C = new Мебель();
            C.InputInformation();
            C.FindingPrice();
            C.ShowInformation();
            Console.WriteLine();
            okr.Add(C);
            Товар B = new Диван();
            B.InputInformation();
            B.FindingPrice();
            B.ShowInformation();
            Console.WriteLine();
            okr.Add(B);
            foreach (object z in okr)
            {
                Console.WriteLine(z);
            }
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Удален элемент B :");
            okr.Remove(B);
            foreach (object z in okr)
            {
                Console.WriteLine(z);
            }
            ///////////////////////////////////////////////////////////////////////////////
            Товар prm1 = new Мебель();
            prm1.InputInformation();
            prm1.FindingPrice();
            prm1.ShowInformation();
            Console.WriteLine();
            okr.Add(prm1);
            foreach (object z in okr)
            {
                Console.WriteLine(z);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            LinkedList<Товар> ds = new LinkedList<Товар>();
            Товар[] buyf = new Товар[size];
            okr.CopyTo(buyf);
            ds.AddFirst(buyf[0]);
            for (int i = 1; i < size; i++)
            {
                ds.AddLast(buyf[i]);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("HashSet: ");
            foreach (object dv in ds)
            {
                Console.WriteLine(dv);
            }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////
            if (ds.Contains(C))
            {
                Console.WriteLine("Элемент C найден. ");
            }
            else { Console.WriteLine("Элемент не найден. "); }
            Console.WriteLine();
            ///////////////////////////////////////////////////////////////////////////////

            //Задание 4
            ///////////////////////////////////////////////////////////////////////////////
            ObservableCollection<Товар> OBQ = new ObservableCollection<Товар>();
            obr ad = new obr();
            OBQ.CollectionChanged += ad.sobposleadd;
            OBQ.Add(prm1);
            OBQ.Add(C);
            foreach (object bb in OBQ)
            {
                Console.WriteLine(bb);
            }
            OBQ.Remove(prm1);
            foreach (object bb in OBQ)
            {
                Console.WriteLine(bb);
            }
        }
        ///////////////////////////////////////////////////////////////////////////////
        class obr
        {
            public void sobposleadd(object sender, EventArgs e)
            {
                Console.WriteLine("Метод, зарегестрированный на событие CollectionChanged");
            }
        }
    
    }
}
