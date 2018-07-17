using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Manager class. Currently only used to set the BPM
public class GameManager : MonoBehaviour
{
    public int beat;

    // Use this for initialization
    void Start()
    {
        CurrentTrackInfo.SetBPM(beat);
        Debug.Log(CurrentTrackInfo.BPM);
    }
}
