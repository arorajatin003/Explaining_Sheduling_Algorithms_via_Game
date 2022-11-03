using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "gameData", menuName = "data")]
public class gameData : ScriptableObject
{
    public bool check1 = true;
    public bool check2 = false;
    public bool check3 = false;
    public bool check4 = false;

    public int currentTime=0;
    public int waitTime=0;

    public bool fifo = true;
    public bool sjf = false;
}
