using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

    public GameObject spawnPrefab;
    GameObject playerInstance;

    public int numLives = 4;

    float respawnTimer = 1;

	// Use this for initialization
	void Start () {
        spawnPlayer();
	}
	
	// Update is called once per frame
	void Update () {
	    if(playerInstance == null && numLives > 0)
        {
            respawnTimer -= Time.deltaTime;
            if(respawnTimer <= 0)
            {
               spawnPlayer();
            }
            
        }
	}

    void spawnPlayer()
    {
        numLives--;
        respawnTimer = 1;
      playerInstance = (GameObject)Instantiate(spawnPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "PlayerShip";
    }
}
