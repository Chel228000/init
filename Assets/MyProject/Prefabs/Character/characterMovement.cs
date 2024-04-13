using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class characterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    public float speed = 10;
    [SerializeField] float sensitivity;

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
        rotate();

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
        void rotate()
        {
            float mousex = Input.GetAxis("Mouse X")*sensitivity;

            transform.Rotate(Vector3.up * mousex);
        }
    }

}
