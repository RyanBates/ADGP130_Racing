using UnityEngine;
using System.Collections;

public class P2 : MonoBehaviour
{
    private Rigidbody playerTwo;
    public float speed = 10;
    public Vector3 playerTwoPosition = new Vector3(0, 0, 0);

    void Start()
    {
        playerTwo = GetComponent<Rigidbody>();
        playerTwo = GameObject.FindGameObjectWithTag("Player2").GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (gameObject.tag == "Player2")
        {
            if (Input.GetKey("i") || Input.GetKey("j") || Input.GetKey("k") || Input.GetKey("l"))
            {
                playerTwoPosition = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2"));
                playerTwo.AddForce(playerTwoPosition * speed);
            }
        }
        playerTwo.AddForce(playerTwoPosition * Time.deltaTime);
    }
}