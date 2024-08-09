using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{
    public logicManagerScript logicManager;

    void Start()
    {
        logicManager = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<logicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        

       if (collision.gameObject.layer == 3)
       {
            logicManager.addScore(1);
       }

    }
}
