using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public logicManagerScript logicManager;

    public Rigidbody2D myRigidBody;
    public float jumpForce = 10;
    private bool birdIsLive = true;
    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<logicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsLive)
        {
            myRigidBody.velocity = Vector2.up * jumpForce;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.GameOver();
        birdIsLive = false;
    }


}
