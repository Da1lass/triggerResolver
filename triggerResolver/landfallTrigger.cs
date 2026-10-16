using System;

namespace triggerResolver;

public class landfallTrigger {

    public static int ScuteSwarmL6(int insectToken) /*runs if landcount < 6*/
    {
        return insectToken + 1;
    }
     public static int ScuteSwarmG6(int scuteCopies) //runs if landcount >= 6
    {
        return scuteCopies * 2 ;
    }
}

