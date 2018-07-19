using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for removing notes
//TODO: add object pooling for later
public class BeatRemoval : MonoBehaviour
{
    public static float EndPosition;            //horiz position that all notes move towards


    private void Awake()
    {
        EndPosition = transform.position.x;
    }
}
