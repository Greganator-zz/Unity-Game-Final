using UnityEngine;
using System.Collections;

[System.Serializable]
public class HexCoordinates {

    [SerializeField]
    private int x, z;

    //stores protper cordinates of the hexes
    public int X { get { return x; } }
    public int Z { get { return z; } }
    
    //hex cordinate initializer
    public HexCoordinates(int x, int z)
    {
        this.x = x;
        this.z = z;
    }

    //creates set of coordinates useing offest coordinates
    public static HexCoordinates FromOffsetCoordinates( int x, int z)
    {
        return new HexCoordinates(x - z/2, z);
    }

    //sets the world position of the hex hit by the raycast to the Hex position
    public static HexCoordinates SelectedPosition(Vector3 position)
    {

        float x = position.x / (HexMetrics.innerRadius * 2f);
        float y = -x;
        float offset = position.z / (HexMetrics.outerRadius * 3f);
        x -= offset;
        y -= offset;

        //rounds the cordinates for the center of each cell should be zero
        int iX = Mathf.RoundToInt(x);
        int iY = Mathf.RoundToInt(y);
        int iZ = Mathf.RoundToInt(-x - y);

        //if not zero reconstruct x and z for propper values
        if(iX + iY + iZ != 0)
        {
            float deltaX = Mathf.Abs(x - iX);
            float deltaY = Mathf.Abs(y - iY);
            float deltaZ = Mathf.Abs(-x -y - iZ);

            if (deltaX > deltaY && deltaX > deltaZ)
            {
                iX = -iY - iZ;
            }
            else if (deltaZ > deltaY)
            {
                iZ = -iX - iY;
            }
        }

        return new HexCoordinates(iX, iZ);
    }

    public int Y { get { return -X - Z; } }

    //override ToString to retun hex coordinates on a single line
    public override string ToString()
    {
        return "( x : " + X.ToString() + ", y :" + Y.ToString() + ", z : " + Z.ToString() + ")";
    }


}
