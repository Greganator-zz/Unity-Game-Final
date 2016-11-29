using UnityEngine;
using System.Collections;

public class PlayerShooting : BasicShooting {

	
	// Update is called once per frame
	void Update () {
        Cooldown();
        //shoot
	    if(Input.GetButton("Fire1") && fireCooldownTimer <= 0)
        {
            Debug.Log("Bang");
            fireCooldownTimer = fireDelay;
            SpawnBullet();
        }
	}
}
