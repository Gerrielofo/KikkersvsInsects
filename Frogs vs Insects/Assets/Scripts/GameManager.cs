using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver = false;

    public GameObject gameOverUI;

    
    private void Start()
    {
        GameIsOver = false;

    }
    void Update()
    {
       
        if (Input.GetKey(KeyCode.E))
        {
            EndGame();

        }
        if (GameIsOver)
            return;
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;

        gameOverUI.SetActive(true);
    }
}
