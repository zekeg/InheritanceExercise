using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int EggClutchSize { get; set; }
        public int WingspanCm { get; set; }
        public bool CanFly { get; set; }
        public string BirdSong { get; set; }
    }
}
