using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool RaisesYoung { get; set; }
        public bool Aquatic { get; set; }
        public int EggClutchSize { get; set; }
        public bool ActiveCamouflage { get; set; }
    }
}
