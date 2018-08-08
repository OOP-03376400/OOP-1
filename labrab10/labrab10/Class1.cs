using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace labrab10
{
    public class CountIsZeroException : Exception
    {
        public CountIsZeroException()
        {
        }
        public CountIsZeroException(string message)
        : base(message)
        {
        }
    }

    public class WrongValue : Exception
    {
        public WrongValue()
        {
        }
        public WrongValue(string message)
        : base(message)
        {
        }
    }

    public class WrongAmount : Exception
    {
        public WrongAmount()
        {
        }
        public WrongAmount(string message)
        : base(message)
        {
        }
    }




    public abstract class Товар : Interface
    {
        public string name = "";
        public string producer = "";
        public int price;
        public int amount;
        public abstract void ShowInformation();

        public virtual void InputInformation()
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
        public virtual void FindingPrice()
        {
            if (name == "Мебель")
            {
                if (amount == 0)
                    throw (new CountIsZeroException("Нельзя делить на ноль"));
                else
                    price = 23654 / amount;
            }
            Console.WriteLine("Нахождение цены");
            Console.WriteLine($"Цена {name} : ");
        }
    }
    class Мебель : Товар
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
        public override string ToString()
        {
            string str = "";
            Console.WriteLine("Тип объекта 'Мебель'");
            Console.WriteLine($"Информация о: {name} \n Количество = {amount} \n Производитель = {producer} \n Цена = {price}");
            return str;
        }
    }
    class Диван : Мебель
    {
        public override string ToString()
        {
            string str = "";
            Console.WriteLine("Тип объекта 'Диван'");
            Console.WriteLine($"Информация о: {name} \n Количество = {amount} \n Производитель = {producer} \n Цена = {price}");
            return str;
        }
        public Диван()
        {
            name = "Диван";
        }
        public override void ShowInformation()
        {
            Console.WriteLine("Вывод информации ");
            Console.WriteLine($"Мебель {name}");

            Console.WriteLine($"Цена {name} = {price}");
            Console.WriteLine();

        }
        public override void InputInformation()
        {
            if (this.name == "Диван")
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
            if (name == "Диван")
            {
                if (amount == 0)
                    throw (new CountIsZeroException("Нельзя делить на ноль"));
                else
                    price = 23654 / amount;
            }
            Console.WriteLine("Нахождение цены ");
            Console.WriteLine($"Цена {name} : {price}");
        }

    }
    class Кровать : Мебель
    {
        public override string ToString()
        {
            string str = "";
            Console.WriteLine("Тип объекта 'Кровать'");
            Console.WriteLine($"Информация о: {name} \n Количество = {amount} \n Производитель = {producer} \n Цена = {price}");
            return str;
        }
        public Кровать()
        {
            name = "Кровать";
        }
        public override void ShowInformation()
        {
            Console.WriteLine("Вывод информации");
            Console.WriteLine($"Мебель {name}");

            Console.WriteLine($"Цена {name} = {price}");
            Console.WriteLine();

        }
        public override void InputInformation()
        {
            if (this.name == "Кровать")
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
            if (name == "Кровать")
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
    interface Interface
    {
        void ShowInformation();
        void InputInformation();
        void FindingPrice();
    }


    //sealed class A
    //{

    //}
    //class B : A
    //{

    //}

    class Printer : Товар
    {
        public override void ShowInformation()
        {
            Console.WriteLine("Вывод информации ");
            Console.WriteLine($"Товар {name}");

            Console.WriteLine($"Цена {name} = {price}");
            Console.WriteLine(); ;
        }
        public virtual void iAmPrinting(Товар someobj)
        {
            Console.WriteLine(someobj.GetType());
            someobj.ToString();
        }
    }
}
