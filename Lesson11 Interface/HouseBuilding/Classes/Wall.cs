namespace HouseBuilding
{
    public class Wall : IPart
    {
        public bool Constructed { get; set; }
        public string Name { get; set; } = "Wall";
    }
}
