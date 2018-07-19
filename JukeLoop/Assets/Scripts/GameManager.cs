using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeatBoundEngine;

//Manager class. Currently only used to test the game
public class GameManager : MonoBehaviour
{
    public int beat;
    public int noteIncrements;
    private LoopTimer timer;
    public BeatSpawner spawner;
    [SerializeField]
    public Loop testLoop;
    


    private void Awake()
    {
        timer = GetComponent<LoopTimer>();
        CurrentTrackInfo.SetBPM(beat);
        spawner.ReceiveBeats(testLoop.bgBeats);
        CurrentTrackInfo.beatIncrements = noteIncrements;
    }


    // Use this for initialization
    void Start()
    {
        timer.StartTimer(testLoop.loopLength);
    }
}
