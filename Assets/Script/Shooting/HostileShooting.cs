using UnityEngine;
using System.Collections;

public class HostileShooting : BasicShooting {

	
	// Update is called once per frame
	void Update () {

         fireCooldownTimer = Cooldown(fireCooldownTimer);
        //shoot
        if (fireCooldownTimer <= 0)
        {
            //shoots
            SpawnBullet();
        }
    }
}
