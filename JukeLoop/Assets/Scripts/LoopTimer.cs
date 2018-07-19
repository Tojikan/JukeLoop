using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Handles the timing and rhythm. Runs a coroutine which counts up from 0 to a loop length based on the given length of the loop
 * Timing waits a time based on the Second per beat divided by the beatIncrement (the smallest time signature for this song)
 * Then will increment an int variable by 1. Each 1 represents a single beat increment
 * This is run through the event.
 * */
public class LoopTimer : MonoBehaviour
{
    public int loopTime;                              //current time of the timer
    public int loopLength;                            //length of the current loop                    


    //Timer Event and Delegate
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
