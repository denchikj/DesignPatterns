using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentBuilder.Interfaces
{
    public interface ICar
    {
        string Brand { get; set; }
        string Model { get; set; }
        int EngineVolume { get; set; }
        int YearProduced { get; set; }
    }
}
