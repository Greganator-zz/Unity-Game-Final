using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexMesh : MonoBehaviour {

    //Generates the mesh that will create the hex tile
    Mesh hexMesh;
    //number of vertexes and polys that are in each tile
    List<Vector3> vertices;
    List<int> triangles;
    private int hexagon = 6;

	// Use this for initialization
	void Awake () {
        GetComponent<MeshFilter>().mesh = hexMesh = new Mesh();
        hexMesh.name = "Hex Mesh";
        vertices = new List<Vector3>();
        triangles = new List<int>();
	}
	
    public void Triangulate(HexCell[] cells)
    {
        //Clear old data 
        hexMesh.Clear();
        vertices.Clear();
        triangles.Clear();

        //triangulate all cells individualy
        for(int i = 0; i < cells.Length; i++)
        {
            Triangulate(cells[i]);
        }
        //assing generated vertices and trangles to mesh
        hexMesh.vertices = vertices.ToArray();
        hexMesh.triangles = triangles.ToArray();
        //recaculate mesh normals
        hexMesh.RecalculateNormals();
    }

    void Triangulate(HexCell cell)
    {
        Vector3 center = cell.transform.localPosition;
        for (int i = 0; i < hexagon; i++)
        {
            CreateTriangles(center, center + HexMetrics.corners[i], center + HexMetrics.corners[i + 1]);
        }
    }


    //create the individual triangle
    void CreateTriangles (Vector3 v1, Vector3 v2, Vector3 v3)
    {
        int vertexIndex = vertices.Count;
        vertices.Add(v1);
        vertices.Add(v2);
        vertices.Add(v3);
        triangles.Add(vertexIndex);
        triangles.Add(vertexIndex + 1);
        triangles.Add(vertexIndex + 2);
    }


}
