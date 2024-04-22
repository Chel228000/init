
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "config|enemies")]

public class EnemySO : ScriptableObject
{
    [SerializeField] public int _health;
    [SerializeField] public float _speed;
    [SerializeField] public LayerMask _damageMask;
    [SerializeField] public Weapon _weapon;
    public GameObject enemy;

    public enum Type
    {
        Melee,
        Ranged
    }
}


