﻿// Info.i.StartScreen();
// i.StartScreen();
Armory armory = new();
Fighter player = new();
Fighter enemy = new();

Info.StartScreen();
Info.ViewTutorial();
Info.CharacterStats(player);
Constructor constructor = new(player, enemy);

UI.MenuLine();
UI.HpBar(5, 10, player.maxHp, player.hp);
UI.ManaBar(5, 13, player.maxMana, player.mana);
UI.EnergyBar(5, 15, player.maxEnergy, player.energy);
UI.AttackLabel(player);
UI.HpBar(65, 10, enemy.maxHp, enemy.hp);





Console.ReadLine();