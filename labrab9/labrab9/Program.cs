using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab9
{

    class Program
    {
        static void Main(string[] args)
        {
            Director U1 = new Director("Токари");
            Зарплата P = new Зарплата();
            U1.info();
            U1.Повысить += new Директор(P.SobitieA);
            U1.Повысить += new Директор(P.SobitieA);
            U1.Повысить += new Директор(P.SobitieA);
            U1.Штраф += new Директор(P.SobitieB);
            U1.Повышение();
            U1.Оштрафовать();
            U1.info();
            Director U2 = new Director("Студенты-заочники");
            Зарплата S = new Зарплата();
            U2.info();
            U2.Повысить += new Директор(S.SobitieA);
            U2.Оштрафовать();
            U2.Повышение();
            U2.info();


            Action<string> operation;
            operation = Add;
            Console.WriteLine("Ведите строку: ");
            string strr = Console.ReadLine();
            //Operation1(ref strr, operation);
            //Operation2(ref strr, operation);
            //Operation3(ref strr, operation);
            //Operation4(ref strr, operation);
            ChangeString(ref strr, operation);

        }

        static void ChangeString(ref string a, Action<string> op)
        {
            Operation1(ref a, op);
            Operation2(ref a, op);
            Operation3(ref a, op);
            Operation4(ref a, op);
        }
        static void Operation1(ref string str, Action<string> op)
            {
                Console.WriteLine("Начало операции над строкой: Удаление знаков припенания.");
                int size = str.Length;
                for (int i = 0; i < size; i++)
                {
                    if (str[i] == '.' || str[i] == ',' || str[i] == '!' || str[i] == '?')
                    {
                        str = str.Remove(i, 1);
                        size--;
                        i--;
                    }

                }
                op(str);
            }
            static void Operation2(ref string str, Action<string> op)
            {
                Console.WriteLine("Начало операции над строкой: Добавление сиволов.");
                string a = Console.ReadLine();
                str = str + a;
                op(str);
            }
            static void Operation3(ref string str, Action<string> op)
            {
                Console.WriteLine("Начало операции над строкой: Удаление прабелов.");
                int size = str.Length;
                for (int i = 0; i < size; i++)
                {
                    if (str[i] == ' ')
                    {
                        str = str.Remove(i, 1);
                        size--;
                        i--;
                    }

                }
                op(str);
            }
            static void Operation4(ref string str, Action<string> op)
            {
                Console.WriteLine("Начало операции над строкой: Замена на заглавные.");
                str = str.ToUpper();
                op(str);
            }
            static void Add(string str)
            {
                Console.WriteLine($"Результат :{str}");
            }

        }
    }

