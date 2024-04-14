using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TestInput();
    }
    void TestInput()
    {
        movement();

        void movement()
        {
            if (rb == null)
            {
                return;
            }
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
            movementDirection = transform.TransformDirection(movementDirection);

            rb.AddForce(movementDirection,ForceMode.VelocityChange);
        }

    }

}
