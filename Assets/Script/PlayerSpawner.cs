using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {
    //player prefab
    public GameObject spawnPrefab;
    //the player set to proper rotation and name
    GameObject playerInstance;

    //number of total lives
    public int numLives = 4;

    //time it takes in seconds to respawn
    float respawnTimer = 1;

	// Use this for initialization
	void Start () {
        //spawns the player on the start of the game
        spawnPlayer();
	}
	
	// Update is called once per frame
	void Update () {
        //searches for player if they do not exist respawn
	    if(playerInstance == null && numLives > 0)
        {
            respawnTimer -= Time.deltaTime;
            if(respawnTimer <= 0)
            {
               spawnPlayer();
            }
            
        }
	}

    //instanciates player on the spawner location
    void spawnPlayer()
    {
        numLives--;
        respawnTimer = 1;
      playerInstance = (GameObject)Instantiate(spawnPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "PlayerShip";
    }
}
