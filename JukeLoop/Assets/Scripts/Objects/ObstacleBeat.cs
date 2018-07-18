using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Obstacle Beats to be avoided by the player
 * Consists of a 2D array. First index stores the position on the board. Second index stores an int which should refer back to a list of different explosion animation objects.
 * */
namespace BeatBoundEngine
{
    public class ObstacleBeat : Beat
    {
        public int[][] ObstacleArray = new int[9][];               //array of obstacles. first index is for board positions, second index is for which explosion to spawn
    }
}
