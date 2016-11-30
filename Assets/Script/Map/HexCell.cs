using UnityEngine;
using System.Collections;

public class HexCell : MonoBehaviour {
    public GameObject hostileSpawner;
    public GameObject pickup1;
    public GameObject pickup2;
    public GameObject pickup3;

    public HexCoordinates coordinates;

    public Color cellColour;

	// Use this for initialization
	void Start () {
	if(cellColour == Color.red)
        {
            Instantiate(hostileSpawner, new Vector3(transform.position.x,transform.position.y,0), new Quaternion(0,0,0,0));
        }
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
	
	// Update is called once per frame
	void Update () {
	
	}
}
