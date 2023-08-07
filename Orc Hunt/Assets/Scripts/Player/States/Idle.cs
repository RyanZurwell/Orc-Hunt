using UnityEngine;

[CreateAssetMenu(menuName = "Data/States/Idle", fileName = "Idle")]
public class Idle : State
{
    public override void AddListeners()
    {
        events.character.player.input.MovementInputDownEvent += OnMoving;
    }

    public override void Enter()
    {
        
    }

    public override void Update()
    {
        
    }

    public override void Exit()
    {
        
    }

    private void OnMoving() => state.ChangeState(PlayerStates.moving);
}
