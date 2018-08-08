using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab9
{
    public delegate void Директор();
    class Director
    { 
        string Name;
        public static int зарплата = 0;
 
        public Director()
        {

        }
        public Director(string Name)
        {
            this.Name = Name;
            зарплата = 400;
        }

        public void info()
        {
            Console.WriteLine("Имя: {0}", Name);
            Console.WriteLine("Зарплата: {0}", зарплата);
            //зарплата = 400;
        }

        public int вычесть = 25;
        public int прибавить = 25;
        public event Директор Повысить;
        public event Директор Штраф;
        public void Повышение()
        {
            Console.WriteLine("Повышен");
            if (Повысить != null)
            {
                Повысить();
            }
        }
        public void Оштрафовать()
        {
            Console.WriteLine("Оштрафован");
            if (Штраф != null)
            {
                Штраф();
            }
        }
    }

    class Зарплата : Director
    {

        public delegate int Прибавка(ref int a, ref int b);
        Прибавка plus = (ref int a, ref int b) => (a += b);

        public void SobitieA()
        {
            Console.WriteLine("Повышение зарплаты ");
            plus(ref зарплата, ref прибавить);
        }

        public delegate int Убыток(ref int a, ref int b);
        Убыток minus = (ref int a, ref int b) => (a -= b);

        public void SobitieB()
        {
            Console.WriteLine("Штраф ");
            minus(ref зарплата, ref вычесть);
        }
    }
}
