using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    public Player player;
    public StatList stats;

    private void Awake()
    {
        stats = (StatList)Resources.Load("Stat List");
    }

    private void Start()
    {
        player = GetComponent<Player>();
    }
}
