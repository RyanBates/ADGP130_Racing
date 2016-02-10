using UnityEngine;
using System.Collections;

public class P1 : MonoBehaviour
{
    private Rigidbody playerOne;
    public float speed = 10;
    public Vector3 playerOnePosition = new Vector3(0, 0, 0);

    void Start()
    {
        playerOne = GetComponent<Rigidbody>();
        playerOne = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (gameObject.tag == "Player")
        {
            if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
            {
                playerOnePosition = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                playerOne.AddForce (playerOnePosition * speed);
            }
        }
        playerOne.AddForce(playerOnePosition * Time.deltaTime);
    }
}