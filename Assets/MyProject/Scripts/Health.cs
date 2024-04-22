
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool isdead;

    [SerializeField] public float maxHealth;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject hitFX;
    [SerializeField] private CapsuleCollider capsuleCollider;

    public float current_health;

    private void Start()
    {
        current_health = maxHealth;
    }
    public void takeDamage(float damage)
    {
        current_health -= damage;
        Instantiate(hitFX,gameObject.transform.position,Quaternion.identity);
        animator.SetTrigger("hurt");

        if(current_health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        isdead = true;
        capsuleCollider.enabled = false;
        animator.SetTrigger("Dead");
        Destroy(gameObject, 3);
    }
}
