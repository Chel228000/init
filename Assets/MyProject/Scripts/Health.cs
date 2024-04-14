
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private Animator animator;

    private float current_health;

    private void Start()
    {
        current_health = maxHealth;
    }
    public void takeDamage(float damage)
    {
        current_health -= damage;

        if(current_health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        animator.SetTrigger("Dead");
    }
}
