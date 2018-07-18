using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**Base class for a simple note. Triggers when its triggerBeat is reached and a specific audio clip is played
 * TriggerBeat is a specific number that must be reached on the looptimer in order for the note to be spawned. 
 * The looptimer counts up with ints. The time increment between note depends on the track's smallest note (set in currentTrackInfo)
 **/
namespace BeatBoundEngine
{
    [System.Serializable]
    public class Beat
    {
        public int triggerNote;                 //beat is spawned when this number is reached or exceeded
        public AudioClip audio;                 //sound that is played when this hits the beat reader
    }
}
