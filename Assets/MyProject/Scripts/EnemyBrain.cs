using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    [SerializeField] public Health health;
    [SerializeField] private NavMeshMover mover;
    [SerializeField] private Attacker enemyAttacker;
    [SerializeField] private EnemySO enemySO;

    private Health player;
    void Start()
    {
        health.maxHealth = enemySO._health;
        mover._agent.speed = enemySO._speed;
        enemyAttacker.weapon = enemySO._weapon;
        player = FindObjectOfType<Motion>().GetComponent<Health>();
        health.current_health = health.maxHealth;
    } 

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
