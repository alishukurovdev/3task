using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVirtualOverride
{
    public class 
        Car : Vehicle
    {
        private int _doorCount;
        private bool _isElctricCar;
        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value > 0)
                {
                    _doorCount = value;
                }
            }
        }
        public bool IsElctricCar { get
            { return _isElctricCar; }set
            { _isElctricCar = value ;  } }
        public Car(string factoryName, string model, string color, double driveTime, double drivePath, int doorCount, bool isElctricCar) : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;
            this.IsElctricCar= isElctricCar;
        }
        public override void DefineNatureHarmness()
        {
            if(_isElctricCar)
            {
                Console.WriteLine("Use benzin  => high ");
            }else
            {
                Console.WriteLine("Use electirc => low");
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName}, Model: {Model}, Color: {Color}, " +
                $"Drive Time: {DriveTime}, Drive Path: {DrivePath}, Door Count: {DoorCount}, Elctric Car {IsElctricCar}");

        }

    }
}
