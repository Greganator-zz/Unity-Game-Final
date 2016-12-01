using UnityEngine;
using System.Collections;

public class Health : BasicPowerup {

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
            collider.gameObject.GetComponent<DamagedPlayer>().health += 10;
            RemovePowerup();
        }
    }
}
