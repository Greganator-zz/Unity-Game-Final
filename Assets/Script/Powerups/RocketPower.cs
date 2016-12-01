using UnityEngine;
using System.Collections;

public class RocketPower : BasicPowerup {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (IsComponent(collider))
        {
            collider.gameObject.GetComponent<PlayerShooting>();
            RemovePowerup();
        }
    }
}
