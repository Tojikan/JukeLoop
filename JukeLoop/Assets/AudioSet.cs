using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AudioSet", menuName = "Audio Set", order = 0)]
public class AudioSet : ScriptableObject
{
    public AudioClip[] audioClips;
}
