using System;
using System.Text;

namespace Class_Libraries
{
    public class Dispatcher
    {
        public string Name { get; set; }
        public int PenaltyPoints { get; set; } = 0;
        public int CorrectionByWeather { get; set; }
        private int recommendedHeight;
        StringBuilder guidance = new StringBuilder();

        public Dispatcher(string Name)
        {
            this.Name = Name;
            Random rndm = new Random();
            CorrectionByWeather = rndm.Next(-200, 200);
        }

        private int RecommendedHeigh(int velocity)
        {
            recommendedHeight = 7 * velocity - CorrectionByWeather;
            return recommendedHeight;
        }

        public string FlightGuidance(int velocity, int height, int distanceLeft)
        {
            guidance.Clear();
            guidance.Append(String.Format("Dispatcher \"{1}\" reports: {0}Recommended height is {2} meters.",
               Environment.NewLine, Name, RecommendedHeigh(velocity)));
            int deltaHeight = Math.Abs(height - recommendedHeight);
            if (300 <= deltaHeight && deltaHeight < 600)
            {
                PenaltyPoints += 25;
                guidance.Append("You got 25 penalty points!");
            }
            else if (600 <= deltaHeight && deltaHeight < 1000)
            {
                PenaltyPoints += 50;
                guidance.Append("You got 50 penalty points!");
            }
            if (PenaltyPoints >= 1000)
                throw new SomethingWrongException(String.Format("{0}Dispatcher \"{1}\" reports: {0}You collected more than 1000 penalty points! You are not fit for the pilot profession!",
                    Environment.NewLine, Name));
            if (velocity > 1000)
            {
                PenaltyPoints += 100;
                guidance.Append("You exceeding the maximal allowed velocity! Slow down immediately! You got 100 penalty points!");
            }
            else if ((distanceLeft != 0 && (velocity <= 0 || height <= 0)) || deltaHeight > 1000)
                throw new SomethingWrongException(String.Format("Dispatcher \"{1}\": The plane is crushed!{0}",
                    Environment.NewLine, Name));
            else if (distanceLeft < 0)
                throw new SomethingWrongException(String.Format("Dispatcher \"{1}\": You failed landing!{0}",
                    Environment.NewLine, Name));
            guidance.Append(String.Format("{0}", Environment.NewLine));
            return guidance.ToString();
        }
    }
}