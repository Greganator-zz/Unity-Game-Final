using UnityEngine;
using System.Collections;

public class HostileShooting : BasicShooting {

	
	// Update is called once per frame
	void Update () {
        Cooldown();
        //shoot
        if (fireCooldownTimer <= 0)
        {
            //shoots
            SpawnBullet();
        }
    }
}
