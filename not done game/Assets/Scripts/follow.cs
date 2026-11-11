using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;
    public float Speed = 0.125f;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (target != null)
        {
            Vector3 PlayerPosition = target.transform.position;
            Vector3 Position = Vector3.Lerp(transform.position, PlayerPosition, Speed);
            transform.position = Position;
        }
    }
}