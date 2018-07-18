using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for removing notes
//TODO: add object pooling for later
public class BeatRemoval : MonoBehaviour
{
    private static Vector3 endPosition;                             //endposition to tell notes where they want to move towards. we only care about this object's x position
    public static Vector3 EndPosition                               //accessor because we don't want the data exposed
    {
        get { return endPosition; }
    }                            
    public GameObject bottomLine;                                   //drag in the bottom line so we can set the y position for where to move notes towards. 

    private void Awake()
    {
        endPosition = new Vector3(transform.position.x, bottomLine.transform.position.y, 1);
    }
}
