using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody rb;

    const string AnimFowardBack = "ForwardBack";
    const string AnimLeftRight = "LeftRight";

    Vector3 velocityNow;
    Vector3 velocityNeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        testAnimation();
    }

    void testAnimation()
    {
        Movement();
        void Movement()
        {
            if (rb.velocity != Vector3.zero)
            {
                velocityNeed = rb.velocity;

            }

            velocityNow += (velocityNeed - velocityNow) * Time.deltaTime * 10;
            Vector3 animDirection = velocityNow;
            animDirection = transform.InverseTransformDirection(animDirection);

            animator.SetFloat(AnimFowardBack,animDirection.z);
            animator.SetFloat(AnimLeftRight,animDirection.x);
        }
    }
}
