using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    int countDownStartValue = 300;
    public Text timerUI;
    void Start()
    {
        countDownTimer();

    }

    void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            timerUI.text = "Timer : " + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "Game Over!!";
            
        }
    }
  
}
