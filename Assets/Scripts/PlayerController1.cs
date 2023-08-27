using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public float upSpeed;
    public float verticalInput;

    Rigidbody rb;
    
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        //Move the plane forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Move the plane Up & down
        transform.Rotate(Vector3.left, upSpeed * verticalInput * Time.deltaTime);
        
    }
}
