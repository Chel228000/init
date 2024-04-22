using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(fileName = "Player", menuName = "config|players")]
public class CharacterSO : ScriptableObject
{
    [SerializeField] public GameObject prefab;
    [SerializeField] public Weapon _weapon;
    public enum Type
    {
        Ranger,
        Scout,
        Mage,
        Knight
    }
    [SerializeField] public int _health;
    [SerializeField] public LayerMask _damageMask;
    [SerializeField] public float _speed;
}
