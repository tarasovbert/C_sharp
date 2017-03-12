using System;
using Info_Carriers;

namespace Reserve_Copy
{
   static class Copyist
    {
        internal static void CopyDataOnDevices(Storage[] devices, DataToCopy Data)
        {
            int filesCopied;
            double volumeCopied;
            int deviceNumber = 0;
            TimeSpan time;
            TimeSpan totalTime = new TimeSpan();
            foreach (Storage obj in devices)
            {
                deviceNumber++;
                try
                {
                    Console.WriteLine("{0}Device #{1}{0}{2}", Environment.NewLine, deviceNumber, obj.ToString());
                    time = obj.CopyData(Data, out filesCopied, out volumeCopied);
                    totalTime += time;
                    Console.WriteLine("Copying took {0:hh\\:mm\\:ss} (hours:minutes:seconds).", time);
                    Console.WriteLine("{1:f3} GB copied in {2} files.{0}{3:f3} GB left free in the device.{0}{4:f3} GB left to copy in {5} files.",
                        Environment.NewLine, volumeCopied, filesCopied, obj.FreeVolume, Data.VolumeToCopy, Data.FilesToCopy);
                    if (Data.FilesToCopy == 0)
                    {
                        Console.WriteLine("Copying ends. It took {1:hh\\:mm\\:ss} (hours:minutes:seconds).{0}",
                           Environment.NewLine, totalTime);
                        break;
                    }
                    Console.WriteLine("You would need {1} more the same devices to copy the rest data.{0}",
                        Environment.NewLine, Math.Ceiling((double)(Data.FilesToCopy / filesCopied)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
