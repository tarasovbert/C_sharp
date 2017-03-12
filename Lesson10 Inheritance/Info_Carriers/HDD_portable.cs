using System;

namespace Info_Carriers
{
    public class HDD_portable : Storage
    {
        #region FIELDS
        double[] partitionsVolumes;
        double speed = 0.48 / 8; // 480 MBits per second for USB 2.0
        #endregion

        #region PROPERTIES
        public override double FreeVolume { get; set; }
        public override double Volume { get; set; }
        public int PartitionsQuantity { get; set; }
        #endregion

        #region CTORS
        /// <summary>
        /// Ctor of object of HDD_portable.
        /// double volume is volume of device.
        /// int partitionsQuantity is the quantity of partittions of the equal volume.
        /// string model is the model of device.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="partitionsQuantity"></param>
        public HDD_portable(string model, double volume, int partitionsQuantity)
        {
            if (volume <= 0)
                throw new DevicesException("The device's volume must be greater than zero!");
            if (partitionsQuantity <= 0)
                throw new IndexOutOfRangeException("The quantity of partitions is always greater than zero!");
            Model = model;
            Type = "Portable HDD";
            Volume = volume;
            FreeVolume = Volume;
            PartitionsQuantity = partitionsQuantity;
            partitionsVolumes = new double[PartitionsQuantity];
            for (int i = 0; i < partitionsVolumes.Length; i++)
                partitionsVolumes[i] = Volume / PartitionsQuantity;
        }

        /// <summary>
        /// Ctor of object of class HDD_portable          
        ///  double[] partitionVolumes is the array of volumes of each partition
        ///  string model is the model of device.
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="partitionsVolumes"></param>
        public HDD_portable(string model, params double[] partitionsVolumes)
        {
            Model = model;
            Type = "Portable HDD";
            PartitionsQuantity = partitionsVolumes.Length;
            this.partitionsVolumes = new double[PartitionsQuantity];
            Array.Copy(partitionsVolumes, this.partitionsVolumes, PartitionsQuantity);
            for (int i = 0; i < PartitionsQuantity; i++)
                Volume += partitionsVolumes[i];
            if (Volume <= 0)
                throw new DevicesException("The device's volume must be greater than zero!");
            FreeVolume = Volume;
        }
        #endregion

        #region METHODS
        public override TimeSpan CopyData(DataToCopy Data, out int filesCopied, out double volumeCopied)
        {
            filesCopied = 0;
            volumeCopied = 0;
            for (int i = 0; i < PartitionsQuantity; i++)
            {
                while (FreeVolume >= Data.FileVolume && Data.FilesToCopy > 0)
                {                   
                    FreeVolume -= Data.FileVolume;
                    Data.FilesToCopy--;
                    filesCopied++;
                    Data.VolumeToCopy -= Data.FileVolume;
                    volumeCopied += Data.FileVolume;                                  
                }
            }
            return TimeSpan.FromSeconds(volumeCopied / speed);
        }

        public override string ToString()
        {
            return String.Format("Type of information carrier: {1}.{0}Model: {2}.{0}Volume: {3} GB.{0}Quantity of partitions: {4}.{0}Free volume: {5:f3} GB.{0}Speed: {6} GBits per second.{0}",
                 Environment.NewLine, Type, Model, Volume, PartitionsQuantity, FreeVolume, speed * 8);
        }
        #endregion

    }
}
