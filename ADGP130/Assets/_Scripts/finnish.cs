using UnityEngine;
using System.Collections;

public class finnish : MonoBehaviour
{
    public int currnetlap = 0;
    public int clap = 0;

    bool FinalLap()
    {
        if (currnetlap == 4)
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
        if (a.gameObject.GetComponent<movement>() != null)
        {
            if(FinalLap() != true)
            {
                currnetlap += 1;
                //a.gameObject.GetComponent<Player1>().lap += 1;
            }
            else
            {
                //Race won by player one.
            }
        }
    }

}
