using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 0;
    private bool forward = false;
    private bool backward = false;
    private bool left = false;
    private bool right = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        //player 1 movement
        ///forward 
        if (Input.GetKeyDown(KeyCode.W))
        {
            forward = true;
        }
        if (forward == true)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, speed);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            forward = false;
        }

        ///backward
        if (Input.GetKeyDown(KeyCode.S))
        {
            backward = true;
        }
        if (backward == true)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, -speed);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            backward = false;
        }

        ///left
        if (Input.GetKeyDown(KeyCode.A))
        {
            left = true;
        }
        if (left == true)
        {
            rb.velocity = new Vector3(-speed, 0.0f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            left = false;
        }

        ///right
        if (Input.GetKeyDown(KeyCode.D))
        {
            right = true;
        }
        if (right == true)
        {
            rb.velocity = new Vector3(speed, 0.0f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            right = false;
        }

    }

}
