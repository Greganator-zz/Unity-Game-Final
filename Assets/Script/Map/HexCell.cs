using UnityEngine;
using System.Collections;

public class HexCell : MonoBehaviour {
    public GameObject hostileSpawner;

    public HexCoordinates coordinates;

    public Color cellColour;

	// Use this for initialization
	void Start () {
	if(cellColour == Color.red)
        {
            Instantiate(hostileSpawner, new Vector3(transform.position.x,transform.position.y,0), new Quaternion(0,0,0,0));
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
