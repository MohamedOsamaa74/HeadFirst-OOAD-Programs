using Chapter_3;

DogDoor door = new DogDoor();
Remote remote = new Remote(door);
BarkRecognizer recognizer = new BarkRecognizer(door);
var BackgroundTasks = new List<Task>();

Console.WriteLine("Fido Barks to go outside...");
BackgroundTasks.Add(recognizer.Recognize("Woof"));

Console.WriteLine("Fido has gone outside...");
Console.WriteLine("Fido's all done...");

await Task.WhenAll(BackgroundTasks);
BackgroundTasks.Clear();

Console.WriteLine("...but he's stuck outside!\n");
Console.WriteLine("Fido starts barking...");

await Task.WhenAll(BackgroundTasks);
BackgroundTasks.Add(recognizer.Recognize("Woof"));
Console.WriteLine("Fido's back inside...");
await Task.WhenAll(BackgroundTasks);