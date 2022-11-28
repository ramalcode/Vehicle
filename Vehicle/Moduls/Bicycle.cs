
using Vehicle.Interfaces;

namespace Vehicle.Moduls
{
    internal class Bicycle:Vehicle,IEngine
    {
        private string _pedalKind;

        public string PedalKind
        {
            get => _pedalKind;
            set
            {
                if (value.Trim().Length > 3)
                {
                    _pedalKind = value;
                }
            }
        }

        public Bicycle(string pedalKind)
        {
            PedalKind = pedalKind;
        }

        public double RemainOilAmount()
        {
            throw new NotImplementedException();
        }
    }
}
