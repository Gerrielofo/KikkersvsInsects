using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OptionsUI : MonoBehaviour
{
    public GameObject optionsUI;
    public static bool wantOptions = false;
    public GameObject hudUI;

    public SceneFader sceneFader;
    public string menuSceneName = "MainMenu";
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        optionsUI.SetActive(!optionsUI.activeSelf);
        hudUI.SetActive(!hudUI.activeSelf);
        wantOptions = !wantOptions;
        if (optionsUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        Toggle();
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
        Toggle();
    }
}
