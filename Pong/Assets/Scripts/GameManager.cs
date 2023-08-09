using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject SettingPage;
    public GameObject creditsPage;
   public void GameButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Settings()
    {
        SettingPage.SetActive(true);
    }

    public void QuitSettings()
    {
        SettingPage.SetActive(false);
    }
    
    public void OpenCredits()
    {
        creditsPage.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPage.SetActive(false);
    }

    
}
