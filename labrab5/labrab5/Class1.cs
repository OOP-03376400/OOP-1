using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace labrab5
{
    partial class Мебель
    {
        public Мебель()
        {
            name = "Мебель";
        }
        public override void ShowInformation()
        {
            Console.WriteLine("Вывод информации ");
            Console.WriteLine($"Товар {name}");

            Console.WriteLine($"Цена {name} = {price}");
            Console.WriteLine();

        }
        public override void InputInformation()
        {
            if (this.name == "Мебель")
            {
                Console.WriteLine($" Введите информацию о  {name}:");
                Console.Write("Количество: ");
                amount = int.Parse(Console.ReadLine());
                if (amount < 0)
                {
                    throw (new WrongAmount("Количество не может быть меньше нуля"));
                }
                Console.Write("Производитель: ");
                producer = Console.ReadLine();
                if (producer.Length < 2)
                {
                    throw (new WrongValue("Cлишком короткое имя"));
                }
                Debug.Assert(producer.Length < 10, "Длина превышает 10 символов");
            }
        }
        public override void FindingPrice()
        {
            if (name == "Мебель")
            {
                if (amount == 0)
                    throw (new CountIsZeroException("Нельзя делить на ноль"));
                else
                    price = 23654 / amount;
            }
            Console.WriteLine("Нахождение цены");
            Console.WriteLine($"Цена {name} : {price}");
        }
    }
}
