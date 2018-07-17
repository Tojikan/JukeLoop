using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [HideInInspector]
    public AudioSource[] audioPlayers;            //drag a bunch of audio sources here that plays sounds for Beats
    [HideInInspector]
    public AudioSource[] bgPlayers;               //drag a bunch of audio sources that plays BG sounds that aren't for Beats          


    /// <summary>Receives a Beat and plays it</summary>
    /// <param name="beat">The beat data to be read</param>
    public void ReceiveSound(AudioClip sound, bool isBeat)
    {
        //Check if BG or not
        if (isBeat)
            PlaySound(sound);
        else
            PlayBG(sound);
    }


    //Plays a sound given a source and an audio clip
    private void PlaySound(AudioClip clip)
    {
        AudioSource audio = null;
        
        //iterate over each audiosource to see if there's one not playing any sound.
        for (int i = 0; i < audioPlayers.Length; i++)
        {
            if (!audioPlayers[i].isPlaying)
            {
                audio = audioPlayers[i];
                break;
            }
        }

        //if no available players, default to the first one.
        if (audio == null)
            audio = audioPlayers[0];

        audio.PlayOneShot(clip);
    }


    //plays a bg sound. Same as above except it iterates over the bgPlayers list.
    private void PlayBG(AudioClip clip)
    {
        AudioSource audio = null;

        //iterate over each audiosource to see if there's one not playing any sound.
        for (int i = 0; i < bgPlayers.Length; i++)
        {
            if (!bgPlayers[i].isPlaying)
            {
                audio = bgPlayers[i];
                break;
            }
        }

        //if no available players, default to the first one.
        if (audio == null)
            audio = bgPlayers[0];

        audio.PlayOneShot(clip);
    }
}
