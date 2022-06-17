using UnityEngine;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsUI;
    public static bool wantOptions = false;
    public GameObject buttonsUI;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && wantOptions == true)
        {
            OptionsMenuOff();
        }
    }
    public void OptionsMenuOn()
    {
        optionsUI.SetActive(true);
        wantOptions = true;
        buttonsUI.SetActive(false);
    }

    public void OptionsMenuOff()
    {
        optionsUI.SetActive(false);
        wantOptions = false;
        buttonsUI.SetActive(true);
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
