using System;
using System.Collections.Generic;
using System.Linq;

namespace RunLog.Domain
{
    public class Week
    {
        public enum Difficulty
        {
            Easy,
            Hard
        }

        public enum Shoe
        {
            Unknown,
            Newton,
            Salomon
        }

        public enum RunType
        {
            Normal,
            Hill,
            Hill_Repeat,
            Tempo
        }

        public List<Day> Days { get; set; }
        public int WeekNumber { get; set; }
        public Difficulty RunDifficulty { get; set; }
        
        public double Target
        {
            get
            {
                return this.Days.Sum(day => day.Target);
            }
        }
        
        public double Distance
        {
            get
            {
                return this.Days.Sum(day => day.Distance);
            }
        }
        
        public TimeSpan Time
        {
            get
            {
                return new TimeSpan(0, 0, (int)this.Days.Sum(day => day.Time.TotalSeconds));
            }
        }
        
        public TimeSpan Pace
        {
            get
            {
                return new TimeSpan(0, 0, (int)this.Days.Average(day => day.Pace.TotalSeconds));
            }
        }
        
        public double Mph
        {
            get
            {
                return this.Days.Average(day => day.Mph);
            }
        }
        
        public double Temp
        {
            get
            {
                return this.Days.Average(day => day.Temp);
            }
        }

        public Week()
        {
            this.Days = new List<Day>();
        }
    }
}