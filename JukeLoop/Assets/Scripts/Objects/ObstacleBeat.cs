using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Obstacle Beats to be avoided by the player
 * Consists of a 2D array. First index stores the position on the board. Second index stores an int which should refer back to a list of different explosion animation objects.
 * */
namespace BeatBoundEngine
{
    [System.Serializable]
    public class ObstacleBeat : Beat
    {
        public int[] obstacles = new int[9];                        //pattern of obstacles. The index determines which square and the int determines which explosion prefab to spawn
    }
}
