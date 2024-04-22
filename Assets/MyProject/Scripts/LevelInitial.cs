using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class LevelInitial : MonoBehaviour
{
    [SerializeField] public CharacterSO player;
    [SerializeField] public EnemySO enemy;

    [SerializeField] public Transform playerSpawn;
    [SerializeField] public Transform enemySpawn;

    void Start()
    {
        
    }

}
