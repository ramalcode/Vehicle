
namespace Vehicle.Moduls
{
    internal abstract class Vehicle
    {
        private double _driveTime;
        private double _drivePath;

        private double _oilCapacity;
        private double _currentOil;

        public double DriveTime 
        { 
            get =>_driveTime;
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
            }
        }


        public double DrivePath
        {
            get => _drivePath;
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }

        public double AverageSpeed()
        {
            return (DrivePath / DriveTime);
        }
    }
}
