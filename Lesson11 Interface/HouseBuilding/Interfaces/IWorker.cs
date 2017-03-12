namespace HouseBuilding
{
    interface IWorker
    {
        string Name { get; set; }
        string Work(House BuildingHouse);        
    }
}
