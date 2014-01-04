using System;

namespace RunLog.Domain
{
    public class Day
    {
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime Date { get; set; }
        public double Target { get; set; }
        public double Distance { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan Pace { get { return new TimeSpan(0, 0, (int)(this.Time.TotalSeconds / this.Distance)); } }
        public double Mph { get { return (this.Distance / this.Time.TotalHours); } }
        public double Temp { get; set; }
        public string Shoes { get; set; }
        public string RunType { get; set; }
        public string Route { get; set; }
        public string Comments { get; set; }
    }
}