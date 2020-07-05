using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

    class UIFollow:MonoBehaviour
    {
    public GameObject Blood;

    void Update()
    {
        Vector3 bloodPos = Camera.main.WorldToScreenPoint(this.transform.position);
        Blood.transform.position = bloodPos;
    }

    }

