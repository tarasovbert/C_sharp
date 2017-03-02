using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    
    internal class ParkCar //by default all classes have modyfier internal
    {
        string pathFile;
        //todo: make work with a file

        public ParkCar(string pathFile)
        {
            if (String.IsNullOrEmpty(pathFile))
                throw new ArgumentNullException("Incorrect path to file!");

            this.pathFile = pathFile;
        }
        public decimal GetPriceByName (string carName)
        {
            decimal priceCar;
            FileStream fs = null;
            try
            {
                fs = new FileStream(pathFile, FileMode.Open);
                priceCar = 5000;
            }
            catch (FileNotFoundException ex)
            {
               throw new ParkCarException(carName, ex);            
            }
            catch(IOException ex)
            {
                throw new ParkCarException(carName, ex);
            }
            finally
            {
                fs?.Close(); // the same as if (fs!=null) fs.Close - it's in C#6.0
            }

            return priceCar;

        }
    }
}
