using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    public GameObject[] randomizedSpawn;
    public bool touching;
    public GameObject powerupPity;
    public int pity;
    public GameObject smth;
    GameObject[] passableWall;
    public GameObject powerupAura;
    public int NumberofBoxes;
    int SceneNumber;
    public GameObject gun;
    // Start is called before the first frame update
    void Start()
    {
        passableWall = GameObject.FindGameObjectsWithTag("passable wall");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (touching == true && smth.CompareTag("itembox"))
            {
            Destroy(smth);
            pity += 1;
            randomSpawn();
            }
            if (touching == true && smth.CompareTag("powerup"))
            {
                for (int i = 0; i < passableWall.Length; i++)
                {
                    Destroy(passableWall[i]);
                }
                Destroy(smth);
                pity = 0;
                Instantiate(powerupAura, transform.position, transform.rotation);
            }
            if (touching == true && smth.CompareTag("weapon itembox"))
            {
                Destroy(smth);
                gun = null;
            }
            if (touching == true && smth.CompareTag("Exit"))
            {
                SceneNumber = +1;
                SceneManager.LoadScene(SceneNumber);
            }
        }
        if (pity == NumberofBoxes)
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

        if(randomizedSpawn[randomIndex] != null)
        {
            Vector3 OffsetZ = new Vector3(0, 0, -1);
            GameObject powerup = randomizedSpawn[randomIndex];
            Instantiate(powerup, transform.position + OffsetZ, transform.rotation);
        }
    }
    void pitySpawn()
    {
        Vector3 OffsetZ = new Vector3(0, 0, -1);
        Instantiate(powerupPity, transform.position + OffsetZ, transform.rotation);
    }
}