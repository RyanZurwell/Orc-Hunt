using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputEvents
{
    public event Action MovementInputDownEvent;
    public void MovementInputDown() => MovementInputDownEvent?.Invoke();


    public event Action MovementInputUpEvent;
    public void MovementInputUp() => MovementInputUpEvent?.Invoke();
}
