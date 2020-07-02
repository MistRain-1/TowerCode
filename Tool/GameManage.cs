using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
   public class GameManage:MonoBehaviour
    {
    public static GameManage instance;
    public Transform enemy;
    public Transform spawn;
    public float timeCD;
    float waveCD;
    public int enemyCount;
    public int GoHomeCount;
    public Text GoHomeCountText;
    public int deathCount=0;
    public Text enemyCountText;
    int AllenemyCount=30;
    public Text AllenemyCountText;
    public GameObject charaToSpawn;
    public int charaRange;
    public Text charaRangeText;
    public int Allcost=8;
    public Text AllcostText;
    float nexttime=Time.time+1 ;
    public GameObject VictoryUI;
    public GameObject FailUI;
    void Start()
    {
        instance = this;
    }
    void Update()
    {
        if (deathCount == AllenemyCount)
        {
            Time.timeScale = 0;
            VictoryUI.SetActive(true);
        }
        if (GoHomeCount == 0)
        {
            Time.timeScale = 0;
                
            FailUI.SetActive(true);
        }
        if (Time.time >= nexttime)
        {
            Allcost++;
            nexttime = Time.time + 1;
        }
        if (enemyCount < AllenemyCount)
        {
            if (waveCD <= 0f)
            {
                StartCoroutine(Spawn());

                waveCD = timeCD;
            }
        }

        waveCD -= Time.deltaTime;
        GoHomeCountText.text = GoHomeCount.ToString();
        enemyCountText.text = enemyCount.ToString();
        charaRangeText.text = charaRange.ToString();
        AllcostText.text = Allcost.ToString();
        if (Allcost < 0)
        {
            Allcost = 0;
        }
        if (charaRange < 0)
        {
            charaRange = 0;
        }
        
    }
    IEnumerator Spawn()
    {
             enemyCount++;
            Instantiate(enemy, spawn.position, spawn.rotation);
  
        
        
        yield return new WaitForSeconds(5f);
    }
  

    public void SwitchtoSpawn(GameObject temp)
        {
        charaToSpawn = temp;
        }
    }
