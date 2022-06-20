using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsUI;
    public GameObject buttonsUI;
    public GameObject levelSelectUI;
    public GameObject QuitUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OptionsMenuOff();
            LevelSelectOff();
        }
    }
    public void OptionsMenuOn()
    {
        optionsUI.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void OptionsMenuOff()
    {
        optionsUI.SetActive(false);
        buttonsUI.SetActive(true);
    }
    public void LevelSelectOn()
    {
        levelSelectUI.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void LevelSelectOff()
    {
        levelSelectUI.SetActive(false);
        buttonsUI.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitOn()
    {
        QuitUI.SetActive(true);
    }

    public void QuitOff()
    {
        QuitUI.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


    List<int> widths = new List<int>() { 568, 960, 1280, 1920 };
    List<int> heights = new List<int>() { 320, 540, 800, 1080 };

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }

    public void SetFullscreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }
}
