
using Vehicle.Interfaces;

namespace Vehicle.Moduls
{
    internal class Plane:Vehicle,IEngine
    {
        private double _wingLength;

        public double WingLength
        {
            get => _wingLength;
            set
            {
                if (value > 1)
                {
                    _wingLength = value;
                }
            }
        }

        public Plane(double wingLength)
        {
            WingLength = wingLength;
            
        }

        public double RemainOilAmount()
        {
            throw new NotImplementedException();
        }
    }
}
