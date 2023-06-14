using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    [HideInInspector] public Animator animator;

    public virtual void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayIdleAnimation()
    {

    }

    public void PlayMovingAnimation()
    {
        animator.SetBool("Moving", true);
    }

    public void StopMovingAnimation()
    {
        animator.SetBool("Moving", false);
    }

    public void PlayHitAnimation()
    {

    }
}
