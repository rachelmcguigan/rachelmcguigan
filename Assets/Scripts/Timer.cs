using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    float timeLeft = 10.0f; //its 10 sec
    public Text timerText;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time:" + timeLeft.ToString("0");
        if (timeLeft < 0)
        {
            GameOver();
        }
    }
    void GameOver()
    {
        timerText.text = "Game Over";
    }
 
}
