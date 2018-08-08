using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labrab13
{
    class DMMDirInfo: DMMLog
    {
        static DirectoryInfo dinf;
        string path;

        public void Pathdir(string a)
        {
            path = a;
            dinf = new DirectoryInfo(path);

        }
        public void Dirinf()
        {
            int countfiles=0;
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                countfiles++;
            }
            Console.WriteLine("Количество файлов в директории {0}: {1}", dinf.Name, countfiles);
        }
        public void Creationtime()
        {
            Console.WriteLine($"Время создания директория  {dinf.Name}: " + dinf.CreationTime);
        }
        public void Dircount()
        {
            int countdir = 0;
            string[] files = Directory.GetDirectories(path);
            foreach (string s in files)
            {
                countdir++;
            }
            Console.WriteLine("Количество поддиректориев в директории {0}: {1}", dinf.Name, countdir);
        }
        public void Dirparent()
        {
            Console.WriteLine($"Родительский директорий директория: {dinf.Name}: " + dinf.Parent);
        }
    }
}
