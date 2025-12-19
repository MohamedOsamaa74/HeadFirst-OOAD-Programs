using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_2
{
    public class DogDoor
    {
        private bool Open;
        public DogDoor()
        {
            Open = false;
        }

        public void OpenDoor()
        {
            Console.WriteLine("The dog door opens");
            Open = true;
        }

        public void CloseDoor()
        {
            Console.WriteLine("The dog door closes");
            Open = false;
        }

        public bool IsDoorOpen()
        {
            return Open;
        }
    }
}
