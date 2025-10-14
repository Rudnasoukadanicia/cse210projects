using System;
using System.Globalization;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _minutes;

        protected Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public DateTime Date => _date;
        public int Minutes => _minutes;

        public abstract double GetDistance();
        public abstract double GetSpeed();  
        public abstract double GetPace();
       

        public virtual string GetSummary()
        {
            return string.Format(CultureInfo.InvariantCulture,
                "{0:dd MMM yyyy} {1} ({2} min) - Distance: {3:0.##} km, Speed: {4:0.##} kph, Pace: {5:0.##} min/km",
                _date, GetType().Name, _minutes, GetDistance(), GetSpeed(), GetPace());

        }
    }
}