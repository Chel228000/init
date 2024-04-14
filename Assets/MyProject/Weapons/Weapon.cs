using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "weapon", menuName = "config|weapons")]

public class Weapon : ScriptableObject
{
    [SerializeField] public float attackCooldown;
    [SerializeField] public float damage;
    [SerializeField] public float range;
    public GameObject prefab;
}
