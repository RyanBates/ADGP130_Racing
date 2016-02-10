using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour
{
    private Rigidbody playerOne;
    public GameObject powerUps;
    public int IncreasedSpeed = 15;

    bool nitro()
    {
        if (powerUps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool lightning()
    {
        if (powerUps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool missile()
    {
        if (powerUps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool shield()
    {
        if (powerUps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider a)
    {
        if (a.gameObject.GetComponent<P1>() != null)
        {

        }
    }

    void Update()
    {
        if (gameObject.tag == "Player")
        {
            if (Input.GetKey("space"))
            {
                if (nitro() != null)
                {
                    gameObject.GetComponent<P1>(speed) = IncreasedSpeed;
                }
                else
                {
                    
                }
            }
        }
    }
  
   }

