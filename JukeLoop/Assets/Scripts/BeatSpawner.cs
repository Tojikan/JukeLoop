using BeatBoundEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**Spawns notes. 
 * Has two spawning functions. One receives for BG notes and one receives or obstacle notes. 
 * **/
public class BeatSpawner : MonoBehaviour
{
    public GameObject notePrefab;                                   //drag in the bg Note prefab for instantiating


    public void SetBG(Beat[] beats)
    {
        foreach (Beat beat in beats)
        {
            GameObject newBeat = Instantiate(notePrefab, transform.position, Quaternion.identity);
            newBeat.GetComponent<BeatNote>().SetBeatData(beat, transform.position);
        }
    }

    public void SetNotes(ObstacleBeat[] beats)
    {
        foreach (ObstacleBeat beat in beats)
        {
            GameObject newBeat = Instantiate(notePrefab, transform.position, Quaternion.identity);
            newBeat.GetComponent<ObstacleNote>().SetObstacleBeatData(beat, transform.position);
        }
    }

}
