using triggerResolver;
//floating mana counts and other related vars
int gFMana; gFMana = 0;
int uFMana; uFMana = 0;
int cFMana; cFMana = 0;
char[] lotuscobraValidChoices = ['g','u'];

int landCount; landCount = 6;
int scuteCopies; scuteCopies = 1;
int insectToken; insectToken = 0;

landfallTrigger landfall = new landfallTrigger();

if (landCount >= 6)
{
    scuteCopies = landfallTrigger.ScuteSwarmG6(scuteCopies);
}
else
{
    insectToken = landfallTrigger.ScuteSwarmL6(insectToken);
}


System.Console.WriteLine("What color of floatig mana: G(reen), U(Blue)");
char choice = Convert.ToChar(System.Console.ReadLine());

if (choice == lotuscobraValidChoices[0] || choice == lotuscobraValidChoices[1]) {
    if (choice == 'g') { gFMana = landfallTrigger.lotusCobraGM(gFMana); }
    else if (choice == 'u') { uFMana = landfallTrigger.lotusCobraUM(uFMana);} }
else {
    while (choice != lotuscobraValidChoices[0] || choice != lotuscobraValidChoices[1]) { 
        choice = Convert.ToChar(System.Console.ReadLine()); } }

System.Console.WriteLine(insectToken);
System.Console.WriteLine(scuteCopies);
System.Console.WriteLine(gFMana);
System.Console.WriteLine(uFMana);