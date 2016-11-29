using UnityEngine;
using System.Collections;

public class HostileAI : BaseMovement {

    Transform player;

	
	// Update is called once per frame
	void Update () {

        //find players ship
        if(player == null)
        {
          GameObject attack =  GameObject.Find("PlayerShip");

            if (attack != null)
            {
                player = attack.transform;
            }
        }

       

        if(player == null)
        {
            return; //look again next frame;
        }

        //the player is in existance look towards the player
        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        //calculate the zAngle to rotate towards the player
        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0,0,zAngle);

         transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotationSpeed * Time.deltaTime);


        //velocity of the ship
        rb.velocity = transform.up * maxSpeed;

    }
}
