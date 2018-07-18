using BeatBoundEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Stores all the data regarding a beat and moves the visual note across the screen 
 * Data should be read by the BeatSpawner which feeds the clip into audio and the obstacles into the obstacle manager
 * Whenever this is spawned or set active, it will begin moving. These should be spawned by the spawner which will populate the object with the data 
**/


public class BeatNote : MonoBehaviour
{
    public Beat beatData;
    public Vector3 startPosition;

    //move the note on spawn
    private void Start()
    {
        LoopTimer.TimerEventHandler += TriggerBeat;
    }

    void TriggerBeat(int time)
    {
        if (time == beatData.triggerNote)
        {
            StartCoroutine("MoveNote");
        }
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
            //we divided 
            i += (Time.deltaTime/2) * rate;
            transform.position = Vector3.Lerp(startPosition, BeatRemoval.EndPosition, i);
            yield return null;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Removal")
        {
            StopAllCoroutines();
            transform.position = startPosition;
        }
    }

    private void OnDisable()
    {
        LoopTimer.TimerEventHandler -= TriggerBeat;
    }
}
