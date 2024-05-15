using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Soru",menuName ="Yeni Soru",order =1)]
public class Soru : ScriptableObject
{
    public string soru;
    public string[] secenekler; 
    public int dogruSecenek;
    public Color color;

}
