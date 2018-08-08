using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labrab13
{
    class DMMLog
    {
        public static string Path = @"D:\University\ООТП\labrab13\labrab13\DMMlogfile.txt";
        string name;
        public static string dateCreateFile;
        public System.IO.StreamWriter file;
        public FileInfo infF;
        public void creatFIle()
        {
            DateTime a = DateTime.Now;
            string arr = a.ToString();
            string text1 = arr;
            string name = "Имя файла: DMMlogfile.txt\r\n";
            string path = "Путь :D:\\University\\ООТП\\labrab13\\labrab13\\DMMlogfile.txt\r\n";
            using (FileStream fstream = new FileStream("D:\\University\\ООТП\\labrab13\\labrab13\\DMMlogfile.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(name);
                fstream.Write(array, 0, array.Length);
                fstream.Seek(0, SeekOrigin.End);
                byte[] array1 = System.Text.Encoding.Default.GetBytes(path);
                fstream.Write(array1, 0, array1.Length);
                fstream.Seek(0, SeekOrigin.End);
                byte[] array2 = System.Text.Encoding.Default.GetBytes("Дата создания: ");
                fstream.Write(array2, 0, array2.Length);
                fstream.Seek(0, SeekOrigin.End);
                byte[] array3 = System.Text.Encoding.Default.GetBytes(text1);
                fstream.Write(array3, 0, array3.Length);
                byte[] array4 = System.Text.Encoding.Default.GetBytes("\r\n");
                fstream.Write(array4, 0, array4.Length);

            }

        }
        public void creatFIleClass(string path)
        {
            using (FileStream fstream = new FileStream("D:\\University\\ООТП\\labrab13\\labrab13\\DMMlogfile.txt", FileMode.OpenOrCreate))
            {
                FileInfo dirInfo = new FileInfo(path);
                string name = $"\r\nНазвание файла: {dirInfo.Name}\r\n";
                string fullname = $"Полное название файла: {dirInfo.FullName}\r\n";
                string data = $"Время создания каталога: {dirInfo.CreationTime}\r\n";
                fstream.Seek(0, SeekOrigin.End);
                byte[] array = System.Text.Encoding.Default.GetBytes(name);
                fstream.Write(array, 0, array.Length);
                fstream.Seek(0, SeekOrigin.End);
                byte[] array1 = System.Text.Encoding.Default.GetBytes(fullname);
                fstream.Write(array1, 0, array1.Length);
                byte[] array2 = System.Text.Encoding.Default.GetBytes(data);
                fstream.Write(array2, 0, array2.Length);
            }

        }
    }
}
