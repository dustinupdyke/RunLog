using System;
using System.Collections.Generic;
using System.Linq;

namespace RunLog.Domain
{
    public class RunPlan
    {
        public List<Week> Weeks { get; set; }
        public int WeekCount { get; set; }
        public int StartDate { get; set; }

        public RunPlan()
        {
            this.Weeks = new List<Week>();
        }

        public double Target
        {
            get
            {
                return this.Weeks.Sum(day => day.Target);
            }
        }

        public double Distance
        {
            get
            {
                return this.Weeks.Sum(day => day.Distance);
            }
        }

        public TimeSpan Time
        {
            get
            {
                return new TimeSpan(0, 0, (int)this.Weeks.Sum(day => day.Time.TotalSeconds));
            }
        }

        public TimeSpan Pace
        {
            get
            {
                return new TimeSpan(0, 0, (int)this.Weeks.Average(day => day.Pace.TotalSeconds));
            }
        }

        public double Mph
        {
            get
            {
                return this.Weeks.Average(day => day.Mph);
            }
        }

        public double Temp
        {
            get
            {
                return this.Weeks.Average(day => day.Temp);
            }
        }
    }
}