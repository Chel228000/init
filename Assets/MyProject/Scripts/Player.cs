using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public Health health;
    [SerializeField] private Motion mover;
    [SerializeField] private Attacker attacker;
    [SerializeField] private InputMAnager input;
    [SerializeField] private CharacterSO playerSO;

    private void Start()
    {
        health.maxHealth = playerSO._health;
        mover = GetComponent<Motion>();
        attacker.weapon = playerSO._weapon;
        attacker.damageMask = playerSO._damageMask;
        mover.speed = playerSO._speed;
        input = GetComponent<InputMAnager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (health.isdead)
        {
            return;
        }

        if (input.Attacking)
        {
            attacker.Attack();
        }

        if (!attacker.isAttacking)
        {
            mover.Move(input.motion);
        }
    }
}
