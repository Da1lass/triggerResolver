using triggerResolver;
//floating mana counts and other related vars
int gFMana; gFMana = 0;
int uFMana; uFMana = 0;
//int cFMana; cFMana = 0;
string[] lotusCobraValidChoices = ["G","U"]; string[] tirelessProvider = ["F","T"];

int landCount; landCount = 6;
int scuteCopies; scuteCopies = 1;
int insectToken; insectToken = 0;
int foodToken; foodToken = 0;
int treasureToken; treasureToken = 0;

landfallTrigger landfall = new landfallTrigger();

if (landCount >= 6)
{
    scuteCopies = landfallTrigger.ScuteSwarmG6(scuteCopies);
}
else
{
    insectToken = landfallTrigger.ScuteSwarmL6(insectToken);
}


System.Console.WriteLine("What color of floatig mana: G(reen), (Bl)U(e)");
string choice = System.Console.ReadLine().ToUpper();

if (lotusCobraValidChoices.Contains(choice))
{
    if (choice == lotusCobraValidChoices[0])
    {
        gFMana = landfallTrigger.lotusCobraGM(gFMana);
    }
    else if (choice == lotusCobraValidChoices[1]);
    {
        uFMana = landfallTrigger.lotusCobraUM(uFMana);
    }
}
else 
{
    while (! lotusCobraValidChoices.Contains(choice))
    {
        choice = System.Console.ReadLine().ToUpper();
    }
}

if (tirelessProvider.Contains(choice))
{
    if (choice == tirelessProvider[0])
    {
        foodToken = landfallTrigger.TirelessProviderFood(foodToken);
    }
    else if (choice == tirelessProvider[1]);
    {
        treasureToken = landfallTrigger.TirelessProviderTreasure(treasureToken);
    }
}
else 
{
    while (!tirelessProvider.Contains(choice))
    {
        choice = System.Console.ReadLine().ToUpper();
    }
}


System.Console.WriteLine(choice);
System.Console.WriteLine(insectToken);
System.Console.WriteLine(scuteCopies);
System.Console.WriteLine(gFMana);
System.Console.WriteLine(uFMana);
System.Console.WriteLine(foodToken);
System.Console.WriteLine(treasureToken);