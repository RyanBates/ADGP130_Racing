using UnityEngine;
using System.Collections;

public class finnish : MonoBehaviour
{
    public int currnetlap = 1;
    public int check = 0;
 

    bool FinalLap()
    {
        if (currnetlap == 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    bool checkpoint()
    {
        if (check == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    void OnTriggerEnter(Collider a)
    {
        if (a.gameObject.GetComponent<P1>() != null)
        {
            if (FinalLap() != true)
            {
                check += 1;
            }
            if (check == 2)
            {
                currnetlap += 1;
                check = 0;
            }
            if (currnetlap == 3)
            {
                print("Race won by player one");
            }
        }

        if (a.gameObject.GetComponent<P2>() != null)
        {
            if(FinalLap() != true)
            {
                check += 1;
            }
            if (check == 2)
            {
                currnetlap += 1;
            }
            if (currnetlap == 3)
            {
                print("Race won by player two");
            }
        }
    }
}
