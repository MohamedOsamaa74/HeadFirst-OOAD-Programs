using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_4
{
    public class DogDoor
    {
        private bool Open;
        private List<Bark> allowedBark = [];
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

        public void AddAllowedBark(Bark AllowedBark)
        {
            allowedBark.Add(AllowedBark);
        }
        public List<Bark> GetAllowedBarks()
        {
            return allowedBark;
        }
    }
}
