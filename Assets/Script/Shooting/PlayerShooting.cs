using UnityEngine;
using System.Collections;

public class PlayerShooting : BasicShooting {

	
	// Update is called once per frame
	void Update () {
        //Cooldown per shot
        Cooldown();

        //shoot primary attack on main button press being mouse 0 or A
	    if(Input.GetButton("Fire1") && fireCooldownTimer <= 0)
        {
            //fires and sets cooldown back to the delay
            SpawnBullet();
        }
	}
}
