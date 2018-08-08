using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labrab13
{
    class DMMDiskInfo : DMMLog
    {
        DriveInfo[] di = DriveInfo.GetDrives();
        public void freememory()
        {
            string a;
            Console.WriteLine($"Введите имя диска (C:, D:, E:)");
            a = Console.ReadLine();
            Console.WriteLine($"Cвободном месте на диске {a}");
            if (a == "C:")
            {
                Console.WriteLine(di[0].Name);
                Console.WriteLine("Свободном месте на диске :" + di[0].AvailableFreeSpace / 1024 / 1024 + " Mb\n");
            }
            if (a == "D:")
            {
                Console.WriteLine(di[1].Name);
                Console.WriteLine("Свободном месте на диске :" + di[1].AvailableFreeSpace / 1024 / 1024 + " Mb\n");
            }
            if (a == "E:")
            {
                Console.WriteLine(di[2].Name);
                Console.WriteLine("Свободном месте на диске :" + di[2].AvailableFreeSpace / 1024 / 1024 + " Mb\n");
            }
        }
        public void filesysteminfo()
        {
            Console.WriteLine("Информация о Файловой системе:");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in di)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine(drive.Name + ": " + drive.DriveFormat);
                }
            }

        }
        public void disksinfo()
        {
            Console.WriteLine("\nИнформация о дисках:");
            foreach (DriveInfo drive in di)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine(drive.Name + ": " + "\nОбъем: " + drive.TotalSize / 1024 / 1024 + " Mb\n"
                    + "Доступный объем: " + drive.TotalFreeSpace / 1024 / 1024 + " Mb\n" +
                    "Метка тома: " + drive.VolumeLabel + "\n");
                }
            }
        }
    }
}
