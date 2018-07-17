using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Stores all the data regarding a beat and moves the visual note across the screen 
 * Data should be read by the BeatSpawner which feeds the clip into audio and the obstacles into the obstacle manager
 * Whenever this is spawned or set active, it will begin moving. These should be spawned by the spawner which will populate the object with the data 
**/


public class BeatNote : MonoBehaviour
{
    public AudioClip audioTrack;                                //set the clip that the note plays
    public int[] obstacleArray = new int[9];                    //stores the obstacle grid

    //move the note on spawn
    private void Start()
    {
        StartCoroutine("MoveNote");
    }


    //moves the note by using linear interpolation
    private IEnumerator MoveNote()
    {
        float i = 0.0f;
        //get the bpm rate divided by seconds
        float rate = 1 / CurrentTrackInfo.SecondPerBeat;

        //while loop to move
        while (i < 1.0)
        {
            //we divided delta time by 2 in order to slow down the default rate
            i += (Time.deltaTime/2) * rate;
            transform.position = Vector3.Lerp(BeatSpawner.SpawnPosition, BeatRemoval.EndPosition, i);
            yield return null;
        }
    }
}
