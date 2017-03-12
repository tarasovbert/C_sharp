namespace Info_Carriers
{
    public class DataToCopy
    {
        #region PROPERTIES
        public double VolumeToCopy { get; set; } = 565;
        public double FileVolume { get; set; } = 0.780;
        public int FilesToCopy { get; set; }
        #endregion

        #region CTORS
        public DataToCopy()
        {
            FilesToCopy = (int)(VolumeToCopy / FileVolume);
            VolumeToCopy = FilesToCopy * FileVolume; // correction
        }
        #endregion
    }
}
