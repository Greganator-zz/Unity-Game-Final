using UnityEngine;
using System.Collections;

public class CamraFollowPlayer : MonoBehaviour {

    GameObject player;
	
	// Update is called once per frame
	void Update () {

       player = GameObject.Find("PlayerShip");
        if (player != null)
        {
            Vector3 targPos = player.transform.position;
            targPos.z = transform.position.z;

            transform.position = targPos;
        }
	}
}
