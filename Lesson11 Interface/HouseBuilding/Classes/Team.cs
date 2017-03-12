using System;
using System.Text;


namespace HouseBuilding
{
    public class Team
    {
        IWorker[] BuildersTeam { get; set; }

        public Team(int workersQuantity)
        {
            if (workersQuantity <= 1)
                throw new IndexOutOfRangeException
                    ("It has to be at least two workers in team - one worker and one teamlead!");
            BuildersTeam = new IWorker[workersQuantity];
            int i = 0;
            while(i < workersQuantity - 1)
            {
                BuildersTeam[i++] = new Worker();
            }
            BuildersTeam[i] = new TeamLead();
        }

        public string Work(House BuildingHouse)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < BuildersTeam.Length; i++)
                try { sb.Append(String.Format(BuildersTeam[i].Work(BuildingHouse))); }
                catch (OperationCanceledException ex)
                {
                    sb.Append(String.Format(ex.Message));
                    BuildingHouse.Constructed = true;                                 
                    sb.Append(String.Format(BuildersTeam[BuildersTeam.Length - 1].Work(BuildingHouse)));
                    break;
                }
            return sb.ToString();          
        }
    }
}
