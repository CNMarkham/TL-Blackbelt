using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed;
    Vector3 gunShotPos;
    void Start()
    {
        gunShotPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * MoveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (CompareTag("enemy"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
