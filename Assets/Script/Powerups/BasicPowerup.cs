using UnityEngine;
using System.Collections;

public class BasicPowerup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    protected bool IsComponent(Collider2D collider)
    {
        if(collider.gameObject.GetComponent<PlayerMovement>() != null)
        {
            return true;
        }
        else
            return false;
    }

    protected void RemovePowerup()
    {
        Destroy(gameObject);
    }
}
