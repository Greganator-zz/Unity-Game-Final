using UnityEngine;
using System.Collections;

public class BasicShooting : MonoBehaviour {

    //Standard fire delay
    public float fireDelay = 0.25f;
    //timer bettween shots
    protected float fireCooldownTimer = 0;
    //shot bullet
    public Bullet bulletPrefab;
    //offest of bullet position
    public float offest = 1f;
    //cooldown for bullet time
    protected void Cooldown()
        {
            fireCooldownTimer -= Time.deltaTime;
        }
    //spawns bullet and resets fire delay, sets layer to the shooters layer
	protected void SpawnBullet()
    {
        fireCooldownTimer = fireDelay;
        Bullet bullet = (Bullet)Instantiate(bulletPrefab, transform.position + BulletOffset(), transform.rotation);
        bullet.gameObject.layer = this.gameObject.layer;
    }

    //sets the offset of the bullets inital spawn
    protected Vector3 BulletOffset()
    {

        Vector3 offset = transform.rotation *  new Vector3 (0,offest, 0);
        return offset;
    }

}
