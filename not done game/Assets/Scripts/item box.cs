 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class itembox : MonoBehaviour
{
    public GameObject[] randomizedSpawn;
    InputAction attack;
    // Start is called before the first frame update
    void Start()
    {
        attack = InputSystem.actions.FindAction("Player/Attack");
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        InputSystem.actions.FindAction("Attack");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("test");
            randomSpawn();
        }
    }
    void randomSpawn()
    {
        if (randomizedSpawn.Length == 0) return;

        int randomIndex = Random.Range(0, randomizedSpawn.Length);
        GameObject powerup = randomizedSpawn[randomIndex];

        Instantiate(powerup, transform.position, transform.rotation);
    }
}
