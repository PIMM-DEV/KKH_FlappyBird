using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lrTest : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private linescript line;

    private void Start()
    {
        line.SetUpLine(points);
    }
}
