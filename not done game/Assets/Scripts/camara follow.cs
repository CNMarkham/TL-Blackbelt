using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float Speed = 0.125f;

    void Update()
    {
        if (target != null)
        {
            Vector3 PlayerPosition = target.position;

            Vector3 camPosition = Vector3.Lerp(transform.position, PlayerPosition, Speed);

            transform.position = camPosition;
        }
    }
}


