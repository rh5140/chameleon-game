// From BLANKdev's Line Renderer Tutorial 1 https://www.youtube.com/watch?v=5ZBynjAsfwI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_LineController : MonoBehaviour
{
    // https://docs.unity3d.com/ScriptReference/LineRenderer-numCornerVertices.html
    // Rounded ends?
    private LineRenderer lr;
    private Transform[] points;
    private int numCapVertices = 32;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
        lr.numCapVertices = numCapVertices;
    }

    public void SetUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }
    private void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }

}
