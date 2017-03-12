using System;
using System.Text;

namespace HouseBuilding
{
    public class House
    {
        IPart[][] Building;

        public int Length { get { return Building.Length; } }
        public bool Constructed { get; set; }
        public bool this[int i, int j]
        {
            get { return Building[i][j].Constructed; }
            set { Building[i][j].Constructed = value; }
        }

        public House()
        {
            Building = new IPart[5][];
            Building[0] = new Basement[1] { new Basement() };
            Building[1] = new Wall[4] { new Wall(), new Wall(), new Wall(), new Wall() };
            //for (int i = 0; i < 4; i++) Building[1][i] = new Wall(); // we also may initialize like this            
            Building[2] = new Door[1] { new Door() };
            Building[3] = new Window[4] { new Window(), new Window(), new Window(), new Window() };
            Building[4] = new Roof[1] { new Roof() };

        }

        public int GetLength(int i)
        {
            return Building[i].Length;
        }

        public string GetName(int i)
        {
            return Building[i][0].Name;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            for (int i = 0; i < Building.Length; i++)
            {
                info.Append(String.Format("{0,-8}: ", Building[i][0].Name));
                for (int j = 0; j < Building[i].Length; j++)
                {
                    if(Building[i][j].Constructed)
                    info.Append(String.Format("{0, -6}", "READY"));
                    else
                        info.Append(String.Format("{0, -6}", "-NOT-"));
                }
                info.Append(Environment.NewLine);
            }
            return info.ToString();
        }
    }
}
