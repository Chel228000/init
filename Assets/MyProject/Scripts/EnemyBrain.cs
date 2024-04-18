using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private NavMeshMover mover;
    [SerializeField] private Attacker enemyAttacker;

    private Health player;
    void Start() => player = FindObjectOfType<Motion>().GetComponent<Health>();

    // Update is called once per frame
    void Update()
    {
        if (player.isdead)
        {
            return;
        }
        if (enemyAttacker.targetInRange(player))
        {
            mover.Stop();
            enemyAttacker.Attack();
        }
        else
        {
            mover.moveTo(player);
        }
        if (health.isdead)
        {
            mover.Stop();
        }
    }
}
