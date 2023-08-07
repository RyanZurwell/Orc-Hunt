using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatHandler : EntityComponent
{
    private void Awake()
    {
        Initialize();
    }

    public override void AddListeners()
    {
        events.character.combat.DamageDealtEvent += DamageDealt;
        events.character.combat.DamageTakenEvent += DamageTaken;
    }

    private void DamageDealt(IHittable target) => target.Hit(data.stats[Stats.damage]);

    private void DamageTaken(float damageValue)
    {
        data.DecreaseStat(Stats.health, damageValue);
        CheckForDeath();
    }

    private void CheckForDeath()
    {
        if (data.stats[Stats.health] <= 0)
        {
            print($"{gameObject.name} has died.");
        }
    }
}
