using UnityEngine;
using System.Collections;

public class RandomPower : MonoBehaviour
{
    public int numberOfPowerUps = 4;
    public float minXSpawn = 1f;
    public float maxXSpawn = 4f;
    public float ySpawn = 1f;
    public float randomX;


    void Start()
    {
        randomX = Random.Range(minXSpawn, maxXSpawn);
    }

    void Update()
    {
        if (randomX > 0) randomX -= Time.deltaTime;
        else
        {
            randomX = Random.Range(minXSpawn, maxXSpawn);
        }
    }
}
