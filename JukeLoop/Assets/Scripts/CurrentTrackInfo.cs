﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**Stores information on the current track's BPM. 
 * Set initially in the Game Manager object for prototyping.
 * **/
public static class CurrentTrackInfo
{
    private static int bpm;                                     //BPM of the track
    public static int BPM                                       //read property
    {
        get { return bpm; }
    }
    private static float secondPerBeat;                         //get seconds per beat. Should be calculated when we set the BPM
    public static float SecondPerBeat
    {
        get { return secondPerBeat; }
    }                       //read property


    //sets the bpm for the track
    public static void SetBPM(int beat)
    {
        bpm = beat;
        secondPerBeat =(60.0f / (float)beat);
    }
}
