using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_4
{
    public class BarkRecognizer(DogDoor door)
    {
        private DogDoor door = door;

        public async Task Recognize(Bark bark)
        {
            Console.WriteLine($"Bark Recognizer hears a {bark.GetSound()}");
            List<Bark>AllowedBarks = door.GetAllowedBarks();
            foreach(Bark item in AllowedBarks)
            {
                if (item.Equals(bark))
                {
                    await door.OpenDoor();
                    return;
                }
            }
            Console.WriteLine("This dog is not allowed");
            Environment.Exit(0);
        }
    }
}
