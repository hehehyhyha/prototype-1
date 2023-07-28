using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwordInput;
    public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwordInput= Input.GetAxis("Vertical" + inputID);
        //Move the vehicle forword based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwordInput);
        // Rotates car based on input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
