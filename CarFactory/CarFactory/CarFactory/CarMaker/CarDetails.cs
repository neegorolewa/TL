using CarFactory.Models.BodyShapes;
using CarFactory.Models.Brands;
using CarFactory.Models.CarModels;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.SteeringPositions;
using CarFactory.Models.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.CarMaker
{

    public class CarDetails
    {
        public IBrand Brand { get; set; }
        public IModel Model { get; set; }
        public IBody Body { get; set; }
        public IColor Color { get; set; }
        public IEngine Engine { get; set; }
        public IPosition SteeringPosition { get; set; }
        public ITransmission Transmission { get; set; }
    }
}
