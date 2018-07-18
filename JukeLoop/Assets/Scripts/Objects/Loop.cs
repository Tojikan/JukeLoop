using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** A loop is a sequence of beats. 
 * Has two separate arrays for bgBeats and obsBeats.
 * num of beats is used to check player successes and should be generated when a loop is loaded
 * */
namespace BeatBoundEngine
{
    public class Loop
    {
        public Beat[] bgBeats;                          //beats to be played for background
        public ObstacleBeat[] obsBeats;                 //obstacle beats to be dodged
        public int numOfBeats;                          //to be calculated when loop is loaded into game.
    }
}
