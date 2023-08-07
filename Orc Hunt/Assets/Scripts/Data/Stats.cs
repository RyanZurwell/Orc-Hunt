using UnityEngine;

public static class Stats
{
    public static Stat health = (Stat)Resources.Load("Data/Stats/Health");
    public static Stat movementSpeed = (Stat)Resources.Load("Data/Stats/Movement Speed");
    public static Stat damage = (Stat)Resources.Load("Data/Stats/Damage");
}
