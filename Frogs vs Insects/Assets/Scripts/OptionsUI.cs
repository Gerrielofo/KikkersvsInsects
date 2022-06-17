using UnityEngine;

public class OptionsUI : MonoBehaviour
{
    public GameObject optionsUI;
    public static bool wantOptions = false;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            wantOptions = !wantOptions;
            optionsUI.SetActive(wantOptions);
        }
    }
}
