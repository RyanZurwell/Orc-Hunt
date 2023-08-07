using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatEvents
{
    public event Action<Stat, float> IncreaseStatEvent;
    public void IncreaseStat(Stat stat, float value) => IncreaseStatEvent?.Invoke(stat, value);


    public event Action<Stat, float> DecreaseStatEvent;
    public void DecreaseStat(Stat stat, float value) => DecreaseStatEvent?.Invoke(stat, value);
}
