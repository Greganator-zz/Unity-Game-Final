using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float maxSpeed = 5f;
    public float shipSpeed;
    public GameObject bulletPrefabSound;
    //sets velocity of bullet
    void Start()
    {
        if(shipSpeed < 0)
        {
            shipSpeed = 0;
        }
        //fires the bullet at specified velocity
        Debug.Log(shipSpeed);
        Debug.Log(transform.up);
        GetComponent<Rigidbody2D>().velocity = (shipSpeed + maxSpeed) * transform.up ;
        Instantiate(bulletPrefabSound, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
