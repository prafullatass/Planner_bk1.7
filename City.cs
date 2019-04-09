using System;
using System.Collections.Generic;

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
    }
}