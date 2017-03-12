using System;

namespace Info_Carriers
{
    //- класс DVD - диск: скорость чтения / записи, тип (односторонний (4.7 Гб) /двусторонний (9 Гб));
    public class DVD_plus_RW : Storage
    {
        #region FIELDS
        double speed = 0.01056;//8x speed = 10.56 MB per second     
        #endregion

        #region PROPERTIES
        public byte Sides { get; set; }
        public override double FreeVolume { get; set; }
        public override double Volume { get; set; }
        #endregion

        #region CTORS
        /// <summary>
        /// Ctor of DVD+RW object.
        /// string model is model of disc.
        /// string sized is "single" for single-sized discs and "dual" for dual-sized discs
        /// </summary>
        /// <param name="sized"></param>
        public DVD_plus_RW(string model, string sized)
        {
            sized = sized.ToLower();
            if (sized == "single")
            {
                Sides = 1;
                Volume = 4.7;
            }
            else if (sized == "dual")
            {
                Sides = 2;
                Volume = 4.7;
            }
            else throw new DevicesException("Incorrect output! A DVD+RW may only be single- or dual-sized!");
            FreeVolume = Volume;
            if (Sides == 1)
                Type = "DVD+RW, single-sided";
            else
                Type = "DVD+RW, dual-sided";
            Model = model;
        }
        #endregion

        #region METHODS
        public override TimeSpan CopyData(DataToCopy Data, out int filesCopied, out double volumeCopied)
        {
            filesCopied = 0;
            volumeCopied = 0;
            for (int i = 0; i < Sides; i++)
            {
                while (FreeVolume >= Data.FileVolume && Data.FilesToCopy > 0)
                {                    
                    FreeVolume -= Data.FileVolume;
                    Data.FilesToCopy--;
                    filesCopied++;
                    Data.VolumeToCopy -= Data.FileVolume;
                    volumeCopied += Data.FileVolume;
                }
                FreeVolume = Volume;
            }
            return TimeSpan.FromSeconds(volumeCopied / speed);
        }

        public override string ToString()
        {
            return String.Format("Type of information carrier: {1}.{0}Model: {2}.{0}Volume: {3} GB.{0}Free volume: {4} GB.{0}Speed: {5:f3} GBits per second.{0} ",
                 Environment.NewLine, Type, Model, Volume * Sides, FreeVolume * Sides, speed);
        }
        
        #endregion
    }
}
