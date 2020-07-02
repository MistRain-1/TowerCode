using System;
using System.Collections.Generic;
using UnityEngine;


    public class Node:MonoBehaviour
    {
    GameObject character;

    void Start()
    {

    }
    void Update()
    {

    }

   private void OnMouseDown()
    {
        if (character = null)
        {
            return;
        }
        character = (GameObject)Instantiate(GameManage.instance.charaToSpawn, transform.position, transform.rotation);
    }
    }

