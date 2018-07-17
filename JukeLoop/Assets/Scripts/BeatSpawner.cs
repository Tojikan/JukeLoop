using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**Spawns notes. 
 * TO DO: Everything
 * **/
public class BeatSpawner : MonoBehaviour
{
    private static Vector3 spawnPosition;                       //the spawn position of the spawner. We only worry about the x position of this object
    public static Vector3 SpawnPosition                         //the accessor. We keep it private because we don't want this data exposed anywhere
    {
        get { return spawnPosition; }
    }                                             
    public GameObject bottomLine;                               //drag in the bottom line as a reference. This sets the y position for spawned BG notes

    private void Awake()
    {
        //get new spawn position. 
        spawnPosition = new Vector3(transform.position.x, bottomLine.transform.position.y, 1);
    }
}
