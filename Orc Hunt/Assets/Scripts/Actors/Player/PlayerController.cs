using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlayerComponent
{
    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            myState.ChangeState(myState.moving);
        }
    }

    public void Moving()
    {
        Vector3 moveDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveDir.Normalize();

        rb.MovePosition(transform.position + moveDir * myStats[stat.movementSpeed] * Time.deltaTime);
    }
}
