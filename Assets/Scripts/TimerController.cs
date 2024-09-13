using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{


    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] float timerDuration = 10f;
    [SerializeField] float timeRemaining;

    bool isTimerRunning = false;

    void Start()
    {
        gameOverText.enabled = false;
        Time.timeScale = 1;
    }


    void Update()
    {
        if (isTimerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                Debug.Log(timeRemaining);
            }
            else
            {
                gameOverText.enabled = true;
                isTimerRunning = true;
                Time.timeScale = 0;
                Debug.Log("Timer ran out");
            }
        }
    }
    public void StartTimer()
    {
        isTimerRunning = true;
    }

    public void ResetTimer()
    {
        timeRemaining = timerDuration;
        

    }
}
