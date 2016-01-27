using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour
{
    private Rigidbody rb;
    public int speed = 0;
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
        //player 2 movement
        ///forward
        if (Input.GetKeyDown(KeyCode.I))
        {
            forward = true;
        }
        if (forward == true)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, speed);
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            forward = false;
        }
        ///backward
        if (Input.GetKeyDown(KeyCode.K))
        {
            backward = true;
        }
        if (backward == true)
        {
            rb.velocity = new Vector3(0.0f, 0.0f, -speed);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            backward = false;
        }
        ///left
        if (Input.GetKeyDown(KeyCode.J))
        {
            left = true;
        }
        if (left == true)
        {
            rb.velocity = new Vector3(-speed, 0.0f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            left = false;
        }
        ///right
        if (Input.GetKeyDown(KeyCode.L))
        {
            right = true;
        }
        if (right == true)
        {
            rb.velocity = new Vector3(speed, 0.0f, 0.0f);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            right = false;
        }
    }

    void lap()
    {

    }
}
