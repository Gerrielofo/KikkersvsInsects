using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text livesTxt;


    void Update()
    {
        livesTxt.text = PlayerStats.Lives.ToString();
    }
}
