using UnityEngine;
using System.Collections;

public static class HexMetrics {

    //size of each indidual hex and spaceing
    public const float outerRadius = 10f;
    public const float innerRadius = outerRadius * 0.866025404f;

    //position of each triangle in the individual hex
    public static Vector3[] corners = 
    {
        new Vector3 (0f, 0f, outerRadius),
        new Vector3 (innerRadius, 0f, 0.5F * outerRadius),
        new Vector3 (innerRadius, 0f, -0.5F * outerRadius),
        new Vector3 (0f, 0f, -outerRadius),
        new Vector3 (-innerRadius, 0f, -0.5F * outerRadius),
        new Vector3 (-innerRadius, 0f, 0.5F * outerRadius),
        new Vector3 (0f, 0f, outerRadius),
    };




}
