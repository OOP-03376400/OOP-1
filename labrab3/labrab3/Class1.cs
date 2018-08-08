using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labrab3
{
    public partial class Set
    {
        public int[] massif = new int[maxsize];
        static int maxsize = 30;
        public int size;
        public static int st = 0;

        public Set() //без параметров
        {
            size = 0;
            ++st;
        }

        public Set(int[] massif, int size) //с параметрами
        {
            this.massif = massif;
            this.size = size;
            ++st;
            inf();
        }

        public Set(int size = 0) //с параметром по умолчанию
        {
            this.size = size;
            ++st;
        }

        static Set() //статический конструктор (вызывается автоматически перед созданием первого экземпляра)
                     //нельзя вызвать напрямую, выполняется один раз
        {

        }

        private Set(int[] massif) //Закрытый конструктор — это особый конструктор экземпляров. 
                                  //Обычно он используется в классах, содержащих только статические элементы.
                                  //Если в классе один или несколько закрытых конструкторов и ни одного открытого конструктора, 
                                  //то прочие классы (за исключением вложенных классов) не смогут создавать экземпляры этого класса. 
        {
            this.massif = massif;
        }

        public readonly int id = 23; //поле только для чтения

        const int constt = 160298; //поле- константа

        public int SetGet //объявление свойства
        {
            get // аксессор чтения поля
            {
                return massif[size];
            }
            set // аксессор записи в поле
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

        public int Get //ограничение по set
        {
            get
            {
                return massif[size];
            }
        }

        public void sqr(ref int a) //вызов по ссылке для нессылочных типов
        {
            a = a * a;
        }

        public void sum (int b, out int m) //обязательно присвоить значение. исп для передачи значения из метода
        {
            int c = b + 1;
            m = c;
        }

       
        public void inf()
        {
            Console.WriteLine("В классе содержится " + st + " объектов");
        }

        public override bool Equals(Object obj)
        {
            bool result = false;
            if (obj == null || !(obj is Set))
                return false;
            else
                if (size == ((Set)obj).size)
            {
                for (int i = 0; i < size; i++)
                {
                    if (massif[i]== ((Set)obj).massif[i])
                    {
                        result = true;
                    }
                }
            }
            if (!result)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hash = 269;
            if (size == 0)
            {
                hash = 0;
            }
            else for (int i = 0; i < size; i++)
                {
                    hash = massif[i].GetHashCode();
                }
            hash = hash * 47;
            return hash;
        }


        public override string ToString()
        {
            string inf = "";
            for (int i = 0; i < size; i++)
            {
                inf = inf + massif[i].ToString() + " ";
            }
            return "Type " + base.ToString() + " Множество: " + inf;
        }
    }

}

