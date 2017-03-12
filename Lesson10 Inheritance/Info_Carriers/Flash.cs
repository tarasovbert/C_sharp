using System;

namespace Info_Carriers
{
    public class Flash : Storage
    {
        #region FIELDS
        double speed = 5 / 8.0;//5 GBits per second
        #endregion

        #region PROPERTIES
        public override double Volume { get; set; }
        public override double FreeVolume { get; set; }
        #endregion

        #region CTORS
        /// <summary>
        /// Ctor of object of class Flash.
        ///   string model: name of model.
        ///   int volume: volume of memory in GB.
        /// </summary>
        /// <param name="model">Name of model</param>
        /// <param name="volume">Volume of memory in GB</param>
        public Flash(string model, double volume)
        {
            if (volume <= 0)
                throw new DevicesException("The device's volume must be greater than zero!");
            Volume = volume;
            FreeVolume = Volume;
            Type = "Flash";
            Model = model;
        }
        #endregion

        #region METHODS
        public override TimeSpan CopyData(DataToCopy Data, out int filesCopied, out double volumeCopied)
        {
            filesCopied = 0;
            volumeCopied = 0;
            while (FreeVolume >= Data.FileVolume && Data.FilesToCopy > 0)
            {            
                FreeVolume -= Data.FileVolume;
                Data.FilesToCopy--;
                filesCopied++;
                Data.VolumeToCopy -= Data.FileVolume;
                volumeCopied += Data.FileVolume;
            }
            return TimeSpan.FromSeconds(volumeCopied / speed);
        }

        override public string ToString()
        {
            return String.Format("Type of information carrier: {1}.{0}Model: {2}.{0}Volume: {3} GB.{0}Free volume: {4} GB.{0}Speed: {5:f3} GBits per second.{0}",
                 Environment.NewLine, Type, Model, Volume, FreeVolume, speed * 8);
        }
        #endregion

    }
}
