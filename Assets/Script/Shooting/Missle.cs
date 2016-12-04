using UnityEngine;
using System.Collections;

public class Missle : MonoBehaviour {
//sets velocity of missle
    public float maxSpeed = 6f;

    public GameObject misslePrefabSound;
    public GameObject playload;
    
    void Start()
    {
        Instantiate(misslePrefabSound, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update () {
        //fires the missle at specified velocity
        GetComponent<Rigidbody2D>().velocity = maxSpeed * transform.up;
        //ensure code does not crash when all hostiles are destroyed
        if (GetCloseObjective() != null)
        {
            //calls the get close to object method
            Transform target = GetCloseObjective();

            //sets the missle to the direction of the closest hostle
            transform.up = target.position - transform.position;
        }
    }

    Transform GetCloseObjective()
    {
        GameObject[] allSpawners;
        allSpawners = GameObject.FindGameObjectsWithTag("Hostile");

        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        //checks which Hostile is closest to the player and selects it
        foreach (GameObject potentialTarget in allSpawners)
        {
            Vector3 directionToTarget = potentialTarget.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget.transform;
            }
        }

        return bestTarget;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Hostile")
        {
            Instantiate(playload, collider.transform.position, collider.transform.rotation);
            Destroy(gameObject);
        }
        
    }
}
