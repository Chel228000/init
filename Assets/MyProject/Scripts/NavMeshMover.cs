using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMover : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private float _range;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Animator animator;

    Transform player;

    private void Start()
    {
        player = FindObjectOfType<Motion>().transform;

        _agent.SetDestination(player.position);
    }

    private void Update()
    {
    }
    internal void moveTo(Health player)
    {
        _agent.SetDestination(player.transform.position);
        updateSpeed(3);
    }

    private void updateSpeed(float speed)
    {
        if (speed<0.1f)
        {
            _agent.isStopped = true;
            animator.SetFloat("Blend", speed);
        }
        else
        {
            _agent.isStopped = false;
            animator.SetFloat("Blend", speed);
        }
    }

    internal void Stop() => updateSpeed(0);



}
