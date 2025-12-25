using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_4
{
    public class Bark(string sound)
    {
        private string sound = sound;
        public string GetSound()
        {
            return sound; 
        }
        public bool Equals(Bark bark)
        {
            return sound == bark.sound;
        }
    }
}
