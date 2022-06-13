using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool GameIsOver = false;

    public GameObject gameOverUI;

    public GameObject victoryUI;

    private void Start()
    {
        GameIsOver = false;
    }
    void Update()
    {
        if (GameIsOver)
            return;
        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
        if(PlayerStats.Rounds >= 30)
        {
            Victory();
        }
    }

    void EndGame()
    {
        GameIsOver = true;

        gameOverUI.SetActive(true);
    }
    void Victory()
    {
        GameIsOver = true;

        victoryUI.SetActive(true);
    }
}
