using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Depth = 3000.90;
            FiveOneTwoEigth.Width = 100.90;
            FiveOneTwoEigth.Stories =10;
            FiveOneTwoEigth.Purchase("Mira Sutar");

            List<Building> VirtualCity = new List<Building>();
            VirtualCity.Add(FiveOneTwoEigth);

            foreach (Building building in VirtualCity)
            {
                Console.WriteLine($@"
                    {building.getAddress()}
                    ----------------------------------------------
                    Designed By : {building.getDesigner()}
                    Constructed on {building.getDateConstructed()}
                    Owned by {building.getOwner()}
                    {building.Volume} cubic meters of space
                 ");
            }
        }
    }
}
