using UnityEngine;
using System.Collections;

public class PlayerShooting : BasicShooting {

    protected int missileAmmo = 0;
    public float missleCooldownTimer = 0;
    public float missleDelay = 1;
    public Missle misslePrefab;

    void Start()
    {
        missileAmmo = 0;
    }

	// Update is called once per frame
	void Update () {
        //Cooldown per shot
       fireCooldownTimer = Cooldown(fireCooldownTimer);
        missleCooldownTimer = Cooldown(missleCooldownTimer);

        //shoot primary attack on main button press being mouse 0 or A
	    if(Input.GetButton("Fire1") && fireCooldownTimer <= 0)
        {
            //fires and sets cooldown back to the delay
            SpawnBullet();
        }
        if (Input.GetButton("Fire2") && missleCooldownTimer <=0 && missileAmmo > 0)
        {
            missileAmmo--;
            SpawnMissle();
        }
	}

    void SpawnMissle()
    {
        missleCooldownTimer = missleDelay;
        Missle missle = (Missle)Instantiate(misslePrefab, transform.position, transform.rotation);
        missle.gameObject.layer = this.gameObject.layer;
    }
}
