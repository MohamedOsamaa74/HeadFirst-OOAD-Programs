using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_3
{
    public class Remote(DogDoor door)
    {
        private DogDoor Door = door;
        public async Task PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (Door.IsDoorOpen())
            {
                Door.CloseDoor();
            }
            else
            {
                await Door.OpenDoor();
            }
        }
    }
}
