using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject optionPanel;

    public void OptionPanel()
    {
        Time.timeScale = 0;
        optionPanel.SetActive(true);
    }

    public void Return()
    {
        Time.timeScale = 1;
        optionPanel.SetActive(false);
    }

    public void GoMainMenú()
    {
        SceneManager.LoadScene("00_Main_Menu");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene("01_Level_1");
        Time.timeScale = 1;
    }

    public void Controls()
    {
        SceneManager.LoadScene("04_Controles");
    }

    public void Volver()
    {
        SceneManager.LoadScene("00_Main_Menu");
        Time.timeScale = 1;
    }

}
