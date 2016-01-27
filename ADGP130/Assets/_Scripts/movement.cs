using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

    public float speed = 0;
    public float topspeed = 2;


	void Update ()
    {
        //movement for the players
        float side = Input.GetAxis("Horizontal");
        float forward = Input.GetAxis("Vertical");
        float back = Input.GetAxis("Reverse");

        transform.Rotate(Vector3.up, side * 2);

        if (forward >= 0 && speed < topspeed)
        {
            speed += Time.deltaTime * (forward * .1f);
        }
        else if(speed > 0 && forward < 2)
        {
            speed -= Time.deltaTime * .1f;
        }
        else if(back >= 0.1f && speed > -topspeed / 2)
        {
            speed += Time.deltaTime * (-back * .1f);
        }
        else if(speed < 0 && back < 0.1f)
        {
            speed += Time.deltaTime * .1f;
        }


        transform.position += transform.forward * (speed);
    }
}
