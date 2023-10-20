// Info.i.StartScreen();
// i.StartScreen();
Armory armory = new();
Fighter player = new();

Info.StartScreen();
Info.ViewTutorial();
Info.CharacterStats(player);
Constructor constructor = new(player);


Console.ReadLine();