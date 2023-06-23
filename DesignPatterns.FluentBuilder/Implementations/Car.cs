using DesignPatterns.FluentBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentBuilder.Implementations
{
    public class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EngineVolume { get; set; }
        public int YearProduced { get; set; }
        public override string ToString()
        {
            return $"{Brand} - {Model} - Volume: {EngineVolume} - Year: {YearProduced}";
        }
    }
}
