using System;

namespace PropertyChangedNotification
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);
    class PhisycalObject : IPropertyChanged
    {
        public event PropertyEventHandler PropertyChanged;
        PropertyEventArgs args = new PropertyEventArgs();
        private double mass;
        private string type;

        public double Mass
        {
            get { return mass; }
            set
            {
                mass = value;
                args.Message = String.Format("Mass set to {0}.", value);
                EventOccured();
            }
        }


        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                args.Message = String.Format("Type set to \"{0}\".", value);
                EventOccured();
            }
        }

        protected virtual void EventOccured()
        {
            PropertyChanged?.Invoke(this, args);
        }
    }
}
