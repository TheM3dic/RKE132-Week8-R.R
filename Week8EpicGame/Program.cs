string folderPath = @"E:\Data\";
string heroFile = "Heroes.txt";
string villainFile = "Villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
ShowFileContent(heroFile)

//string[] heroes = { "Batman", "Leon Kennedy", "Grog", "Kratos", "Melinoe" };
//string[] villains = { "Cronos", "Joker", "Wesker", "Odin", "Strahd" };


string[] weapons = { "Blades of Chaos", "francois", "potion of healing", "Baterang", "Adamant Rail" };


string hero = GetRandomValue(heroes);
string Weapon = GetRandomValue(weapons); 
int herosHP = GetcharacterHP(hero);
Console.WriteLine($"Chosen: {hero} HP:{herosHP} Wielding:{Weapon}");

string villain = GetRandomValue(villains);
string power = GetRandomValue(weapons);
int villainsHP = GetcharacterHP(villain);
Console.WriteLine($"Opponent: {villain} HP:{villainsHP} Wielding:{power}");

while (herosHP > 0 && villainsHP > 0) 
{
    herosHP = herosHP - Hit(villain, villainsHP);
    villainsHP = villainsHP - Hit(hero, herosHP);
}

if (herosHP > 0)
{
    Console.WriteLine($"{hero} wins");
}
else if (villainsHP > 0)
{
    Console.WriteLine($"{villain} wins");
}
else
{
    Console.WriteLine("Draw");
}

static string GetRandomValue(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}


static int GetcharacterHP(string characterName)
{
    if (characterName.Length < 10)
    {
        return 10;
    }
    else
    {
        return characterName.Length;
    }
}

static int Hit(string characterName, int characterHP)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, characterHP);

    if (strike == 0)
    {
        Console.WriteLine($"{characterName} missed");
    }
    else if (strike == characterHP - 1)
    {
        Console.WriteLine($"{characterName} made a crtitical hit");
    }
    else
    {
        Console.WriteLine($"{characterName} hit for {strike}DMG");
    }

    return strike;
}