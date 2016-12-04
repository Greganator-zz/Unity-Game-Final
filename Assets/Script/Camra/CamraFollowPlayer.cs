using UnityEngine;
using System.Collections;

public class CamraFollowPlayer : MonoBehaviour {

    GameObject player;
	
	// Update is called once per frame
	void Update () {
        //finds the game object called PlayerShip
       player = GameObject.Find("PlayerShip");
        if (player != null)
        {
            //sets the camera above the players ship
            Vector3 targPos = player.transform.position;
            targPos.z = transform.position.z;

            transform.position = targPos;
        }
	}
}
