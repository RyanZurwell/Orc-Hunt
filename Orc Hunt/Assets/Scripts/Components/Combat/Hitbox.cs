using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour, IHittable
{
    private Data myData;

    public bool hasHitTimeout;
    private float hitTimeout;

    private Animator animator;

    private void Awake()
    {
        myData = transform.root.GetComponent<Data>();
        animator = transform.root.GetComponentInChildren<Animator>();
    }

    public void Hit(float damage)
    {
        if (Time.time < hitTimeout) return;

        myData.stats[Stats.health] -= Combat.DamageTaken(myData, damage);
        animator.SetTrigger(TriggerParameters.hit);

        hitTimeout = Time.time + 1;
    }
}
