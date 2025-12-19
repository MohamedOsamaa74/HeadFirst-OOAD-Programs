using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_2
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
                Door.OpenDoor();
                await Task.Delay(5000);
                Door.CloseDoor();
            }
        }
    }
}