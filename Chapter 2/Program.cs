using Chapter_2;

DogDoor door = new DogDoor();
Remote remote = new Remote(door);
var BackgroundTasks = new List<Task>();

Console.WriteLine("Fido Barks to go outside...");
BackgroundTasks.Add(remote.PressButton());

Console.WriteLine("Fido has gone outside...");
Console.WriteLine("Fido's all done...");

await Task.WhenAll(BackgroundTasks);
BackgroundTasks.Clear();

Console.WriteLine("...but he's stuck outside!\n");
Console.WriteLine("Fido starts barking...");
Console.WriteLine("...so Gina grabs the remote control.");

await Task.WhenAll(BackgroundTasks);
BackgroundTasks.Add(remote.PressButton());
Console.WriteLine("Fido's back inside...");
await Task.WhenAll(BackgroundTasks);