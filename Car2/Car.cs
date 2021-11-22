using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    class Car
    {
        private int yearOfProduction;
        private int engineVolume;

        public int YearOfProduction
        { get { return this.yearOfProduction; }
          set { this.yearOfProduction = value; } 
        }

        public int EngineVolume 
        { get { return this.engineVolume; } 
          set {this.engineVolume = value; } 
        }
    }
}
