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
    public static string hedronCrab()
    {
        return "target player mills 3";
    }
    public static int lotusCobraGM(int gFMana)
    {
        return gFMana + 1;
    }
    public static int lotusCobraUM(int uFMana)
    {
        return uFMana + 1;
    }
}

