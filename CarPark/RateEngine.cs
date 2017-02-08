using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    /// <summary>
    /// Engine for calculating amount owed for stays at the carpark.
    /// </summary>
    public static class RateEngine
    {
        /// <summary>
        /// Given an entry and exit datetime, return the total amount owed.
        /// </summary>
        /// <param name="entryTime"></param>
        /// <param name="exitTime"></param>
        /// <returns></returns>
        public static RateData CalculateRate(DateTime entryTime, DateTime exitTime)
        {
            var data = new RateData(entryTime, exitTime);
            //  Flat rate definitions (assume between is inclusive of edge minutes)
            //  Early Bird - enter between 6:00AM and 9:00AM, exit between 3:30PM and 11:30PM (same day) - $13.00
            //  Night Rate - enter between 6:00PM to 12:00(midnight) weekdays, exit before 6:00AM following day - $6.50
            //  Weekend Rate - enter past midnight friday to sunday, exit before midnight sunday - $10.00
            //      Note - If a patron enters the carpark before midnight on Friday and if they qualify for Night rate on a Saturday morning, 
            //             then the program should charge the night rate instead of weekend rate.
            //  Default rate - 0-1 hours = $5.00, 1-2 hours = $10.00, 2-3 hours = $15.00, 3+ hours = $20.00 flat rate per day for each day
            if(exitTime < entryTime)
            {
                data.RateType = "No Charge";
                data.Amount = 0;
            }
            else if (entryTime.Date.Equals(exitTime.Date) &&
                ((entryTime.Hour >= 6 && entryTime.Hour < 9 || (entryTime.Hour == 9 && entryTime.Minute == 0)) &&
                ((exitTime.Hour == 15 && exitTime.Minute >= 30) || exitTime.Hour >= 16) && (exitTime.Hour < 23 || (exitTime.Hour == 23 && exitTime.Minute <= 30))))
            {
                data.RateType = "Early Bird";
                data.Amount = 13.00M;
            }
            else if(isWeekDay(entryTime.DayOfWeek) && (entryTime.Hour >= 18 && entryTime.Hour < 24) &&
                (exitTime < entryTime.Date.AddDays(1).AddHours(6)))
            {
                data.RateType = "Night Rate";
                data.Amount = 6.50M;
            }
            //  If enter at exactly midnight
            else if (entryTime.DayOfWeek == DayOfWeek.Saturday && (entryTime.Hour == 0 && entryTime.Minute == 0) &&
                (exitTime < entryTime.Date.AddHours(6)))
            {
                data.RateType = "Night Rate";
                data.Amount = 6.50M;
            }
            //  If exiting sunday before midnight, and entered after midnight the previous friday (beginning of saturday, or sunday minus 1 day)
            else if(exitTime.DayOfWeek == DayOfWeek.Sunday && exitTime.Hour < 24 && entryTime >= exitTime.Date.AddDays(-1).AddMinutes(1))
            {
                data.RateType = "Weekend Rate";
                data.Amount = 10.00M;
            }
            else
            {
                data.RateType = "Standard Rate";
                var totalHours = exitTime.Subtract(entryTime).TotalHours;
                if(totalHours < 1.0)
                {
                    data.Amount = 5.00M;
                }
                else if(totalHours < 2.0)
                {
                    data.Amount = 10.00M;
                }
                else if(totalHours < 3.0)
                {
                    data.Amount = 15.00M;
                }
                else
                {
                    data.Days = Convert.ToInt32(exitTime.Date.Subtract(entryTime.Date).TotalDays) + 1;
                    data.Amount = Convert.ToDecimal(data.Days * 20.00);
                }
            }
            return data;
        }
        private static bool isWeekDay(DayOfWeek dow)
        {
            return !(dow == DayOfWeek.Saturday || dow == DayOfWeek.Sunday);
        }
    }
    public class RateData
    {
        public readonly DateTime EntryTime;
        public readonly DateTime ExitTime;
        public decimal Amount;      // Used decimal (instead of double) as money in sqlserver is a decimal type.
        public string RateType;
        public int Days;
        public RateData(DateTime entryTime, DateTime exitTime)
        {
            this.EntryTime = entryTime;
            this.ExitTime = exitTime;
        }
    }
}
