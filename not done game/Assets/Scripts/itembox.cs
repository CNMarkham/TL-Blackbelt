using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pity : MonoBehaviour
{
    public GameObject[] randomizedSpawn;
    bool touching;
    public GameObject powerupPity;
    public int pity;
    // Start is called before the first frame update
    void Start()
    {
        touching = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && touching == true)
        {
            pity += 1;
            randomSpawn();
        }
        if (pity == 5)
        {
            pity = 0;
            Invoke("pitySpawn", 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touching = true;
    }
    void randomSpawn()
    {
        if (randomizedSpawn.Length == 0) return;

        int randomIndex = Random.Range(0, randomizedSpawn.Length);
        GameObject powerup = randomizedSpawn[randomIndex];

        Instantiate(powerup, transform.position, transform.rotation);
    }
    void pitySpawn()
    {
        Instantiate(powerupPity, transform.position, transform.rotation);
    }
}
