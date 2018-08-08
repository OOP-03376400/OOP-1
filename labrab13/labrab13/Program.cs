using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace labrab13
{
    class Program
    {
        static void Main(string[] args)
        {
            DMMLog log = new DMMLog();
            log.creatFIle();
            DMMDiskInfo disk = new DMMDiskInfo();
            disk.freememory();
            disk.filesysteminfo();
            disk.disksinfo();
            DMMFileInfo file = new DMMFileInfo();
            file.Fullpath("D:\\Log.txt");
            file.Inffil();
            file.TimeFIllcreate();
            file.creatFIleClass("D:\\Log.txt");
            DMMDirInfo dir = new DMMDirInfo();
            dir.Pathdir("D:\\University\\ООТП");
            dir.Dirinf();
            dir.Creationtime();
            dir.Dircount();
            dir.Dirparent();
            file.creatFIleClass("D:\\University\\ООТП");
            DMMFileManager fm = new DMMFileManager();
            fm.First();
            fm.second();
            fm.third();
            file.creatFIleClass("D:\\DMMInspect");

        }
    }
}
