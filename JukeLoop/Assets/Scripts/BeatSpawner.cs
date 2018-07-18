using BeatBoundEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**Spawns notes. 
 * TO DO: Everything
 * **/
public class BeatSpawner : MonoBehaviour
{
    public GameObject bgNote;                                   //drag in the bg Note prefab for instantiating
    private Beat[] beatArray;


    public void ReceiveBeats(Beat[] beats)
    {
        beatArray = beats;
        SpawnBeat();
    }

    private void SpawnBeat()
    {
        foreach (Beat beat in beatArray)
        {
            GameObject newBeat = Instantiate(bgNote, transform.position, Quaternion.identity);
            BeatNote newBeatData = newBeat.GetComponent<BeatNote>();
            newBeatData.beatData = beat;
            newBeatData.startPosition = transform.position;
        }
    }
}
