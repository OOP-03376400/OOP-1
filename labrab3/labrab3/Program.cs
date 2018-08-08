using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3
{
    public partial class Set
    {
        public void Add(int element)
        {
            massif[size] = element;
            size++;
        }

        public void Remove(int element)
        {
            for (int j = 0; j < size; j++)
            {
                if (massif[j] == element)
                {
                    for(int n = j; n < size; n++)
                    {
                        massif[n] = massif[n + 1];
                    }
                }
            }
            size--;
        }

        public void Amount()
        {
            Console.WriteLine("Текущее количество элементов: " + size);
        }

        public void Show()
        {
            Console.WriteLine("Множество: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(massif[i]);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Set set1 = new Set();
            Set set2 = new Set();
            Set set3 = new Set();

            Console.WriteLine("Количество созданных объектов: ");
            set3.inf();
            Console.WriteLine();

            Console.WriteLine("Множество 1");
            set1.Add(2);
            set1.Add(-11);
            set1.Add(5);
            set1.Remove(2);
            set1.Amount();
            set1.Show();
            Console.WriteLine();

            Console.WriteLine("Измененное с помощью свойства множество 1");
            set1.SetGet = 3;
            set1.Show();
            Console.WriteLine();

            set1.Remove(3);

            Console.WriteLine("Множество 2");
            set2.Add(-11);
            set2.Add(5);
            set2.Amount();
            set2.Show();
            Console.WriteLine();

            Console.WriteLine("Хэш первого множества " + set1.GetHashCode());
            Console.WriteLine("Хэш второго множества " + set2.GetHashCode());
            Console.WriteLine();

            Console.WriteLine("Множество 3");
            set3.Add(-2);
            set3.Add(5);
            set3.Add(8);
            set3.Amount();
            set3.Show();
            Console.WriteLine(); 

            Console.WriteLine("Тип объекта set3: " + set3.GetType());
            Console.WriteLine();
            Console.WriteLine("Информация об объекте set3: " + set3.ToString());
            Console.WriteLine();
            Console.WriteLine("is set1 == set2? " + set2.Equals(set1));
            Console.WriteLine();


            List<Set> sete = new List<Set>();
            sete.Add(set1);
            sete.Add(set2);
            sete.Add(set3);
            sete.Add(new Set());
            Console.WriteLine();



            int max = -1000;
            int min = 1000;
            int sum = 0;
            foreach (var k in sete)
            {
                for (int i = 0; i < k.size; i++)
                {
                    sum += k.massif[i];
                }

                if (sum < min)
                {
                    min = sum;
                }
                if (sum > max)
                {
                    max = sum;
                }
                sum = 0;
            }

            foreach (var k in sete)
            {
                for (int i = 0; i < k.size; i++)
                {
                    sum += k.massif[i];
                }

                if (sum == min)
                {
                    string inf = "";
                    for (int i = 0; i < k.size; i++)
                    {
                        inf = inf + k.massif[i].ToString() + " ";
                    }
                    Console.WriteLine("Множество с наименьшей суммой элементов: " + inf + "Сумма: " + min);
                }
                if (sum == max)
                {
                    string inf = "";
                    for (int i = 0; i < k.size; i++)
                    {
                        inf = inf + k.massif[i].ToString() + " ";
                    }
                    Console.WriteLine("Множество с наибольшей суммой элементов: " + inf + "Сумма: " + max);
                }
                sum = 0;
            }

            Console.WriteLine();
            int nul = 0;
            bool tr = false;
            Console.WriteLine("Список множеств, содержащих отрицательные элементы: ");
            foreach (var k in sete)
            {
                for (int i = 0; i < k.size; i++)
                {
                    if (k.massif[i] < 0)
                    {
                        tr = true;
                    }
                }
                if (tr)
                {
                    k.Show();
                    nul++;
                }
                tr = false;
            }
            if (nul == 0)
            {
                Console.WriteLine("Такие множества отсутствуют");
            }


            var AnonymType = new { mass = new[] { 1, 2, 3 } };
}
    }
}



