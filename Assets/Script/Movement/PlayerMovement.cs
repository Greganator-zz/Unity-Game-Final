using UnityEngine;
using System.Collections;

public class PlayerMovement : BaseMovement {
    //the radius around the ship that prevents the ship from leaving the camera view when it hits a wall 
    float shipBoundaryRadius = 0.5f;
    //tracks if camra and ship have reached the edge of the map
    bool edgeOfMap = false;
   
    
	// Update is called once per frame
	void Update () {

        //tracks the position of the player ship
        Vector3 position = transform.position;
        //we get the input from left/right/up/down or wasd keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //we store the two floats in a vector2 object
        Vector2 input = new Vector2(0, verticalInput);

        Vector2 movementBasedOnRotation = transform.TransformVector(input);

        rb.velocity = movementBasedOnRotation * maxSpeed;


        //We rotate the object basied on the left right keys
        rb.angularVelocity = -horizontalInput * rotationSpeed;


        //Ristrict the player to boundrys
        if(position.y + shipBoundaryRadius > mapSizeY)
        {
            position.y = mapSizeY - shipBoundaryRadius;
            edgeOfMap = true;
        }
        if(position.y - shipBoundaryRadius < -mapSizeY)
        {
            position.y = -mapSizeY + shipBoundaryRadius;
            edgeOfMap = true;
        }

        if (position.x + shipBoundaryRadius > mapSizeX)
        {
            position.x = mapSizeX - shipBoundaryRadius;
            edgeOfMap = true;
        }
        if (position.x - shipBoundaryRadius < -mapSizeX)
        {
            position.x = -mapSizeX + shipBoundaryRadius;
            edgeOfMap = true;
        }

        if (edgeOfMap == true)
        {
            transform.position = position;
            edgeOfMap = false;
        }
    }
}
