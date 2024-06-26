
using System.Collections;
using System.Collections.Generic;
using Unity.XR.Oculus.Input;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public bool CooldownUp => attackTime <= 0;

    public bool isAttacking { get; private set; }
    [SerializeField] private Animator animator;
    [SerializeField] public LayerMask damageMask;
    [SerializeField] public Weapon weapon;
    [SerializeField] private Transform hand;

    Collider[] hits = new Collider[3];
    private float attackTime;

    // Start is called before the first frame update
    void Start()
    {
        resetAttackTimer();
        animator = GetComponent<Animator>();
        
        Instantiate(weapon.prefab, hand);
    }

    private void resetAttackTimer() => attackTime = weapon.attackCooldown;
    public bool targetInRange(Health target) =>
        Vector3.Distance(transform.position, target.transform.position) < weapon.range;

    public void Attack()
    {
        if (CooldownUp)
        {
            AnimateAttack();
            resetAttackTimer();
        }
    }

    public void AttackNearEnemies()
    {
        int count = Physics.OverlapSphereNonAlloc(transform.position, weapon.range, hits, damageMask);

        for(int i = 0; i < count; i++)
        {
            if (hits[i].TryGetComponent<Health>(out var health))
            {
                health.takeDamage(weapon.damage);
            }
        }
    }

    private void AnimateAttack()
    {
        var index = Random.Range(0, 2);
        animator.SetTrigger("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        attackTime -= Time.deltaTime;
        isAttacking = weapon.attackCooldown - attackTime < 1;
    }
}
