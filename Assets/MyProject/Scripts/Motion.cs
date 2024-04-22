using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Windows;

public class Motion : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    [SerializeField] private InputMAnager _input;
    [SerializeField] private Animator animator;
    [SerializeField] public float speed;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
        controller = GetComponent<CharacterController>();
        _input = GetComponent<InputMAnager>();
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if(_input.motion.sqrMagnitude > 0.05f)
        {
            Vector3 input = _input.motion;
            Move(input);
        }
        else
        {
            setAnimatorSpeed(0);
        }
    }

    public void Move(Vector3 input)
    {
        var direction = cam.transform.TransformDirection(input);
        direction.y = 0;
        direction.Normalize();
        transform.forward = direction;
        direction += Physics.gravity;
        controller.Move(direction * speed * Time.deltaTime);
        setAnimatorSpeed(controller.velocity.magnitude);
    }

    private void setAnimatorSpeed(float speed)
    {
        animator.SetFloat("Blend", speed);
    }
}
