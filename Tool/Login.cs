using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class Login:MonoBehaviour
    {
    public AudioSource ClickOn;
    
    public GameObject FailUI, VictoryUI,PauseUI,JieShaoUI,GameAuDio,One,Two;
    public void ToStarScence()
    {
        Application.LoadLevel(0);
    }
    public void ToSelectBattleScence()
    {
        Application.LoadLevel(1);
    }
    public void ToEndScence()
    {
        Application.LoadLevel(2);
    }
    public void ToFirstBattleScence()
    {
        Time.timeScale = 1;
        Application.LoadLevel(3);
    }
    public void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0;
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void JieShao()
    {
        JieShaoUI.SetActive(true);
    }
    public void closeJ()
    {
        JieShaoUI.SetActive(false);
    }
    public void Fail()
    {
        Time.timeScale = 0;
        GameAuDio.SetActive(false);
        FailUI.SetActive(true);
    }
    public void GoOn()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void AudioClick()
    {
        ClickOn.Play();
    }
    public void TwoTime()
    {
        Time.timeScale = 2;
        One.SetActive(false);
        Two.SetActive(true);
    }
    public void OneTime()
    {
        Time.timeScale = 1;
        One.SetActive(true);
        Two.SetActive(false);
    }
}

