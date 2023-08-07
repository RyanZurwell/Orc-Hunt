using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Combat
{
    public static float Damage(Data data)
    {
        float damage = data.stats[Stats.damage];

        //Get damage
        //Generate two numbers, 2% above and below the damage
        //Roll a random number between those two numbers
        //Check for a crit
        //If crit, multiply the damage by 1.5x

        return damage;
    }

    public static float DamageTaken(Data data, float damage)
    {
        float adjustedDamage = damage;

        //Apply damage reductions here

        return adjustedDamage;
    }
}
