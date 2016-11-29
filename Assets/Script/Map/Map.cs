using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

    //size of the map in terms of hex tiles
    //not repersntative of the amount of 
    //world space in unity taken up.

    public int mapWidth = 6;
    public int mapheight = 6;

    public HexCell cellPrefab;

    HexMesh hexMesh;

    HexCell[] cells;

    public Color grassland = Color.green;
    public Color desert = Color.yellow;
    public Color water = Color.blue;
    protected Color mountain = Color.gray;

    private float grasslandChance = .60f;
    private float desertChance = .30f;
    private float waterChance = .10f;
    private float mountainChance = .01f;

    

  //initilazation of the entire map

    void Start()
    {
        hexMesh = GetComponentInChildren<HexMesh>();

        cells = new HexCell[mapheight * mapWidth];

        for (int z = 0, i = 0; z < mapheight; z++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                CreateCell(x, z, i++);
            }
        }

        hexMesh.Triangulate(cells);
    }

    void Update()
    {
        //detect if the mouse clicks on a cell
      //  if (Input.GetMouseButton(0))
       // {
        //    HandleInput();
       // }
    }

    //Hadles if the mouse selects one of the hexigon tiles
    void HandleInput()
    {
        Ray inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
       Debug.DrawRay(inputRay.origin,inputRay.direction * 100000, Color.red,60, false);
        if(Physics.Raycast(inputRay, out hit, 100000))
        {
            
            TouchCell(hit.point);
        }
    }

    void TouchCell(Vector3 position)
    {
        position = transform.InverseTransformPoint(position);
        HexCoordinates coordinates = HexCoordinates.SelectedPosition(position);
        Debug.Log("Touched at: " + coordinates.ToString());
    }


    //generation of individual hex
    void CreateCell(int x, int z, int i)
    {
        Vector3 position;
        position.x = (x + z * 0.5f - z/2) * (HexMetrics.innerRadius * 2f);
        position.y = 0f;
        position.z = z * (HexMetrics.outerRadius * 1.5f);

        HexCell cell = cells[i] = Instantiate<HexCell>(cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
        cell.coordinates = HexCoordinates.FromOffsetCoordinates(x,z);
        cell.cellColour = randomTerrain();
    }

    Color randomTerrain()
    {
        Color terrain = grassland;
        float value = Random.value;
        if (value > grasslandChance)
        {
            terrain = grassland;
        }
        else if (value > desertChance)
        {
            terrain = desert;
        }
        else if (value < mountainChance)
        {
            terrain = mountain;
        }
        else if (value > waterChance)
        {
            terrain = water;
        }
        return terrain;
    }
}
