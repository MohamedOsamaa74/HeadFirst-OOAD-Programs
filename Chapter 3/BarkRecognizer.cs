using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_3
{
    public class BarkRecognizer(DogDoor door)
    {
        private DogDoor door = door;

        public async Task Recognize(string Bark)
        {
            Console.WriteLine($"Bark Recognizer hears a {Bark}");
            await door.OpenDoor();
        }
    }
}
