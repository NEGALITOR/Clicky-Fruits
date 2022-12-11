using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horsePower = 0f;
    [SerializeField] private float turnSpeed = 45.0f;
    [SerializeField] GameObject centerOfMass;
    private float horizontalInput;
    private float verticalInput;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Moves car forward based on vertical input
        rb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        // Rotates car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
