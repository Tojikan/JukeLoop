using BeatBoundEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/** Reads data from the beat and calls different objects 
 * Gets a collision and checks the tag
 * Then passes in the data to the audio manager and the beat spawner
 * */

public class BeatReader : MonoBehaviour
{
    public AudioPlayer audioPlayer;            //drag a reference to the audio player object in inspector

    //On collision with a beat, call the appropriate functions and components.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Beat")
        {
            Beat beatData= collision.gameObject.GetComponent<BeatNote>().beatData;
            Debug.Log(beatData);
            PlayAudio(beatData, true);
        }

        if (collision.transform.tag == "BG")
        {
            Beat beatData = collision.gameObject.GetComponent<BeatNote>().beatData;
            Debug.Log(beatData);
            PlayAudio(beatData, false);
        }

    }


    //plays a given track
    private void PlayAudio(Beat data, bool isBeat)
    {
        audioPlayer.ReceiveSound(data.audio, isBeat);
    }
}
