using UnityEngine;
using System.Collections;

public class ArrowObjectivePointer : MonoBehaviour
{
    //arrow object 
    public GameObject arrow;

    // Update is called once per frame
    void Update()
    {
        //ensure code does not crash when all spawners are destroyed
        if (GetCloseObjective() != null)
        {
            //calls the get close to object method
            Transform target = GetCloseObjective();

            //sets the arrow to the direction of the closest spawner
            transform.right = target.position - transform.position;
        }

    }

    //searches through all objects with tag of Spawner 
    Transform GetCloseObjective()
    {
        GameObject[] allSpawners;
        allSpawners = GameObject.FindGameObjectsWithTag("Spawner");

        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        //checks which Spawner is closest to the player and selects it
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



}
