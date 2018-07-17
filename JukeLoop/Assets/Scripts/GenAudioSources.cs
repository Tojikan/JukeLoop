using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generates audio sources for the audio player
public class GenAudioSources : MonoBehaviour
{
    public int numberOfBeatSource;                      //type in inspector number of audio sources you want for playing beats
    public int numberOfBGSource;                        //type in inspector number of audio sources you want for playing BG sounds
    private AudioPlayer player;                         //Audio Player component should be on the same object

    private void Awake()
    {
        player = GetComponent<AudioPlayer>();
    }

    // Use this for initialization
    void Start()
    {
        //initialize arrays
        player.audioPlayers = new AudioSource[numberOfBeatSource];
        player.bgPlayers = new AudioSource[numberOfBGSource];

        //add new audio sources
        for (int i = 0; i < numberOfBeatSource; i++)
        {
            player.audioPlayers[i] = gameObject.AddComponent<AudioSource>();
        }

        for (int i = 0; i < numberOfBGSource; i++)
        {
            player.bgPlayers[i] = gameObject.AddComponent<AudioSource>();
        }
    }

}
