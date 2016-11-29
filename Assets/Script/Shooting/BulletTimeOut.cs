using UnityEngine;
using System.Collections;

public class BulletTimeOut : MonoBehaviour {

    //sets the time the bullit object will be alive for before it destroys itself

    public float timer = 5f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, timer);
	}

}
