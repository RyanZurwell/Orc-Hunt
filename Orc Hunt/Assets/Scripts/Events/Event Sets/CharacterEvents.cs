using System;

public class CharacterEvents
{
    public PlayerEvents player = new PlayerEvents();
    public EnemyEvents enemy = new EnemyEvents();

    public StateMachineEvents state = new StateMachineEvents();
    public StatEvents stats = new StatEvents();
}
