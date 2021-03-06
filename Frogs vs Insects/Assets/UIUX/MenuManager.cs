using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsUI;
    public GameObject buttonsUI;
    public GameObject levelSelectUI;
    public GameObject quitUI;
    public GameObject frogInfo;
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

    public void FrogInfoOn()
    {
        frogInfo.SetActive(true);
        optionsUI.SetActive(false);
    }
    public void FrogInfoOff()
    {
        frogInfo.SetActive(false);
        optionsUI.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitOn()
    {
        quitUI.SetActive(true);
        buttonsUI.SetActive(false);
    }

    public void QuitOff()
    {
        quitUI.SetActive(false);
        buttonsUI.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


    List<int> widths = new List<int>() { 1920, 1280, 960, 568 };
    List<int> heights = new List<int>() { 1080, 800, 540, 320 };

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
