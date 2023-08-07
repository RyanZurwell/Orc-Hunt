using UnityEngine;

public static class Stats
{
    public static Stat health = (Stat)Resources.Load("Data/Stats/Health");
    public static Stat maxHealth = (Stat)Resources.Load("Data/Stats/Health Max");
    public static Stat movementSpeed = (Stat)Resources.Load("Data/Stats/Movement Speed");
    public static Stat damage = (Stat)Resources.Load("Data/Stats/Damage");
    public static Stat experience = (Stat)Resources.Load("Data/Stats/Experience");
    public static Stat levelExperience = (Stat)Resources.Load("Data/Stats/Experience Max");
    public static Stat level = (Stat)Resources.Load("Data/Stats/Level");
}
