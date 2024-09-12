using UnityEngine;
using UnityEngine.Events;
using System;

[CreateAssetMenu(fileName = "Assets", menuName = "Scriptable Objects/Assets", order = 0)]
public class Assets : ScriptableObject
{
    public GameObject asset;
    
    public int score;

}