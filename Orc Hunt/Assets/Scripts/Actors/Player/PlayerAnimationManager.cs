using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : AnimationManager
{
    void Update()
    {
        animator.SetFloat("Current X", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("Current Y", Input.GetAxisRaw("Vertical"));

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1) animator.SetFloat("Last X", Input.GetAxisRaw("Horizontal"));
    }
}
