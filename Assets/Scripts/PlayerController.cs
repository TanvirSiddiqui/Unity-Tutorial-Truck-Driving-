using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float horizontalSpeed;
    float horizontalInput;
    float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Vehicle Movements
        // Vehicle movement according to vertical input.
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        // Vehicle movement according to horizontal input.
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalSpeed * horizontalInput);
    }
}
