using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackbox : MonoBehaviour
{
    Data myData;

    private void Awake()
    {
        myData = transform.root.GetComponent<Data>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        IHittable target = collision.GetComponent<IHittable>();
        target.Hit(Combat.Damage(myData));
    }
}
