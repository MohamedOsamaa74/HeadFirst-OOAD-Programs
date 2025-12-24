using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_3
{
    public class DogDoor
    {
        private bool Open;
        public DogDoor()
        {
            Open = false;
        }

        public async Task OpenDoor()
        {
            Console.WriteLine("The dog door opens");
            Open = true;
            await Task.Delay(5000);
            CloseDoor();
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
