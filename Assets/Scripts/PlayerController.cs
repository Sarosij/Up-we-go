using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float upSpeed;
    public float horizontalInput;

    Rigidbody rb;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        //Move the plane forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Move the plane Up & down
        transform.Rotate(Vector3.left, upSpeed * horizontalInput * Time.deltaTime);
        
    }
}
