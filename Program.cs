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

            Building EmpirorState = new Building("2014 10th Avenue");
            FiveOneTwoEigth.Depth = 30000.90;
            FiveOneTwoEigth.Width = 100.90;
            FiveOneTwoEigth.Stories =100;
            FiveOneTwoEigth.Purchase("Vipul Parimal");

            // List<Building> VirtualCity = new List<Building>();
            // VirtualCity.Add(FiveOneTwoEigth);
            // VirtualCity.Add(EmpirorState);

            City megalopolis = new City("Megalopolis");
            megalopolis.addNewBuilding(FiveOneTwoEigth);
            megalopolis.addNewBuilding(EmpirorState);
            megalopolis.NewMayor("Ken Moore");


            // Console.WriteLine($@"
            //     {megalopolis.getCityName()}
            //     ---------------------------------
            //     established in {megalopolis.getYearEstablished()}
            //     Mayor : {megalopolis.getMayor()}
            //     has following buildings ---
            // ");

            Console.WriteLine(megalopolis);
            // foreach (Building building in megalopolis.Buildings)
            // {
            //     Console.WriteLine($@"
            //         {building.getAddress()}
            //         ----------------------------------------------
            //         Designed By : {building.getDesigner()}
            //         Constructed on {building.getDateConstructed()}
            //         Owned by {building.getOwner()}
            //         {building.Volume} cubic meters of space
            //      ");
            // }

        }
    }
}
