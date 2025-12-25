using Chapter_4;

DogDoor door = new DogDoor();
Remote remote = new Remote(door);
BarkRecognizer recognizer = new BarkRecognizer(door);

door.AddAllowedBark(new("Woof"));
door.AddAllowedBark(new("rawr"));
door.AddAllowedBark(new("yip"));

Console.WriteLine("The owner's dog barks to go outside...");
await recognizer.Recognize(new Bark("yip"));

Console.WriteLine("The owner's dog has gone outside...");
Console.WriteLine("The owner's dog is all done...");

Console.WriteLine("\n...but he's stuck outside!");
Console.WriteLine("The owner's dog starts barking...");

await recognizer.Recognize(new Bark("ra0wr"));

Console.WriteLine("The owner's dog is back inside...");