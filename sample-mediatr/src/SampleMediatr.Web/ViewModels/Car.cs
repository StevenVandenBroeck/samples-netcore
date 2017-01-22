using System;

namespace Samples.ViewModels
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Car : Brand = {this.Brand ?? "null"}, Model = {this.Model ?? "null"}, Color = {this.Color ?? "null"}";
        }
    }
}
