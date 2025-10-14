using System;

namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double _speedKph;

        public Cycling(DateTime date, int minutes, double speedKph) : base(date, minutes)
        {
            _speedKph = speedKph;
        }

        public double SpeedKph => _speedKph;

        public override double GetDistance()
        {
            return _speedKph * Minutes / 60.0;
        }

        public override double GetSpeed()
        {
            return _speedKph;
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance == 0 ? 0 : Minutes / distance;
        }
    }
}