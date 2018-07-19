using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BeatBoundEngine;

/** Like a beatnote except it has an extra obstacle array to store obstacles
 * 
 * */

public class ObstacleNote : BeatNote
{
    public int[] ObstacleArray = new int[9];                //array that contains the obstacle data

    //set the data
    public void SetObstacleBeatData(ObstacleBeat data, Vector3 start)
    {
        beatData = data;
        startPosition = start;
    }


}
