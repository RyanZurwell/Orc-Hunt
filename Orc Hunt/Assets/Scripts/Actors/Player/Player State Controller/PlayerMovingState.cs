using UnityEngine;

public class PlayerMovingState : MovingState
{
    private ActorData playerData;
    private StatList stats;

    public override void OnEnter()
    {
        base.OnEnter();
        playerData = owner.GetComponent<ActorData>();
        stats = (StatList)Resources.Load("Stat List");
    }

    public override void OnFixedUpdate()
    {
        Vector3 moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveDir.Normalize();

        rb.MovePosition(owner.transform.position + moveDir * playerData.stats[stats.movementSpeed] * Time.deltaTime);
    }
}
