using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        transform.position += Vector3.right * horizontal * moveSpeed * Time.deltaTime;
        transform.position += Vector3.up * vertical * moveSpeed * Time.deltaTime;

     //   if(Input.GetKey(KeyCode.W))
     //   {
     //       transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        
    }
}
