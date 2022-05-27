using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Text livesTxt;


    // Update is called once per frame
    void Update()
    {
        livesTxt.text = PlayerStats.Lives.ToString();
    }
}
