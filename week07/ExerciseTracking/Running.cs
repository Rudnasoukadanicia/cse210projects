using System;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double _distanceKm;
        public Running(DateTime date, int minutes, double distanceKm) : base(date, minutes)
        {
            _distanceKm = distanceKm;
        }

        public double DistanceKm => _distanceKm;

        public override double GetDistance()
        {
            return DistanceKm;
        }

        public override double GetSpeed()
        {
            return (DistanceKm / Minutes) * 60.0;

        }

        public override double GetPace()
        {
            return Minutes / _distanceKm;
        }
    }
}