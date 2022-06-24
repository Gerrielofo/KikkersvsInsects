using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
	public Text roundDied;

	public string menuSceneName = "MainMenu";

	public SceneFader sceneFader;

    public void Start()
    {
		roundDied.text = "You died on round " + PlayerStats.Rounds.ToString() + "!";


    }

    public void Retry()
	{
		sceneFader.FadeTo(SceneManager.GetActiveScene().name);
	}

	public void Menu()
	{
		sceneFader.FadeTo(menuSceneName);
	}

}