using UnityEngine;
using System.Collections;

public class BasicShooting : MonoBehaviour {

    public float fireDelay = 0.25f;
    protected float fireCooldownTimer = 0;
    public Bullet bulletPrefab;
    public float offest = 1f;

    protected void Cooldown()
        {
            fireCooldownTimer -= Time.deltaTime;
        }
	protected void SpawnBullet()
    {
       Bullet bullet = (Bullet)Instantiate(bulletPrefab, transform.position + BulletOffset(), transform.rotation);
        bullet.gameObject.layer = this.gameObject.layer;
    }

    protected Vector3 BulletOffset()
    {

        Vector3 offset = transform.rotation *  new Vector3 (0,offest, 0);
        return offset;
    }

}
