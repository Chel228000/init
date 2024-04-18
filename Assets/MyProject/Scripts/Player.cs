using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Motion mover;
    [SerializeField] private Attacker attacker;
    [SerializeField] private InputMAnager input;


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
