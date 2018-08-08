using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab8
{
    class NewClass<T>:Class where T: class
    {

    }

    public class Class
    {

        public void Show()
        {
            Console.WriteLine("NewClass");
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            try
            {
                int b = 3 / a;
            }
            catch (Exception e)
            {
                Console.WriteLine("Деление на ноль");
            }
            finally
            {
                Console.WriteLine("Сгенерировано исключение");
            }

        }
    }
}
