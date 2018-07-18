using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/** Is a level in the game. Consists of a list of loops. 
 * Bool to check if completed or not
 * Player score to be detected when completed.
 * TODO: Beaten and Score implementation
 * */

namespace BeatBoundEngine
{
    public class Track
    {
        public List<Loop> loopList;                     //list of loops
        public bool beaten;                             //has this track been beaten? TO DO
        public int score;                               //save the player score TO DO
    }
}
