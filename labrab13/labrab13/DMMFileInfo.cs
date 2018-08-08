using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labrab13
{
    class DMMFileInfo : DMMLog
    {
        FileInfo finf;
        public void Fullpath(string a)
        {
            finf = new FileInfo(a);
            Console.WriteLine("Полный путь :" + finf.DirectoryName + @"\" + finf.Name);

        }
        public void Inffil()
        {
            Console.Write($"Имя файла: {finf.Name}\nРазмер файла - " + finf.Length + ", ");
            Console.WriteLine("Расширение файла - " + finf.Extension);
        }
        public void TimeFIllcreate()
        {
            Console.WriteLine($"Время создания файла {finf.Name}: " + finf.CreationTime);
        }
    }
}
