using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public bool playing;
    private float Timer;

    void Update()
    {

        if (playing == true)
        {
            Timer += Time.deltaTime;
            int seconds = Mathf.FloorToInt(Timer % 60F);
            TimerText.text = seconds.ToString("0");
        }

    }

}

