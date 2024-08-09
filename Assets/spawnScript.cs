using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;
    public float heightoffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;   
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }

    void SpawnPipe()
    {
        
        float lowestlimit = transform.position.y - heightoffset;
        float highestlimit = transform.position.y + heightoffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestlimit, highestlimit), 0), transform.rotation);
        
    }
}
