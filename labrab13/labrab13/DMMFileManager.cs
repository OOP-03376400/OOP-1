using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace labrab13
{
    class DMMFileManager : DMMLog
    {
        static DirectoryInfo fin;
        string path;
        DirectoryInfo dirInfo;
        DirectoryInfo dirInfo1;
        string namedir = "D:\\DMMInspect";
        string namedir1 = "D:\\DMMFiles";
        FileStream fstream;
        public string[] str;
        public string[] str1;

        public void First()
        {
            FileInfo fileInfo = new FileInfo(namedir + "\\" + "DMMdirinfo.txt");
            dirInfo = new DirectoryInfo(namedir);
            dirInfo.Create();

            string a;
            Console.WriteLine($"Введите имя диска (C:\\, D:\\, E:\\)");
            a = Console.ReadLine();
            fin = new DirectoryInfo(a);

            using (FileStream fstream = new FileStream(namedir + "\\" + "DMMdirinfo.txt", FileMode.Create))
            {
                if (Directory.Exists(a))
                {
                    Console.WriteLine("Директории на диске: " + a);
                    string[] dirs = Directory.GetDirectories(a);
                    byte[] arrayy = Encoding.Default.GetBytes("Директории на диске: ");
                    fstream.Write(arrayy, 0, arrayy.Length);
                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s);
                        byte[] array = Encoding.Default.GetBytes(s + "\r\n");
                        fstream.Write(array, 0, array.Length);

                    }
                    Console.WriteLine("Файлы на диске: " + a);
                    string[] files = Directory.GetFiles(a);
                    byte[] arraay = Encoding.Default.GetBytes("Файлы на диске: ");
                    fstream.Write(arraay, 0, arraay.Length);
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                        byte[] array = Encoding.Default.GetBytes(s + "\r\n");
                        fstream.Write(array, 0, array.Length);
                    }

                }

            }
            fileInfo.CopyTo(namedir + "\\" + "DMMdirinfo1.txt", true);
            fileInfo.Delete();
        }

        public void second()
        {
            string a;
            string b;
            dirInfo = new DirectoryInfo(namedir1);
            dirInfo.Create();
            Console.WriteLine("Введите название директория: ");
            a = Console.ReadLine();
            DirectoryInfo dirInfoo = new DirectoryInfo(a);
            if (Directory.Exists(a))
            {
                Console.WriteLine("Введите расширение: ");
                b = Console.ReadLine();
                string[] files = Directory.GetFiles(a);
                foreach (string s in files)
                {
                    FileInfo fileInfo = new FileInfo(s);
                    if (fileInfo.Extension == b)
                    {
                        File.Copy(s, namedir1 + "\\" + new FileInfo(s).Name);
                    }
                }
                dirInfo.MoveTo("D:\\DMMInspect\\DMMFiles");
            }
            else { Console.WriteLine("Директория не существует."); }

        }

        public void third()
        {
            string one = "D:\\DMMInspect\\DMMFiles";
            string two = "D:\\DMMInspect\\DMMFiles.zip";
            string three = "D:\\DMMInspect";

            ZipFile.CreateFromDirectory(one, two);

            ZipFile.ExtractToDirectory(two, three);

        }
    }
}
