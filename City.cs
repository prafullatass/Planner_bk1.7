using System;
using System.Collections.Generic;
using System.Text;

namespace Planner {
    class City{
        private string _name {get;set;}
        private string _mayor  {get;set;}
        private int _yearEstablished {get;set;}
        public List<Building> Buildings = new List<Building>();
        public void addNewBuilding(Building newBuilding) {
            Buildings.Add(newBuilding);
        }
        public City ( string name){
            _name = name;
            _yearEstablished = DateTime.Now.Year;
        }
        public void NewMayor(string name) {
            _mayor = name;
        }
        public string getCityName(){
            return _name;
        }
        public string getMayor(){
            return _mayor;
        }
        public int getYearEstablished(){
            return _yearEstablished;
        }
        public override string ToString() {
            StringBuilder output  = new StringBuilder();
            output.Append($@"
            {_name}
            ---------------------------------
            established in {_yearEstablished}
             Mayor : {_mayor}
            has following buildings ---");
            //foreach (Building building in megalopolis.Buildings)
            Buildings.ForEach(building => output.Append(
                $@"
                    {building.getAddress()}
                    ----------------------------------------------
                    Designed By : {building.getDesigner()}
                    Constructed on {building.getDateConstructed()}
                    Owned by {building.getOwner()}
                    {building.Volume} cubic meters of space
                 ")
            );
            return output.ToString();
        }
    }
}