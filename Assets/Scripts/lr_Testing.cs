// From https://www.youtube.com/watch?v=5ZBynjAsfwI

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_Testing : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private lr_LineController line;

    private void Start()
    {
        line.SetUpLine(points);
    }
}
