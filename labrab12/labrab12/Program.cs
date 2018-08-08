using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;


namespace labrab12
{
    public class JustClass
    {
        public string a = "jh";
        public int b { get; set; }
        public JustClass()
        {

        }
        public void one(string a)
        {
            Console.WriteLine(a);
        }
        public void two(int b, int c)
        {
            Console.Write("Mul:");
            int f = b * c;
            Console.Write(f);
            Console.WriteLine();
        }
        public void three(int d, string e)
        {
            d = d * 12;
            Console.WriteLine(d);
            if (d < 0)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
    }
   


    public class Reflector<T>
    {
        string Infromation = "All information about class:\r\n";
        public void AllInformation(T a)
        {
            Type typeA = a.GetType();
            MemberInfo[] memberInfo = typeA.GetMembers();
            foreach (object objects in memberInfo)
            {
                Infromation += (objects.ToString() + "\r\n");
            }
            string AllInformation = Infromation;
            using (FileStream fstream = new FileStream("D:\\Class.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(AllInformation);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("File created.Information about class is written");
            }
        }
        public void InfoAboutMethod(T a)
        {
            Type typeA = a.GetType();
            foreach (MethodInfo objects in typeA.GetMethods())
            {
                Console.WriteLine(objects);
            }
        }
        public void InfoAboutFieldsProperties(T a)
        {
            Type typeA = a.GetType();
            foreach (FieldInfo objects in typeA.GetFields())
            {
                Console.WriteLine(objects);
            }
            foreach (PropertyInfo obj in typeA.GetProperties())
            {
                Console.WriteLine(obj);
            }
        }
        public void InfoAboutInterface(T a)
        {
            Type typeA = a.GetType();
            foreach (Type objects in typeA.GetInterfaces())
            {
                Console.WriteLine(objects);
            }
        }
        public void InfoAboutParameters(T a, string b)
        {
            Type typeA = a.GetType();
            MethodInfo[] methodInfo = typeA.GetMethods();
            foreach (MethodInfo objects in methodInfo)
            {
                ParameterInfo[] parameterInfo = objects.GetParameters();
                for (int i = 0; i < methodInfo.Length; i++)
                {
                    for (int j=0; j < parameterInfo.Length; j++)
                    {
                        if ((parameterInfo[j].ParameterType.Name) == b)
                        {
                            Console.WriteLine(methodInfo[i].Name); break;

                        }
                    }

                }
            }

        }

        public void CallMethod(T a, string meth)
        {
            int[] res = new int[10];
            string[] str = new string[10]; 
            object[] buf = new object[10];
            string[] stri = new string[10];
            stri[0] = null;
            stri[1] = null;
            int j = 0;
            int l = 0;
            string[] buff = new string[10];
            Type typeA = a.GetType();
            MethodInfo method = typeA.GetMethod(meth);
            ParameterInfo[] parameterInfo = method.GetParameters();

            using (StreamReader sr = new StreamReader("D:\\TestFile.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    str[j++] = line;
                }
            }
            int i = 0;
            for (int f = 0; f < j; f++)
            {

                buff[i] = str[f];
                if (Int32.TryParse(buff[i], out res[i]))
                {
                    buf[i] = res[i];
                }
                else stri[i] = buff[i];
                i++;
            }

            if (parameterInfo.Length == 1)
            {
                method.Invoke(a, new object[] { stri[0] });
            }
            {
                if (parameterInfo.Length == 2 && stri[1] == null)
                {
                    method.Invoke(a, new object[] { buf[0], buf[1] });
                }
                else method.Invoke(a, new object[] { buf[0], stri[1] });
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Reflector<JustClass> reflector1 = new Reflector<JustClass>();
            JustClass clas = new JustClass();
            reflector1.AllInformation(clas);
            Console.WriteLine();
            Console.WriteLine("Information about methods:");
            Reflector<JustClass> reflector2 = new Reflector<JustClass>();
            JustClass clas2 = new JustClass();
            reflector2.InfoAboutMethod(clas2);
            Console.WriteLine();
            Console.WriteLine("Information about fields and properties:");
            Reflector<JustClass> reflector3 = new Reflector<JustClass>();
            JustClass clas3 = new JustClass();
            reflector3.InfoAboutFieldsProperties(clas3);
            Console.WriteLine();
            Console.WriteLine("Information about interface:");
            Reflector<JustClass> reflector4 = new Reflector<JustClass>();
            JustClass clas4 = new JustClass();
            reflector4.InfoAboutInterface(clas4);
            Console.WriteLine();
            Console.WriteLine("Information about parameters:");
            Reflector<JustClass> reflector5 = new Reflector<JustClass>();
            JustClass clas5 = new JustClass();
            reflector5.InfoAboutParameters(clas5, "Object");
            Console.WriteLine();
            Console.WriteLine("Invoke method:");
            Reflector<JustClass> reflector6 = new Reflector<JustClass>();
            JustClass clas6 = new JustClass();
            reflector6.CallMethod(clas6, "two");
            //reflector6.CallMethod(clas6, "three");
        }
    }
}
