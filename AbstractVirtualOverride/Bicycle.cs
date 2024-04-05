using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVirtualOverride
{
    public class Bicycle : Vehicle
    {
        private string _type;
        public string Type { get { return _type; } set
            { if (!string.IsNullOrEmpty(value))
                    _type = value;}  
        }
        public Bicycle(string factoryName, string model, string color, double driveTime, double drivePath, string type) : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
        }
        public override void DefineNatureHarmness()
        {
            Console.WriteLine("not motor => none");
        }
        public override void GetInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName}, Model: {Model}, Color: {Color}, " +
                $"Drive Time: {DriveTime}, Drive Path: {DrivePath}, Type: {Type}");

        }

      
    }
}
