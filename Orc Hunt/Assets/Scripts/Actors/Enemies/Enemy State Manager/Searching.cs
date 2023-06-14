using UnityEngine;

public class Searching : BaseActorState
{
    public override void OnEnter()
    {
        EnemyController controller = owner.GetComponent<EnemyController>();

        //Search for the player
        //If the player is found set the owners controller target to the player and switch the owners state to chasing
        //If the player cannot be found then keep searching
    }

    public override void OnUpdate()
    {
        //keep searching
    }
}
