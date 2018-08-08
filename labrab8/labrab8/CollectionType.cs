using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab8
{
    class CollectionType<T> : Interface<T> where T: struct
    {
        public dynamic[] massif = new dynamic[maxsize];
        static dynamic maxsize = 30;
        public dynamic size;
        public static int st = 0;
        public bool error = false;

        public CollectionType()
        {
            size = 0;
            ++st;
        }


        public void inf()
        {
            Console.WriteLine("В классе содержится " + st + " объектов");
        }

        public void Add(T element)
        {
            massif[size] = element;
            size++;
        }


        public void Remove(T element)
        {
            for (int j = 0; j < size; j++)
            {
                if (massif[j] ==  element)
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

        public static CollectionType<T> operator +(CollectionType<T> set, int item)
        {
            set.massif[set.size] = item;
            set.size++;
            return set;
        }

        public static CollectionType<T> operator +(CollectionType<T> set1, CollectionType<T> set2)
        {
            int one = set1.size;
            int two = set2.size;
            CollectionType<T> set3 = new CollectionType<T>();
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

        public static CollectionType<T> operator *(CollectionType<T> set1, CollectionType<T> set2)
        {
            int one = set1.size;
            int two = set2.size;
            int three = one + two;
            CollectionType<T> set3 = new CollectionType<T>();
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

        public static explicit operator int(CollectionType<T> set)
        {
            int power = set.size;
            return power;
        }

        public static bool operator true(CollectionType<T> set)
        {
            if (set.size <= 0 && set.size > 30) return true;
            else return false;
        }

        public static bool operator false(CollectionType<T> set)
        {
            if (set.size > 0 && set.size <= 30) return false;
            else return true;
        }

    }


}
