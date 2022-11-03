using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "gannChart", menuName = "gannChartData")]
public class gannChart : ScriptableObject
{
    public int currentTime=0;
    public int waitTime=0;
    public int responceTime=0;         
}
