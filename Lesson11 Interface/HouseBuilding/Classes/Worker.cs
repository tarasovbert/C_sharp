using System;

namespace HouseBuilding
{
    class Worker : IWorker
    {
        public string Name { get; set; } = "Worker";

        public string Work(House BuildingHouse)
        {            
            for (int i = 0; i < BuildingHouse.Length; i++)
                for (int j = 0; j < BuildingHouse.GetLength(i); j++)
                    if (BuildingHouse[i, j] == false)
                    {                        
                        BuildingHouse[i, j] = true;
                        if (i == 4)
                        {
                            BuildingHouse.Constructed = true;
                            throw new OperationCanceledException(String.Format("The {1} built.{0}The house is built!{0}{0}", 
                                Environment.NewLine, BuildingHouse.GetName(i)));
                        }
                        if (BuildingHouse.GetLength(i) == 1)
                        return String.Format("The {1} built.{0}",Environment.NewLine, BuildingHouse.GetName(i));
                        else
                            return String.Format("The {1} #{2} built.{0}", Environment.NewLine, BuildingHouse.GetName(i), j + 1);
                    }            
            throw new OperationCanceledException(String.Format("The house is built!{0}", Environment.NewLine));            
        }        
    }
}
