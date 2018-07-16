using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatReader : MonoBehaviour
{
    private AudioPlayer audioPlayer;            //reference to the audioplayer object. Set in Awake
    


    private void Awake()
    {
        audioPlayer = GetComponent<AudioPlayer>();
    }

    //On collision with a beat, call the appropriate functions and components.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Beat")
        {
            BeatData beatData = collision.gameObject.GetComponent<BeatData>();
            PlayAudio(beatData);
        }

        if (collision.transform.tag == "BG")
        {
            BeatData beatData = collision.gameObject.GetComponent<BeatData>();
            PlayAudio(beatData);
        }
    }


    //plays a given track
    private void PlayAudio(BeatData data)
    {
        audioPlayer.ReceiveSound(data);
    }
}
