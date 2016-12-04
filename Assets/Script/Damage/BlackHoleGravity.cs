using UnityEngine;
using System.Collections;

public class BlackHoleGravity : MonoBehaviour {

    //controls the speed at which game objects are pulled towards the center of the black hole
    public float ForceSpeed;
    //trigers when an object colides with one of the gravity spheres of the black hole
    public void OnTriggerStay2D(Collider2D coll)
    {
        GameObject pull;

        //pulls any game object that does not have the tag Unaffected
        if(coll.gameObject.tag != "Unaffected")
        {
            //assing the game object that collides with the trigger to pull game object varable
            pull = coll.gameObject;

            //pull that object towards the center of the black hole by the set forceSpeed muilitplied by
            //the lenght of time the object has be affected.
            pull.transform.position = Vector2.MoveTowards(pull.transform.position,transform.position, ForceSpeed * Time.deltaTime);
        }
        
    }

}
