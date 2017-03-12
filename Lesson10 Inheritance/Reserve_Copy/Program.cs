using System;
using Info_Carriers;

namespace Reserve_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash1 = new Flash("Apacer", 2);
            DVD_plus_RW dvd1 = new DVD_plus_RW("NoName", "single");
            HDD_portable hdd1 = new HDD_portable("SmartBy", 32, 12);
            Storage[] devices = {new Flash("Silicon Power", 8), new Flash("Transcend", 16), flash1,
                new DVD_plus_RW("Verbatim", "single"), new DVD_plus_RW("Memorex", "DuaL"), dvd1,
                new HDD_portable("Kingston", 128, 4), new HDD_portable("Sundisk", 24.2, 10.2, 12.0),
                hdd1, new HDD_portable("Western Digital", 512, 10), new HDD_portable("Toshiba", 1024, 25)};

            DataToCopy Data = new DataToCopy();
            Console.Write("Copying starts.{0}{1:f3} GB to copy in {2} files.{0}",
                Environment.NewLine, Data.VolumeToCopy, Data.FilesToCopy);
            Console.WriteLine("Total memory of all devices you are have in disposal: {1} GB.{0}", Environment.NewLine, Storage.TotalMemory(devices));
            Copyist.CopyDataOnDevices(devices, Data);
        }       
    }
}
