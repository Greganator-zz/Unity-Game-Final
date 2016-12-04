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
    protected float Cooldown(float timmer)
        {
            timmer -= Time.deltaTime;
              return timmer;
        }
    //spawns bullet and resets fire delay, sets layer to the shooters layer
	protected void SpawnBullet()
    {
        float bulletSpread = Random.Range(-.07f,.07f);
        fireCooldownTimer = fireDelay;
        Bullet bullet = (Bullet)Instantiate(bulletPrefab, transform.position + BulletOffset(), new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z + bulletSpread, transform.rotation.w));
        bullet.gameObject.layer = this.gameObject.layer;
        bullet.GetComponent<Bullet>().shipSpeed = GetComponent<Rigidbody2D>().transform.up.x;
    }

    //sets the offset of the bullets inital spawn
    protected Vector3 BulletOffset()
    {

        Vector3 offset = transform.rotation *  new Vector3 (0,offest, 0);
        return offset;
    }

}
