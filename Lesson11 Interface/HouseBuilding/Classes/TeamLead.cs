namespace HouseBuilding
{
    public class TeamLead : IWorker
    {
        public string Name { get; set; } = "TeamLead";
        
        public string Work(House BuildingHouse)
        {
           return BuildingHouse.ToString();
        }
    }
}
