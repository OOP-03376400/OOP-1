using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab11
{
    class Set
    {
        public int[] massif = new int[maxsize];
        static int maxsize = 30;
        public int size;

        public Set() //без параметров
        {
            size = 0;
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
        public double sum()
        {
            int sum = 0;
            for(int i=0; i<size;i++)
            {
                sum += massif[i];
            }
            return sum;
        }

        public double max()
        {
            int max = massif[0];
            for (int i = 0; i < size; i++)
            {
                if(massif[i]>max)
                {
                    max = massif[i];
                }
            }
            return max;
        }
        public double min()
        {
            int min = massif[0];
            for (int i = 0; i < size; i++)
            {
                if (massif[i] < min)
                {
                    min = massif[i];
                }
            }
            return min;
        }
        public bool otr()
        {
            bool a=false;
            for (int i = 0; i < size; i++)
            {
                if (massif[i] < 0)
                {
                    a= true;
                }
            }
            return a;
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
}
