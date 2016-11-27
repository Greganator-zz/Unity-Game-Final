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
  //initilazation of the entire map
    void Awake()
    {
        hexMesh = GetComponentInChildren<HexMesh>();

        cells = new HexCell[mapheight * mapWidth];
        
        for(int z = 0, i = 0; z < mapheight; z++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                CreateCell(x,z, i++);
            }
        }
    }

    void Start()
    {
        hexMesh.Triangulate(cells);
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
    }
}
