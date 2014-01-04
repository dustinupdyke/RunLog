using System;
using System.Web.Mvc;
using RunLog.Domain;

namespace RunLog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index(int? weeks, DateTime? startDate)
        {
            if (!weeks.HasValue)
                weeks = 1;
            if (!startDate.HasValue)
                startDate = DateTime.Now;

            var plan = new RunPlan();

            for (var t = 1; t <= weeks; t++)
            {
                var week = new Week();

                week.WeekNumber = t;
                week.RunDifficulty = Week.Difficulty.Easy;

                var date = startDate.Value;
                var target = 26.2;

                for (var i = 0; i < 7; i++)
                {
                    var day = new Day();
                    day.Date = date;
                    day.DayOfWeek = date.DayOfWeek;
                    day.Target = target;
                    day.Distance = target;
                    day.Temp = target;
                    day.Time = new TimeSpan(3, 52, 3);

                    date = date.AddDays(1);
                    target++;
                    week.Days.Add(day);
                }

                plan.Weeks.Add(week);
            }

            return View(plan);
        }
    }
}