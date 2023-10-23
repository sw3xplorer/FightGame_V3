// Info.i.StartScreen();
// i.StartScreen();
Fighter player = new();
Fighter enemy = new();
Armory armory = new();

Info.StartScreen();
Info.ViewTutorial();
Info.CharacterStats(player);
Constructor constructor = new(player, enemy);


Combat.InCombat(player, enemy, constructor, armory);




Console.ReadLine();