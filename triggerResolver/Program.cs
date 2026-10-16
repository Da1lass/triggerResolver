using triggerResolver;

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

System.Console.WriteLine(insectToken);
System.Console.WriteLine(scuteCopies);