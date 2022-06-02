using UnityEngine;

public class OptionsUI : MonoBehaviour
{
    public GameObject optionsUI;
    public bool wantOptions = false;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            wantOptions = !wantOptions;
            optionsUI.SetActive(wantOptions);
        }
    }
}
