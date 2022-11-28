using Vehicle.Interfaces;

namespace Vehicle.Moduls
{
    internal class Car : Vehicle, IEngine
    {
        private byte _doorCount;

        public byte DoorCount 
        { 
            get=>_doorCount;
            set
            {
                if (value>0)
                {
                    _doorCount = value;
                }
            }
        }

        public Car(byte doorcount)
        {
            DoorCount = doorcount;
        }
        public double RemainOilAmount()
        {
            
        }
    }
}
