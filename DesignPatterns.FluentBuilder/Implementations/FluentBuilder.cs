using DesignPatterns.FluentBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentBuilder.Implementations
{
    public class FluentBuilder : IFluentBuilder
    {
        private readonly ICar _car = new Car();
        public ICar ReturnCar()
        {
            return _car;
        }

        public IFluentBuilder SetBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public IFluentBuilder SetEngineVolume(int volume)
        {
            _car.EngineVolume = volume;
            return this;
        }

        public IFluentBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public IFluentBuilder SetYearProduced(int year)
        {
            _car.YearProduced = year;
            return this;
        }
    }
}
