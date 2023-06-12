using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Actor
{
    [SerializeField] private Rigidbody2D rb;

    private void FixedUpdate()
    {
        if (myState.currentState == myState.crowdControlledState) return;

        Vector3 moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveDir.Normalize();
        
        rb.MovePosition(transform.position + moveDir * myData.stats[stats.movementSpeed] * Time.deltaTime);
    }
}
