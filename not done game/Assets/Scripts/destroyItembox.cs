 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class itembox : MonoBehaviour
{
    bool touching;
    // Start is called before the first frame update
    void Start()
    {
        touching = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) &&touching == true)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching = true;
    }
}
