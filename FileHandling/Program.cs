using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //------Collecting Drive Info----------

            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine( "-----------------------------");
                Console.WriteLine("Drive Name:" +drive.Name);
                Console.WriteLine("Total Size:"+ drive.TotalSize);
                Console.WriteLine("Avilable Free Size:" + drive.AvailableFreeSpace);
                Console.WriteLine("Drive Condition :" + drive.IsReady);
                Console.WriteLine("Drive Type:" + drive.DriveType);
            }
        }
    }
}
