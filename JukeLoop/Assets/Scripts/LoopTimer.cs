using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looper : MonoBehaviour
{
    public int loopTime;                              //current time of the timer
    const float maxTime = 30000000;                     //set a maximum so we don't have a float overflow

    public delegate void TimerEvent(float time);
    public static event TimerEvent TimerEventHandler;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator TimerRoutine()
    {
        loopTime = 0;
        float increment =  CurrentTrackInfo.SecondPerBeat / (float)CurrentTrackInfo.beatIncrements;
        while (true)
        {
            if (TimerEventHandler != null)
                TimerEventHandler(loopTime);

            if (loopTime > maxTime)
                ResetTimer();

            loopTime += 1;
            yield return new WaitForSeconds(increment);

        }
    }

    private void ResetTimer()
    {
        loopTime = 0;
    }
}
