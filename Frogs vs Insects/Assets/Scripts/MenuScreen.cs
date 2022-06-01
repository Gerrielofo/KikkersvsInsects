using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScreen : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
