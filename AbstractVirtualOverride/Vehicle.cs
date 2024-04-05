using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVirtualOverride
{
    public abstract class Vehicle
    {
        private string _factoryName;
        private string _model;
        private string _color;
        private double _driveTime;
        private double _drivePath;

        public string FactoryName { get { return _factoryName;  } set {
                if (!string.IsNullOrEmpty(value))
                    _factoryName = value;
            } }
        public string Model { get { return _model; } set {
                if (!string.IsNullOrEmpty(value))
                    _model = value;
            } }
        public string Color { get {
                return _color; }
            set { if (!string.IsNullOrEmpty(value))
                    _color = value;
            } }
        public double DriveTime
        {
            get { return _driveTime; }
            set
            {
                if (value >= 0)
                    _driveTime = value;
            }
        }
        public double DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value >= 0)
                    _drivePath = value;
            }
        }

        public Vehicle(string factoryName, string model, string color, double driveTime, double drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;

                
        }
        public abstract void DefineNatureHarmness();
        public override string ToString()
        {
            return ($"{FactoryName} {Model}");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName}, Model: {Model}, Color: {Color}, Drive Time: {DriveTime}, Drive Path: {DrivePath}");
        }
        public virtual double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}