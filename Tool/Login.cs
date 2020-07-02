using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class Login:MonoBehaviour
    {
    
    public GameObject FailUI, VictoryUI,PauseUI,JieShaoUI;
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
    public void GoOn()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }
}

