using UnityEngine;

public class OptionsUI : MonoBehaviour
{
    public GameObject optionsUI;
    public static bool wantOptions = false;
 
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

        if (optionsUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
