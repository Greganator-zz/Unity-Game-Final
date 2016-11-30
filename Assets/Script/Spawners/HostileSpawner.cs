using UnityEngine;
using System.Collections;

public class HostileSpawner : MonoBehaviour {
    //all types of hostiles
    public GameObject hostilePrefab1;
    public GameObject hostilePrefab2;
    public GameObject hostilePrefab3;
    public GameObject hostilePrefab4;

    //spawn rate
    public float hostileRate = 30;

    //curent time until next hostile
    public float nextHostile = 1;
	
	// Update is called once per frame
	void Update () {
        nextHostile -= Time.deltaTime;

        if(nextHostile <= 0)
        {
            nextHostile = hostileRate;

            int spawn = Random.Range(0,4);
            //choses the type of hostile randomly to spawn

            if (spawn == 0)
            {
                Instantiate(hostilePrefab1, transform.position, transform.rotation);
            }
            else if(spawn == 1)
            {
                Instantiate(hostilePrefab2, transform.position, transform.rotation);
            }
            else if (spawn == 2)
            {
                Instantiate(hostilePrefab3, transform.position, transform.rotation);
            }
            else if (spawn == 3)
            {
                Instantiate(hostilePrefab4, transform.position, transform.rotation);
            }
        }


	}
}
