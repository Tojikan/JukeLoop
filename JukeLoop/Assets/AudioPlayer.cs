using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource[] audioPlayers;            //drag a bunch of audio sources here that plays sounds for Beats
    public AudioSource[] backgroundPlayers;       //drag a bunch of audio sources that plays BG sounds that aren't for Beats          
    public AudioSet audioSet;                    //drag audioset. Contains the playlist that holds all of the sounds for the current song


    /// <summary>Receives a Beat and plays it</summary>
    /// <param name="beat">The beat data to be read</param>
    public void ReceiveSound(BeatData beat)
    {
        PlaySound(beat.audioPlayer, audioSet.audioClips[beat.audioTrack]);
    }


    //Plays a sound given a source and an audio clip
    private void PlaySound(int source, AudioClip clip)
    {
        if (source >= audioPlayers.Length)
            source = 0;

        AudioSource audio = audioPlayers[source];

        if (audio.isPlaying)
            audio.Stop();
        audio.PlayOneShot(clip);
    }
}
