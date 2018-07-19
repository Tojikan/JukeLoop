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
    public Beat beatData;                                       //data on the beat
    public Vector3 startPosition;                               //starting position to move back to
    private Vector3 endPosition;                                //end position to move towards      

    //subscribe to the timer event upon start
    private void OnEnable()
    {
        LoopTimer.TimerEventHandler += TriggerBeat;
    }

    //make sure you unsubscribe if deleted
    private void OnDisable()
    {
        LoopTimer.TimerEventHandler -= TriggerBeat;
    }

    private void Start()
    {
        endPosition = new Vector3(BeatRemoval.EndPosition, startPosition.y, 1);
    }

    //Sets the data for the beatnote
    public void SetBeatData(Beat data, Vector3 start)
    {
        beatData = data;
        startPosition = start;
    }

    //this is the function that is subscribed. Causes a note to star tmoving
    void TriggerBeat(int time)
    {
        if (time == beatData.triggerNote)
        {
            StartCoroutine("MoveNote");
        }
    }

    //move back to start position once you reach the end
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Removal")
        {
            StopAllCoroutines();
            transform.position = startPosition;
        }
    }

    //coroutine moves the note by using linear interpolation
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
            transform.position = Vector3.Lerp(startPosition, endPosition, i);
            yield return null;
        }
    }




}
