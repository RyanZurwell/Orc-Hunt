using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEvents
{
    public event Action<IHittable> DamageDealtEvent;
    public void DamageDealt(IHittable target) => DamageDealtEvent?.Invoke(target);


    public event Action<float> DamageTakenEvent;
    public void DamageTaken(float value) => DamageTakenEvent?.Invoke(value);
}
