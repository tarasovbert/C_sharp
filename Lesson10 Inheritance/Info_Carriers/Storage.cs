using System;

namespace Info_Carriers
{
    abstract public class Storage
    {
        #region FIELDS
        string type;
        string model;
        #endregion

        #region PROPERTIES
        abstract public double Volume { get; set; }
        abstract public double FreeVolume { get; set; }
        public string Type { get; set; }        
        public string Model { get; set; }
        #endregion

        #region METHODS
        override abstract public string ToString();
        abstract public TimeSpan CopyData(DataToCopy Data, out int filesCopied, out double volumeCopied); 
        
        static public double TotalMemory(Storage[] devices)
        {
            double totalMemory = 0;
            foreach (Storage device in devices)
            {
                totalMemory += device.Volume;
            }
            return totalMemory;
        }
        #endregion

    }
}
