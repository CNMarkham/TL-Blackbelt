using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pity : MonoBehaviour
{
    public GameObject[] randomizedSpawn;
    public bool touching;
    public GameObject powerupPity;
    public int pity;
    public GameObject smth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (smth == gameObject.CompareTag("powerup"))
        {

        }
        if (Input.GetKeyDown(KeyCode.E) && touching == true && smth != null)
        {
            Destroy(smth);
            pity += 1;
            randomSpawn();
        }

        if (pity == 5)
        {
            pity = 0;
            pitySpawn();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        smth = other.gameObject;
        touching = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        smth = null;
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
