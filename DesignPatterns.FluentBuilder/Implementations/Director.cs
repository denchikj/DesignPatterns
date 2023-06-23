using DesignPatterns.FluentBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentBuilder.Implementations
{
    public class Director : IDirector
    {
        private readonly IFluentBuilder _builder;

        public Director(IFluentBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.SetBrand("Mercedes")
                .SetModel("G63")
                .SetEngineVolume(4)
                .SetYearProduced(2022);
        }
    }
}
