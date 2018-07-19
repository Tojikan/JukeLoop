using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeatBoundEngine;

//Manager class. Currently only used to test the game

    /** Game Design Explanation 
     * So first we feed information into this object for testing in regards to the song and beat and notes
     * Then this goes into the BeatSpawners, which spawn beatnote objects accordingly
     * The beatnote objects are constructed and given data in regards to their trigger note and sound
     * The timer starts and counts down the beat increment (such as 1/16th of a beat)
     * When the timer reaches a notes trigger note, it'll cause it to start moving toward the Beatremoval
     * Beat removal upon detecting a collision stops its movement and moves it back to the spawner position
     * The timer loops around once it reaches the end of the loop
     * */

public class GameManager : MonoBehaviour
{
    public int beat;                            //set the BPM of the current loop
    public int noteIncrements;                  //set the time signature for the fastest note
    private LoopTimer timer;                    //timer component should be on same object
    public BeatSpawner bgSpawner;               //drag the BeatSpawner for BG beats for the bottom line
    public BeatSpawner obsSpawner;              //drag the BeatSpawner for main beats 
    [SerializeField]
    public Loop testLoop;                       //enter test loop information here
    


    private void Awake()
    {
        timer = GetComponent<LoopTimer>();
        CurrentTrackInfo.SetBPM(beat);
        bgSpawner.SetBG(testLoop.bgBeats);
        obsSpawner.SetNotes(testLoop.obsBeats);
        CurrentTrackInfo.beatIncrements = noteIncrements;
    }


    // Start the loop
    void Start()
    {
        timer.StartTimer(testLoop.loopLength);
    }
}
