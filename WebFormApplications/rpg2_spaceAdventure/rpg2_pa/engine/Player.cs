using System;
using System.Collections.Generic;

public class Player
{
    // Properties
    public string Location { get; set; }
    public List<string> Codes { get; set; }
    public float OxygenLevel { get; set; }
    public int SpaceSuitIntegrity { get; set; }

    // Constructor
    public Player(string location, List<string> codes, float oxygenLevel, int spaceSuitIntegrity)
    {
        Location = location;
        Codes = codes;
        OxygenLevel = oxygenLevel;
        SpaceSuitIntegrity = spaceSuitIntegrity;
    }

}