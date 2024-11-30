using System;

namespace Project10
{
    class Contractor
    {
        public string name;
        public int number;
        private DateTime startdate;
        public DateTime FirstDay => startdate;

        public Contractor (string name, int number, DateTime startdate)
        {
            this.name;
            this.number;
            this.startdate;
        }
        public DateTime DayOne => startdate;
        
        public string GetName() => name;
        public void SetName(string name) => this.name = name;

        public int GetNumber() => number;
        public void SetNumber(int number) => this.number = number;

        public DateTime GetStartDate() => this.startdate= startdate;
        
    }
}
