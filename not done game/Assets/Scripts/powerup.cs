using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public bool touching;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && touching == true)
        {

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        touching = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        touching = false;
    }
}


