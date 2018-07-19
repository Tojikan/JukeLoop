using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTimer : MonoBehaviour
{
    public int loopTime;                              //current time of the timer
    public int loopLength;                            //length of the current loop                    

    public delegate void TimerEvent(int time);
    public static event TimerEvent TimerEventHandler;



    //Start timer. Pass in a parameter of the length of the loop
    public void StartTimer(int length)
    {
        loopLength = length;
        StartCoroutine("TimerRoutine");
    }

    //Stop timer
    public void StopTimer()
    {
        StopAllCoroutines();
    }

    //Reset timer
    public void ResetTimer()
    {
        loopTime = 0;
    }

    //timer
    IEnumerator TimerRoutine()
    {
        loopTime = 0;

        //get the time increment between notes. Based on the bpm and the lowest increment (such as 16th note or 8th note)
        float increment =  CurrentTrackInfo.SecondPerBeat / CurrentTrackInfo.beatIncrements;
        while (true)
        {
            //make sure something is subscribed
            if (TimerEventHandler != null)
            {
                TimerEventHandler(loopTime);
            }          
            loopTime += 1;

            //reset 
            if (loopTime > loopLength)
                ResetTimer();
            yield return new WaitForSeconds(increment);

        }
    }

    //make sure timer is stopped if this becomes disabled
    void OnDisable()
    {
        StopTimer();
    }

}
