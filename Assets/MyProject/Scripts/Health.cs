
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool isdead;

    [SerializeField] public float maxHealth;
    [SerializeField] private Animator animator;

    public float current_health;

    private void Start()
    {
        current_health = maxHealth;
    }
    public void takeDamage(float damage)
    {
        current_health -= damage;

        if(current_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isdead = true;
        animator.SetTrigger("Dead");
    }
}
