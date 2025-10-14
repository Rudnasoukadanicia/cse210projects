using System;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps;

        
        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public int Laps => _laps;

        public override double GetDistance()
        {
            return _laps *  50 / 1000.0;    // Convert meters to kilometers
        }

        public override double GetSpeed()
        {
            double distance = GetDistance();

            return distance == 0 ? 0 : (distance / Minutes) * 60.0;
        }
        public override double GetPace()
        {
            double distance = GetDistance();
            
            return distance == 0 ? 0 : Minutes / distance;
        }
    }
}