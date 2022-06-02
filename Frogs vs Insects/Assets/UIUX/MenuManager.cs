using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsUI;
    public bool wantOptions = false;


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
    }

    public void OptionsMenuOff()
    {
        optionsUI.SetActive(false);
        wantOptions = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
