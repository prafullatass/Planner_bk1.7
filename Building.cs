using System;

namespace Planner {
    class Building {
        private string _designer = "Prafullata Sonawane";
        private DateTime _dateConstructed  {get;set; }
        private string _address {get;set; }
        private string _owner {get;set; }
        public int Stories {get;set; }
        public double Width  {get;set; }
        public double Depth {get;set; }
        public double Volume  {
            get {
            return Width * Depth * 3 * Stories;
            }
        }

        //methods
        public Building (string address ){
            _address = address;
            _dateConstructed = DateTime.Now;
        }
        public void Purchase (string newOwner) {
            _owner = newOwner;
        }

        public string getAddress () {
            return _address;
        }

        public string getDesigner () {
            return _designer;
        }

        public string getOwner () {
            return _owner;
        }
        public DateTime getDateConstructed () {
            return _dateConstructed;
        }

        
    }
}