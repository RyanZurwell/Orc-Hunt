using UnityEngine;

[CreateAssetMenu(menuName = "Data/States/Enemy/Searching", fileName = "Searching")]
public class Searching : State
{
    private GameObject target;

    ////////////////////////////////////////////////
    /// IState Methods
    ////////////////////////////////////////////////

    public override void Update()
    {
        if (target == null) target = FindTarget();
        else
        {
            events.character.enemy.SetTarget(target);
            state.ChangeState(EnemyStates.chasing);
        }
    }

    private GameObject FindTarget()
    {
        GameObject newTarget;
        newTarget = GameObject.FindWithTag("Player");
        return newTarget;
    }
}
