using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab8
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


        public void Amount()
        {
            Console.WriteLine("Текущее количество элементов: " + size);
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


    }
}

