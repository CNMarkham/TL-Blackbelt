using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    GameObject target;
    public float Speed = 0.125f;
    public Vector3 rotationSpeed = new Vector3(0, 0, 100);
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (target != null)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
            Vector3 OffsetZ = new Vector3(0, 0, 1);
            Vector3 PlayerPosition = target.transform.position;
            Vector3 Position = Vector3.Lerp(transform.position, PlayerPosition + OffsetZ, Speed);
            transform.position = Position;
        }
    }
}