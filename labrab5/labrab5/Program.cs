using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace labrab5
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

 

    public abstract class Товар: Interface
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
    partial class Мебель: Товар
    {
        public override string ToString()
        {
            string str = "";
            Console.WriteLine("Тип объекта 'Мебель'");
            Console.WriteLine($"Информация о: {name} \n Количество = {amount} \n Производитель = {producer} \n Цена = {price}");
            return str;
        }
    }
    class Диван: Мебель
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
                    price = 23654/amount;
            }
            Console.WriteLine("Нахождение цены ");
            Console.WriteLine($"Цена {name} : {price}");
        }

    }
    class Кровать: Мебель
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

    struct товар
    {
        public string name;
        public int price;

        public void Info()
        {
            Console.WriteLine("Купить товар " + name + " по цене " + price);
        }
    }
    enum производитель
    {
        IKEA = 1,
        JYSK,
        MILE
    }

    public class Контроллер
    {
        public int i = 0;
        public int ind;

        public Товар[] Arr = new Товар[10];
        public Товар dd;

        public void showcreator()
        {

            Console.Write("Введите название производителя:");
            string a = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < ind; i++)
            {
                if (Arr[i].producer == a)
                {
                    Console.WriteLine($" Мебель: {Arr[i].name} Производитель: {Arr[i].producer}");
                }
            }
        }

    }

    

    public class Склад: Контроллер
    {
        
        public Склад() { }
        public Товар arr
        {
            get
            {
                return Arr[i];

            }
            set
            {

                Arr[i] = dd;
            }
        }

        public void add(Товар ob)
        {
            Arr[i] = ob;
            i++;
        }
        public void delete()
        {
            i--;
            Arr[i] = null;
            Console.WriteLine("Товар удален");

        }
        public void show()
        {
            ind = i;

            for (int i = 0; i < ind; i++)
                Console.WriteLine((Arr[i]).ToString());
        }
       
        int p;
        public void price()
        {
            p = 0;
            ind = i;
            for (int i = 0; i < ind; i++)
            {
                if (Arr[i].name == "Диван")
                    p += Arr[i].price;
            }

            Console.WriteLine($"Общая стоимость диванов = {p}");
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Мебель E = new Диван();
                E.InputInformation();
                E.FindingPrice();
            }
            catch (CountIsZeroException e)
            {
                Console.WriteLine("CountIsZeroException: {0}", e.Message);
            }
            ///////////////////////////////////////////////////////////////////////
            try
            {
                Мебель C = new Диван();
                C.InputInformation();
            }
            catch (WrongValue e)
            {
                Console.WriteLine("WrongValue: {0}", e.Message);
            }
            ///////////////////////////////////////////////////////////////////////
            try
            {
                Мебель D = new Диван();
                D.InputInformation();
            }
            catch (WrongAmount e)
            {
                Console.WriteLine("WrongAmount: {0}", e.Message);
            }
            ////////////////////////////////////////////////////////////////////////
            try
            {
                Мебель F = new Кровать();
                F.InputInformation();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены неверные данные");
            }
            ////////////////////////////////////////////////////////////////////////
            try
            {
                Товар A = new Мебель();
                A.InputInformation();
                Мебель B = new Кровать();
                B.InputInformation();
                Товар[] Arr = new Товар[3];
                Arr[0] = A;
                Arr[1] = B;
                Printer pr = new Printer();
                Arr[5] = pr;
                pr.iAmPrinting(Arr[0]);
                pr.iAmPrinting(Arr[1]);
                pr.iAmPrinting(Arr[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            //Товар A = new Мебель();
            //Boolean result = A is Мебель; //is
            //Console.WriteLine(result);
            //A.InputInformation();
            //A.FindingPrice();
            //A.ShowInformation();
            //A.ToString();
            //Console.WriteLine();
            //Мебель C = new Диван();
            //C.InputInformation();
            //C.FindingPrice();
            //C.ShowInformation();
            //Console.WriteLine();
            //Мебель B = new Кровать();
            //B.InputInformation();
            //B.FindingPrice();
            //B.ShowInformation();
            //Console.WriteLine();
            //Мебель D = new Диван();
            //D.InputInformation();
            //D.FindingPrice();
            //D.ShowInformation();
            //Console.WriteLine();

            ////Товар[] Arr = new Товар[3];
            ////Arr[0] = A;
            ////Arr[1] = B;
            ////Printer pr = new Printer();
            ////Arr[2] = pr;
            ////pr.iAmPrinting(Arr[0]);
            ////pr.iAmPrinting(Arr[1]);
            ////pr.iAmPrinting(Arr[2]);

            //////структура и перечисление
            ////товар товар;
            ////товар.name = "Стол";
            ////товар.price = 1500;
            ////товар.Info();
            ////производитель creator;
            ////creator = производитель.IKEA;
            ////Console.WriteLine(creator);

            ////контейнер
            //Склад sklad = new Склад();
            //sklad.add(A);
            //sklad.delete();
            //sklad.add(C);
            //sklad.add(D);
            //sklad.show();
            //sklad.price();
            //sklad.showcreator();
        }
    }
}
