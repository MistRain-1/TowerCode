using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

  public class WayPoint:MonoBehaviour
    {
    public static Transform[] points;
    void Awake()
    {
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = transform.GetChild(i);
        }
    }
    void Update()
    {

    }
    }

