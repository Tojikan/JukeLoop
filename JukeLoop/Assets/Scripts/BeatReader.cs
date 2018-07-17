using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatReader : MonoBehaviour
{
    public AudioPlayer audioPlayer;            //drag a reference to the audio player object in inspector

    //On collision with a beat, call the appropriate functions and components.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Beat")
        {
            BeatNote beatData = collision.gameObject.GetComponent<BeatNote>();
            PlayAudio(beatData, true);
        }

        if (collision.transform.tag == "BG")
        {
            BeatNote beatData = collision.gameObject.GetComponent<BeatNote>();
            PlayAudio(beatData, false);
        }
    }

    //plays a given track
    private void PlayAudio(BeatNote data, bool isBeat)
    {
        audioPlayer.ReceiveSound(data.audioTrack, isBeat);
    }
}
