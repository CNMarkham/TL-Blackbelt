using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pity : MonoBehaviour
{
    public GameObject[] randomizedSpawn;
    public bool touching;
    public GameObject powerupPity;
    public GameObject itemBox;
    public int pity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && touching == true)
        {
            pity += 1;
            Destroy(itemBox, .01f);
            randomSpawn();
        }

        if (pity == 5)
        {
            pity = 0;
            Invoke("pitySpawn", 0.0001f);
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
