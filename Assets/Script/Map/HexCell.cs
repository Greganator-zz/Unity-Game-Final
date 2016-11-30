using UnityEngine;
using System.Collections;

public class HexCell : MonoBehaviour {

    //Posible game objects that can spawn on a tile
    public GameObject hostileSpawner;
    public GameObject pickup1;
    public GameObject pickup2;
    public GameObject pickup3;

    //personal map coordinates of the hex
    public HexCoordinates coordinates;

    //colour of the particular cell
    public Color cellColour;

	// Use this for initialization
	void Start () {
        //if colour of the tile is red spawn an enemy spawner
	if(cellColour == Color.red)
        {
            Instantiate(hostileSpawner, new Vector3(transform.position.x,transform.position.y,0), new Quaternion(0,0,0,0));
        }
    //if the colour is green spawn randomly one of the pickups
    else if(cellColour == Color.green)
        {
            int choice = Random.Range(1, 4);
            if(choice == 1)
            {
                Instantiate(pickup1, new Vector3(transform.position.x, transform.position.y, 0), new Quaternion(0, 0, 0, 0));
            }
            else if(choice == 2)
            {
                Instantiate(pickup2, new Vector3(transform.position.x, transform.position.y, 0), new Quaternion(0, 0, 0, 0));
            }
            else if(choice == 3)
            {
                Instantiate(pickup3, new Vector3(transform.position.x, transform.position.y, 0), new Quaternion(0, 0, 0, 0));
            }
        }
	}
	
}
