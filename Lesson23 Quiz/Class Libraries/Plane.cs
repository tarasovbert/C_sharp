using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Libraries
{
    public delegate void EventHandler(EventArgs args);
    public class Plane
    {
        public List<Dispatcher> dispatchers = new List<Dispatcher>(0);
        public int Velocity { get; set; }
        public int Height { get; set; }
        public int DistanceLeft { get; set; }
        private int initialDistance;
        public int MinDispatcherQuantity { get; private set; }
        public int DispatchersQuantity { get { return dispatchers.Count; } }
        private StringBuilder innerMessage = new StringBuilder();
        public EventHandler SomeEvent;

        #region CTORS        
        /// <summary>
        /// int distance is the distance to the point of destination,
        /// minimal quantity of dispatchers that are necessary for plane to fly is 2 by default
        /// </summary>
        /// <param name="min"></param>
        public Plane(int distance)
        {
            MinDispatcherQuantity = 2;
            DistanceLeft = distance;
            initialDistance = distance;
        }

        /// <summary>
        /// int min is the minimal quantity of dispatchers that are necessary for plane to fly, 
        /// int distance is the distance to the point of destination
        /// </summary>
        /// <param name="min"></param>
        public Plane(int min, int distance)
        {
            MinDispatcherQuantity = min;
            DistanceLeft = distance;
            initialDistance = distance;
        }
        #endregion

        public void Fly(int velocityDelta, int heightDelta)
        {
            innerMessage.Clear();
            Velocity += velocityDelta;
            Height += heightDelta;
            DistanceLeft -= Velocity;
            if (DistanceLeft != initialDistance)
            {
                for (int i = 0; i < dispatchers.Count; i++)
                {
                    innerMessage.Append(dispatchers[i].FlightGuidance(Velocity, Height, DistanceLeft));
                }
                OnSomeEvent(innerMessage.ToString());
            }
        }

        private void OnSomeEvent(string message)
        {
            MessageEventArgs args = new MessageEventArgs()
            { Message = message };
            SomeEvent(args);
        }

        public void AddDispatcher(string name)
        {
            dispatchers.Add(new Dispatcher(name));
            OnSomeEvent(String.Format("Dispatcher with name \"{0}\" added successfully.", name));
        }

        public void deleteDispatcher(string name)
        {
            if (dispatchers.Count > MinDispatcherQuantity)
            {
                for (int i = 0; i < dispatchers.Count; i++)
                    if (dispatchers[i].Name == name)
                    {
                        dispatchers.Remove(dispatchers[i]);
                        OnSomeEvent(String.Format("Dispatcher with name \"{0}\" deleted successfully.", name));
                        return;
                    }
            OnSomeEvent(String.Format("There is no dispatcher with name \"{0}\" in connection.", name));
            }
            else OnSomeEvent(String.Format("You can't make the quantity of dispatchers lesser than {0}.", MinDispatcherQuantity));
        }

        public void deleteDispatcher(int number)
        {
            int index = number - 1;
            if (dispatchers.Count > MinDispatcherQuantity)
            {
                if (index >= 0 && index < dispatchers.Count)
                {
                    dispatchers.Remove(dispatchers[index]);
                    OnSomeEvent(String.Format("Dispatcher with index \"{0}\" deleted successfully.", index));
                    return;
                }
                OnSomeEvent(String.Format("There is no dispatcher with index\"{0}\" in connection.", index));
            }
            else OnSomeEvent(String.Format("You can't make the quantity of dispatchers lesser than {0}.", MinDispatcherQuantity));
        }
    }
}
