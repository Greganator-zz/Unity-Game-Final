using UnityEngine;
using System.Collections;

public class BlackHoleDestruction : MonoBehaviour
{
    //controls the destruction of objects once they contact with the black hole
    public GameObject crushed;

    //trigers when an object colides with the center of the black hole
    public void OnTriggerEnter2D(Collider2D coll)
    {
        GameObject destroy;

        //destroy the game object that colides if it does not have the tag Unaffected
        //and play a crushed sound.
        if (coll.gameObject.tag != "Unaffected")
        {
            Instantiate(crushed, transform.position, transform.rotation);
            destroy = coll.gameObject;
            Destroy(destroy);

        }
    }
}
