using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public float maxSpeed = 5f;

    //sets velocity of bullet
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * maxSpeed;
    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
