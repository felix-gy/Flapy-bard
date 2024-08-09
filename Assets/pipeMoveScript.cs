using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deadZone = 45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < -deadZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
