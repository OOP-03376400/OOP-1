using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab4
{
    public class Set
    {
        public int[] massif = new int[maxsize];
        static int maxsize = 30;
        public int size;
        public static int st = 0;
        public bool error = false;

        public Set()
        {
            size = 0;
            ++st;
        }


        public int SetGet 
        {
            get 
            {
                return massif[size];
            }
            set 
            {
                if (size == 0)
                {
                    Console.WriteLine("Пустое множество ");
                }
                else
                {
                    massif[size] = value;
                    size++;
                }

            }
        }

        public void inf()
        {
            Console.WriteLine("В классе содержится " + st + " объектов");
        }

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
                    for (int n = j; n < size; n++)
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

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < size) return massif[i];
                else { error = true; return 0; }
            }
            set
            {
                if (i >= 0 && i < size)
                {
                    massif[i] = value;
                    size++;
                }
                else error = true;
            }
        }

        public static Set operator +(Set set, int item)
        {
            set.massif[set.size] = item;
            set.size++;
            return set;
        }

        public static Set operator +(Set set1, Set set2)
        {
            int one = set1.size;
            int two = set2.size;
            Set set3 = new Set();
            for (int i = 0; i < one; i++)
            {
                set3.massif[set3.size] = set1.massif[i];
                set3.size++;
            }
            for (int j = 0; j < two; j++)
            {
                set3.massif[set3.size] = set2.massif[j];
                set3.size++;
            }
            return set3;
        }

        public static Set operator *(Set set1, Set set2)
        {
            int one = set1.size;
            int two = set2.size;
            int three = one + two;
            Set set3 = new Set();
            for (int i = 0; i < one; i++)
            {
                for (int j = 0; j < two; j++)
                {
                    if (set1.massif[i] == set2.massif[j])
                    {
                        set3.massif[set3.size] = set1.massif[i];
                        set3.size++;
                    }

                }
            }

            return set3;
        }

        public static explicit operator int(Set set)
        {
            int power = set.size;
            return power;
        }

        public static bool operator true(Set set)
        {
            if (set.size <= 0 && set.size > 30) return true;
            else return false;
        }

        public static bool operator false(Set set)
        {
            if (set.size > 0 && set.size <= 30) return false;
            else return true;
        }

        public class Owner
        {
            public int ID;
            public string name;
            public string organization;
            public Owner(int id, string name, string organization)
            {
                this.ID = id;
                this.name = name;
                this.organization = organization;
            }
        }

        public class Date
        {
            public string date;
            public Date(string date)
            {
                this.date = date;
            }
        }

    }

    static class myObject
    {
        public static int max(Set set)
        {
            int max=-1000;
            for (int i = 0; i < set.size; i++)
            {
                if (set.massif[i] > max)
                    max = set.massif[i];
            }
            return max;
        }
        public static int min(Set set)
        {
            int min = 1000;
            for (int i = 0; i < set.size; i++)
            {
                if (set.massif[i] < min)
                    min = set.massif[i];
            }
            return min;
        }

        public static int size(Set set)
        {
            return set.size;
        }
    }

    static class ExtensionClass
    {
        public static string Addz(this String st)
        {
            string c = ", ";
            string res = "";
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == ' ')
                {
                    res += c;
                }
                res += st[i];
            }
            return res;
        }

        public static Set Deletez(this Set set)
        {

            for (int i = 0; i < set.size - 1; i++)
            {
                for (int j = 1; j < set.size; j++)
                {
                    if (set.massif[i] == set.massif[j])
                    {
                        for (int k = j; k < set.size; k++)
                        {
                            set.massif[j] = set.massif[j + 1];
                        }
                        set.size--;
                    }
                }

            }
            return set;
        }

    }

        class Program
    {
        static void Main(string[] args)
        {
            Set set1 = new Set();
            set1.Add(1);
            set1.Add(2);
            set1.Add(3);
            set1.Add(1);
            set1.Add(2);
            set1.Add(1);
            set1.Add(3);
            set1.Add(3);
            Console.WriteLine("Множество 1: ");
            set1.Show();
            Console.WriteLine();
            Console.WriteLine("Количество элементов множества 1: ");
            set1.Amount();
            Console.WriteLine();
            Set set2 = new Set();
            set2.Add(1);
            set2.Add(3);
            Console.WriteLine("Множество 2: ");
            set2.Show();
            Console.WriteLine();
            Console.WriteLine("Количество элементов множества 2: ");
            set2.Amount();
            Console.WriteLine();

            Console.WriteLine("Оператор + (set2+item(6)): ");
            Set set3 = new Set();
            set3 = set2 + 2;
            set3.Show();
            Console.WriteLine();

            Console.WriteLine("Оператор + (объединение множеств): ");
            Set set4 = new Set();
            set4 = set2 + set3;
            set4.Show();
            Console.WriteLine();

            Console.WriteLine("Оператор * (пересечение множеств): ");
            Set set5 = new Set();
            set5 = set1 * set3;
            set5.Show();
            Console.WriteLine();

            Console.WriteLine("Мощность множества 1: ");
            Console.WriteLine((int)set1);
            Console.WriteLine();

            Console.WriteLine("Принадлежность диапазону (0; 30] (false): ");
            //Console.WriteLine(Set.true(set1) ? set1:"не принадлежит диапазону ");


            string str = "ghbdtn rfr ltkf";
            Console.WriteLine(str.Addz());
            set1.Show();
            set1.Deletez();
            set1.Show();

            Set.Owner owner = new Set.Owner(23061609, "Margo", "BSTU");
            Console.WriteLine(owner.ID + " " + owner.name + " " + owner.organization);

            Set.Date date = new Set.Date("ws");
            Console.WriteLine(date.date);
        }
    }
}
