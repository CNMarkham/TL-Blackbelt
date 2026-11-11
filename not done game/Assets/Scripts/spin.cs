using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0, 0, 1000);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
