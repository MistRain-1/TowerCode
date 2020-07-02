using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    class Character:MonoBehaviour
    {
    public float range;
    public float timefireCD;
    float fireCD;
    GameObject closestEnemy;
    public int cost;
    public bool High;
    public int power;
    public int blood;
    public int MaxStopCount;
    public int StopCount;
    void Awake()
    {
        StopCount = 0;
        if (GameManage.instance.Allcost - cost <= 0)
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {
      
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = (int)transform.position.y;
        GameManage.instance.Allcost -= cost;
        GameManage.instance.charaRange -= 1;
      
        InvokeRepeating("LocknShoot", 0f, 0.4f);
    }
    void LocknShoot()
    {
        GameObject[] enemies=GameObject.FindGameObjectsWithTag("Enemy");
        float closestDis = Mathf.Infinity;
       
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < closestDis)
            {
                closestDis = distanceToEnemy;
                closestEnemy = enemy;
            }
        }
    }
    void Update()
    {
        GetComponentInChildren<Slider>().value = blood;
        if (fireCD <= 0f)
        {   
            closestEnemy.GetComponent<Enemy>().blood -= power;
            fireCD = timefireCD;
        }
        if (blood == 0)
        {
            Destroy(gameObject);
        }
        fireCD -= Time.deltaTime;
    }
        
    }

