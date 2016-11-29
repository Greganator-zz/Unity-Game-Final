using UnityEngine;
using System.Collections;

public class HostileSpawner : MonoBehaviour {

    public GameObject hostilePrefab;

    public float hostileRate = 30;
    public float nextHostile = 1;
	
	// Update is called once per frame
	void Update () {
        nextHostile -= Time.deltaTime;

        if(nextHostile <= 0)
        {
            nextHostile = hostileRate;

            Instantiate(hostilePrefab, transform.position, transform.rotation);
        }


	}
}
