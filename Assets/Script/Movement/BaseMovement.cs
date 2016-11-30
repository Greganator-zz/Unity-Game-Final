using UnityEngine;
using System.Collections;

public class BaseMovement : MonoBehaviour {

    public float maxSpeed = 5f;
    public float rotationSpeed = 180f;
    protected Rigidbody2D rb;
    protected float mapSizeY = 0;
    protected float mapSizeX = 0;
    public Map currentMap; 

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

        //gets the current map size and tile size sets a restriction minus one tile
        mapSizeX = (currentMap.mapWidth -10)* (HexMetrics.outerRadius); 
        mapSizeY = (currentMap.mapheight -10)* (HexMetrics.outerRadius);
    }
	

}
